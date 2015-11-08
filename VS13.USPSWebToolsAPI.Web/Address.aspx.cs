using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VS13.USPS;

public partial class Address : System.Web.UI.Page {
    //Members
    private string mCallingURI = "";

    //Interface
    protected void Page_Load(object sender,EventArgs e) {
        //Page load event handler
        try {
            if (!Page.IsPostBack) {
                this.mCallingURI = Page.Request.UrlReferrer.AbsoluteUri.Split('?')[0];
                ViewState.Add("CallingURI",this.mCallingURI);

                this.mvwPage.ActiveViewIndex = 0;
                this.txtName.Text = "RAO'S BAKERY & COFFEE CAFE";
                this.txtAddressLine1.Text = "550 NORTH 10TH STREET";
                this.txtAddressLine2.Text = "";
                this.txtCity.Text = "BEAUMONT";
                this.txtState.Text = "TX";
                this.txtZip5.Text = "77702";
                this.txtZip4.Text = "";

            }
            else {
                this.mCallingURI = ViewState["CallingURI"].ToString();
            }
        }
        catch (Exception ex) { reportError(ex,3); }
        finally { OnValidateForm(null,EventArgs.Empty); }
    }
    protected void OnZipChanged(object sender,EventArgs e) {
        //Event handler for change in zip
        try {
            //Validate the zip is servicable; display city/state if it is; notify and log unsupported zips if not
            string zip5 = this.txtZip5.Text;
            if (zip5.Trim().Length == 5) {
                CityStateLookupResponse response = new VS13.USPS.USPSGateway().LookupCityState(zip5);
                if (response == null) {
                    this.txtZip5.Text = "";
                    this.txtZip5.Focus();
                    throw new ApplicationException(zip5 + " is currently not supported.");
                }
                else {
                    this.txtCity.Text = response.ZipCode[0].City.Trim();
                    this.txtState.Text = response.ZipCode[0].State.Trim();
                    this.txtName.Focus();
                }
            }
        }
        catch (Exception ex) { reportError(ex,3); }
    }
    protected void OnValidateForm(object sender,EventArgs e) {
        //Event handler for changes in parameter data
        try {
            this.btnValidate.Enabled = true;    // this.txtAddressLine1.Text.Length > 0 && this.txtCity.Text.Length > 0 && this.txtState.Text.Length == 2 && this.txtZip5.Text.Length == 5;
            this.btnClose.Enabled = true;
        }
        catch (Exception ex) { reportError(ex,3); }
    }
    protected void OnCommand(object sender,CommandEventArgs e) {
        //
        try {
            switch (e.CommandName) {
                case "Validate":
                    bool verified = verifyAddress(this.txtName.Text,this.txtAddressLine1.Text,this.txtAddressLine2.Text,this.txtCity.Text,this.txtState.Text,this.txtZip5.Text,this.txtZip4.Text);
                    if (verified) {
                        showMessageBox("Address is valid.");
                    }
                    break;
                case "ChooseAddress":
                    this.txtName.Text = this.txtSrcName.Text;
                    this.txtAddressLine1.Text = this.txtSrcAddressLine1.Text;
                    this.txtAddressLine2.Text = this.txtSrcAddressLine2.Text;
                    this.txtCity.Text = this.txtSrcCity.Text;
                    this.txtState.Text = this.txtSrcState.Text;
                    this.txtZip5.Text = this.txtSrcZip5.Text;
                    this.txtZip4.Text = this.txtSrcZip4.Text;
                    this.mvwPage.ActiveViewIndex = 0;
                    break;
                case "ChooseUSPSAddress":
                    this.txtName.Text = this.txtUSPSName.Text;
                    this.txtAddressLine1.Text = this.txtUSPSAddressLine1.Text;
                    this.txtAddressLine2.Text = this.txtUSPSAddressLine2.Text;
                    this.txtCity.Text = this.txtUSPSCity.Text;
                    this.txtState.Text = this.txtUSPSState.Text;
                    this.txtZip5.Text = this.txtUSPSZip5.Text;
                    this.txtZip4.Text = this.txtUSPSZip4.Text;
                    this.mvwPage.ActiveViewIndex = 0;
                    break;
                case "Close":
                    Response.Redirect(this.mCallingURI,false);
                    break;
            }
        }
        catch (Exception ex) { reportError(ex,4); }
    }

    private bool verifyAddress(string firmName,string addressLine1,string addressLine2,string city,string state,string zip5,string zip4) {
        //Call USPS WebAPI to verify address
        bool verified = false;
        try {
            AddressValidateResponse avr = new USPSGateway().VerifyAddress(firmName,addressLine1,addressLine2,city,state,zip5,zip4);
            if (avr.Error.Rows.Count > 0) {
                //Bad address or syntax
                string error = (!avr.Error[0].IsNumberNull() ? avr.Error[0].Number : "") + " " + (!avr.Error[0].IsSourceNull() ? avr.Error[0].Source : "") + "\r\n" + (!avr.Error[0].IsDescriptionNull() ? avr.Error[0].Description : "");
                showMessageBox(error);
            }
            else if (avr.Address.Rows.Count > 0) {
                ////Does it match the request?
                string srcAddress = addressLine2.Trim().ToLower() + addressLine1.Trim().ToLower();
                string uspsAddress = (!avr.Address[0].IsAddress1Null() ? avr.Address[0].Address1.Trim().ToLower() : "") + (!avr.Address[0].IsAddress2Null() ? avr.Address[0].Address2.Trim().ToLower() : "");
                bool match = (srcAddress == uspsAddress) &&
                             (city.Trim().ToLower() == (!avr.Address[0].IsCityNull() ? avr.Address[0].City.Trim().ToLower() : "")) &&
                             (state.Trim().ToLower() == (!avr.Address[0].IsStateNull() ? avr.Address[0].State.Trim().ToLower() : "")) &&
                             (zip5.Trim().ToLower() == (!avr.Address[0].IsZip5Null() ? avr.Address[0].Zip5.Trim().ToLower() : ""));
                if (match && avr.Address[0].IsReturnTextNull()) {
                    //Use scrubbed USPS address
                    this.txtName.Text = firmName;
                    this.txtAddressLine1.Text = !avr.Address[0].IsAddress2Null() ? avr.Address[0].Address2 : "";
                    this.txtAddressLine2.Text = !avr.Address[0].IsAddress1Null() ? avr.Address[0].Address1 : "";
                    this.txtCity.Text = !avr.Address[0].IsCityNull() ? avr.Address[0].City : "";
                    this.txtState.Text = !avr.Address[0].IsStateNull() ? avr.Address[0].State : "";
                    this.txtZip5.Text = !avr.Address[0].IsZip5Null() ? avr.Address[0].Zip5 : "";
                    this.txtZip4.Text = !avr.Address[0].IsZip4Null() ? avr.Address[0].Zip4 : "";
                    verified = true;
                }
                else {
                    //Let user choose
                    this.txtSrcName.Text = firmName;
                    this.txtSrcAddressLine1.Text = addressLine1;
                    this.txtSrcAddressLine2.Text = addressLine2;
                    this.txtSrcCity.Text = city;
                    this.txtSrcState.Text = state;
                    this.txtSrcZip5.Text = zip5;
                    this.txtSrcZip4.Text = zip4;

                    this.lblMessage.Text = !avr.Address[0].IsReturnTextNull() ? avr.Address[0].ReturnText : "";
                    this.txtUSPSName.Text = firmName;
                    this.txtUSPSAddressLine1.Text = avr.Address[0].Address2;
                    this.txtUSPSAddressLine2.Text = !avr.Address[0].IsAddress1Null() ? avr.Address[0].Address1 : "";
                    this.txtUSPSCity.Text = !avr.Address[0].IsCityNull() ? avr.Address[0].City : "";
                    this.txtUSPSState.Text = !avr.Address[0].IsStateNull() ? avr.Address[0].State : "";
                    this.txtUSPSZip5.Text = !avr.Address[0].IsZip5Null() ? avr.Address[0].Zip5 : "";
                    this.txtUSPSZip4.Text = !avr.Address[0].IsZip4Null() ? avr.Address[0].Zip4 : "";

                    this.mvwPage.ActiveViewIndex = 1;
                }
            }
            else {
                //Not verified
                showMessageBox("The adddress could not be verified by the US Postal Service.");
            }
        }
        catch (Exception ex) { reportError(ex,4); }
        return verified;
    }
    private void reportError(Exception ex,int logLevel) {
        //Report an exception to the user
        try {
            string msg = ex.Message;
            if (ex.InnerException != null) msg = ex.Message + "\n\n NOTE: " + ex.InnerException.Message;
            showMessageBox(msg);
        }
        catch (Exception) { }
    }
    public void showMessageBox(string message) {
        //
        message = message.Replace("'","").Replace("\n"," ").Replace("\r"," ");
        ScriptManager.RegisterStartupScript(this.lblMsg,typeof(Label),"Error","alert('" + message + "');",true);
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13.USPS {
    //
    public partial class winTests:Form {
        //Members

        //Interface
        public winTests() {
            //Constructor
            InitializeComponent();
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Event handler for form load event
            this.Cursor = Cursors.WaitCursor;
            try {
                this.mAddresses.ReadXml(@"Data\addresses.xml");

                this.cboRequestType.SelectedIndex = 0;
                OnRequestTypeChanged(null,EventArgs.Empty);
            }
            catch (Exception ex) { reportError(ex); }
            finally { OnValidateForm(null,EventArgs.Empty); this.Cursor = Cursors.Default; }
        }
        private void OnRequestTypeChanged(object sender,EventArgs e) {
            //Event handler for change in request type
            try {
                //Reset request
                this.txtReqName.Text = this.txtReqAddressLine1.Text = this.txtReqAddressLine2.Text = this.txtReqCity.Text = this.txtReqState.Text = this.txtReqZip5.Text = "";

                //Configure the request
                switch (this.cboRequestType.SelectedItem.ToString()) {
                    case "Verify Address":
                        this.txtReqName.Enabled = true;
                        this.txtReqAddressLine1.Enabled = true;
                        this.txtReqAddressLine2.Enabled = true;
                        this.txtReqCity.Enabled = true;
                        this.txtReqState.Enabled = true;
                        this.txtReqZip5.Enabled = this.txtReqZip4.Enabled = true;
                        break;
                    case "Lookup City/State":
                        this.txtReqName.Enabled = false;
                        this.txtReqAddressLine1.Enabled = false;
                        this.txtReqAddressLine2.Enabled = false;
                        this.txtReqCity.Enabled = false;
                        this.txtReqState.Enabled = false;
                        this.txtReqZip5.Enabled = true;
                        this.txtReqZip4.Enabled = false;
                        break;
                    case "Lookup Zip":
                        this.txtReqName.Enabled = true;
                        this.txtReqAddressLine1.Enabled = true;
                        this.txtReqAddressLine2.Enabled = true;
                        this.txtReqCity.Enabled = true;
                        this.txtReqState.Enabled = true;
                        this.txtReqZip5.Enabled = false;
                        this.txtReqZip4.Enabled = false;
                        break;
                }
                //Reset view
                this.txtReturnText.Text = this.txtResName.Text = this.txtResAddressLine1.Text = this.txtResAddressLine2.Text = this.txtResCity.Text = this.txtResState.Text = this.txtResZip5.Text = "";
                this.txtErrNumber.Text = this.txtErrSource.Text = this.txtErrDescription.Text = this.txtErrHelpFile.Text = this.txtErrHelpContext.Text = "";

                //Set services
                this.btnVerifyAddress.Enabled = this.cboRequestType.SelectedItem.ToString() == "Verify Address";
                this.btnLookupCityState.Enabled = this.cboRequestType.SelectedItem.ToString() == "Lookup City/State";
                this.btnLookupZip.Enabled = this.cboRequestType.SelectedItem.ToString() == "Lookup Zip";
            }
            catch (Exception ex) { reportError(ex); }
        }
        private void OnAddressSelected(object sender,EventArgs e) {
            //Event handler for a sample address selected
            try {
                this.txtReqName.Text = this.grdAddresses.SelectedRows[0].Cells["colName"].Value.ToString();
                this.txtReqAddressLine1.Text = this.grdAddresses.SelectedRows[0].Cells["colAddressLine1"].Value.ToString();
                this.txtReqAddressLine2.Text = this.grdAddresses.SelectedRows[0].Cells["colAddressLine2"].Value.ToString();
                this.txtReqCity.Text = this.grdAddresses.SelectedRows[0].Cells["colCity"].Value.ToString();
                this.txtReqState.Text = this.grdAddresses.SelectedRows[0].Cells["colState"].Value.ToString();
                this.txtReqZip5.Text = this.grdAddresses.SelectedRows[0].Cells["colZip"].Value.ToString();
            }
            catch (Exception ex) { reportError(ex); }
        }
        private void OnValidateForm(object sender,EventArgs e) {
            //Set user services
            try {
                //Set services
                this.btnVerifyAddress.Enabled = this.cboRequestType.SelectedItem.ToString() == "Verify Address" && (this.txtReqAddressLine1.Text.Length > 0 && this.txtReqCity.Text.Length > 0 && this.txtReqState.Text.Length == 2);
                this.btnLookupCityState.Enabled = this.cboRequestType.SelectedItem.ToString() == "Lookup City/State" && (this.txtReqZip5.Text.Length == 5);
                this.btnLookupZip.Enabled = this.cboRequestType.SelectedItem.ToString() == "Lookup Zip" && (this.txtReqAddressLine1.Text.Length > 0 && this.txtReqCity.Text.Length > 0 && this.txtReqState.Text.Length == 2);
            }
            catch (Exception ex) { reportError(ex); }
        }
        private void OnCommandClick(object sender,System.EventArgs e) {
            //Event handler for button selection
            this.Cursor = Cursors.WaitCursor;
            try {
                //Reset response
                this.txtReturnText.Text = this.txtResName.Text = this.txtResAddressLine1.Text = this.txtResAddressLine2.Text = this.txtResCity.Text = this.txtResState.Text = this.txtResZip5.Text = this.txtResZip4.Text = "";
                this.txtErrNumber.Text = this.txtErrSource.Text = this.txtErrDescription.Text = this.txtErrHelpFile.Text = this.txtErrHelpContext.Text = "";
                this._lblResAddressLine1.ForeColor = this._lblResCity.ForeColor = this._lblResState.ForeColor = this._lblResZip.ForeColor = SystemColors.ControlText;
                
                //USPS services
                Button btn = (Button)sender;
                switch (btn.Name) {
                    case "btnClose":
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        break;
                    case "btnVerifyAddress":
                        //Validate\correct the address; exception is thrown on address error so diaog stays open for correction
                        AddressValidateResponse avr = USPSGateway.VerifyAddress("",this.txtReqAddressLine1.Text,this.txtReqAddressLine2.Text,this.txtReqCity.Text,this.txtReqState.Text,this.txtReqZip5.Text,"");
                        if(avr.Error.Rows.Count > 0) {
                            //Bad address
                            this.txtErrNumber.Text = !avr.Error[0].IsNumberNull() ? avr.Error[0].Number : "";
                            this.txtErrSource.Text = !avr.Error[0].IsSourceNull() ? avr.Error[0].Source : "";
                            this.txtErrDescription.Text = !avr.Error[0].IsDescriptionNull() ? avr.Error[0].Description : "";
                            this.txtErrHelpFile.Text = !avr.Error[0].IsHelpFileNull() ? avr.Error[0].HelpFile : "";
                            this.txtErrHelpContext.Text = !avr.Error[0].IsHelpContextNull() ? avr.Error[0].HelpContext : "";
                        }
                        else if (avr.Address.Rows.Count > 0) {
                            //Cleansed address
                            this.txtResAddressLine1.Text = avr.Address[0].Address2;
                            this.txtResAddressLine2.Text = !avr.Address[0].IsAddress1Null() ? avr.Address[0].Address1 : "";
                            this.txtResCity.Text = !avr.Address[0].IsCityNull() ? avr.Address[0].City : "";
                            this.txtResState.Text = !avr.Address[0].IsStateNull() ? avr.Address[0].State : "";
                            this.txtResZip5.Text = !avr.Address[0].IsZip5Null() ? avr.Address[0].Zip5 : "";
                            this.txtResZip4.Text = !avr.Address[0].IsZip4Null() ? avr.Address[0].Zip4 : "";
                            this.txtReturnText.Text = !avr.Address[0].IsReturnTextNull() ? avr.Address[0].ReturnText : "";

                            //Does it match the request?
                            string reqAddress = this.txtReqAddressLine1.Text.Trim().ToLower() + this.txtReqAddressLine2.Text.Trim().ToLower();
                            string resAddress = this.txtResAddressLine1.Text.Trim().ToLower() + this.txtResAddressLine2.Text.Trim().ToLower();
                            this._lblResAddressLine1.ForeColor = resAddress == reqAddress ? SystemColors.ControlText : Color.Red;
                            this._lblResCity.ForeColor = this.txtResCity.Text.Trim().ToLower() == this.txtReqCity.Text.Trim().ToLower() ? SystemColors.ControlText : Color.Red;
                            this._lblResState.ForeColor = this.txtResState.Text.Trim().ToLower() == this.txtReqState.Text.Trim().ToLower() ? SystemColors.ControlText : Color.Red;
                            this._lblResZip.ForeColor = this.txtResZip5.Text.Trim().ToLower() == this.txtReqZip5.Text.Trim().ToLower() ? SystemColors.ControlText : Color.Red;
                        }
                        else {
                            //Not verified
                            MessageBox.Show("The adddress could not be verified by the US Postal Service.","USPS WebTools API",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        break;
                    case "btnLookupCityState":
                        CityStateLookupResponse cslr = USPSGateway.LookupCityState(this.txtReqZip5.Text);
                        if (cslr.Error.Rows.Count > 0) {
                            this.txtErrNumber.Text = !cslr.Error[0].IsNumberNull() ? cslr.Error[0].Number : "";
                            this.txtErrSource.Text = !cslr.Error[0].IsSourceNull() ? cslr.Error[0].Source : "";
                            this.txtErrDescription.Text = !cslr.Error[0].IsDescriptionNull() ? cslr.Error[0].Description : "";
                            this.txtErrHelpFile.Text = !cslr.Error[0].IsHelpFileNull() ? cslr.Error[0].HelpFile : "";
                            this.txtErrHelpContext.Text = !cslr.Error[0].IsHelpContextNull() ? cslr.Error[0].HelpContext : "";
                        }
                        else if (cslr.ZipCode.Rows.Count > 0) {
                            this.txtReturnText.Text = !cslr.ZipCode[0].IsReturnTextNull() ? cslr.ZipCode[0].ReturnText : "";
                            this.txtResCity.Text = !cslr.ZipCode[0].IsCityNull() ? cslr.ZipCode[0].City : "";
                            this.txtResState.Text = !cslr.ZipCode[0].IsStateNull() ? cslr.ZipCode[0].State : "";
                            this.txtResZip5.Text = !cslr.ZipCode[0].IsZip5Null() ? cslr.ZipCode[0].Zip5 : "";
                        }
                        else {
                            //Not verified
                            MessageBox.Show("The adddress could not be verified by the US Postal Service.","USPS WebTools API",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        break;
                    case "btnLookupZip":
                        ZipCodeLookupResponse zclr = USPSGateway.LookupZipCode("",this.txtReqAddressLine1.Text,this.txtReqAddressLine2.Text,this.txtReqCity.Text,this.txtReqState.Text);
                        if (zclr.Error.Rows.Count > 0) {
                            this.txtErrNumber.Text = !zclr.Error[0].IsNumberNull() ? zclr.Error[0].Number : "";
                            this.txtErrSource.Text = !zclr.Error[0].IsSourceNull() ? zclr.Error[0].Source : "";
                            this.txtErrDescription.Text = !zclr.Error[0].IsDescriptionNull() ? zclr.Error[0].Description : "";
                            this.txtErrHelpFile.Text = !zclr.Error[0].IsHelpFileNull() ? zclr.Error[0].HelpFile : "";
                            this.txtErrHelpContext.Text = !zclr.Error[0].IsHelpContextNull() ? zclr.Error[0].HelpContext : "";
                        }
                        else if (zclr.Address.Rows.Count > 0) {
                            this.txtReturnText.Text = !zclr.Address[0].IsReturnTextNull() ? zclr.Address[0].ReturnText : "";
                            this.txtResAddressLine1.Text = !zclr.Address[0].IsAddress1Null() ? zclr.Address[0].Address1 : "";
                            this.txtResAddressLine2.Text = !zclr.Address[0].IsAddress2Null() ? zclr.Address[0].Address2 : "";
                            this.txtResCity.Text = !zclr.Address[0].IsCityNull() ? zclr.Address[0].City : "";
                            this.txtResState.Text = !zclr.Address[0].IsStateNull() ? zclr.Address[0].State : "";
                            this.txtResZip5.Text = !zclr.Address[0].IsZip5Null() ? zclr.Address[0].Zip5 : "";
                            this.txtResZip4.Text = !zclr.Address[0].IsZip4Null() ? zclr.Address[0].Zip4 : "";
                        }
                        else {
                            //Not verified
                            MessageBox.Show("The adddress could not be verified by the US Postal Service.","USPS WebTools API",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        break;
                }
            }
            catch (Exception ex) { reportError(ex); }
            finally { this.Cursor = Cursors.Default; }
        }
        private void reportError(Exception ex) {
            //Report an exception to the user
            try {
                string src = (ex.Source != null) ? ex.Source + "-\n" : "";
                string msg = src + ex.Message;
                if (ex.InnerException != null) {
                    if ((ex.InnerException.Source != null)) src = ex.InnerException.Source + "-\n";
                    msg = src + ex.Message + "\n\n NOTE: " + ex.InnerException.Message;
                }
                MessageBox.Show(msg,"USPS WebTools",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception) { }
        }
    }
}

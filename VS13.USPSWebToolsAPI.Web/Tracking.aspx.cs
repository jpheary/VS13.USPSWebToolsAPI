using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VS13.USPS;

public partial class Tracking : System.Web.UI.Page {
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
            }
            else {
                this.mCallingURI = ViewState["CallingURI"].ToString();
            }
        }
        catch (Exception ex) { reportError(ex,3); }
        finally { OnValidateForm(null,EventArgs.Empty); }
    }
    protected void OnValidateForm(object sender,EventArgs e) {
        //Event handler for changes in parameter data
        try {
            this.btnTrack.Enabled = true;
            this.btnClose1.Enabled = this.btnClose2.Enabled = true;
        }
        catch (Exception ex) { reportError(ex,3); }
    }
    protected void OnCommand(object sender,CommandEventArgs e) {
        //
        try {
            switch (e.CommandName) {
                case "Track":
                    bool tracked = trackRequest(this.txtItemNumber.Text);
                    if (tracked) this.mvwPage.ActiveViewIndex = 1;
                    break;
                case "Close1":
                    Response.Redirect(this.mCallingURI,false);
                    break;
                case "Close2":
                    this.mvwPage.ActiveViewIndex = 0;
                    break;
            }
        }
        catch (Exception ex) { reportError(ex,4); }
    }

    private bool trackRequest(string itemNumber) {
        //Call USPS WebAPI to track item
        bool tracked = false;
        try {
            TrackResponse response = new USPSGateway().TrackRequest(itemNumber);
            if (response.Error.Rows.Count > 0) {
                //Bad item or syntax
                string error = (!response.Error[0].IsNumberNull() ? response.Error[0].Number : "") + " " + (!response.Error[0].IsSourceNull() ? response.Error[0].Source : "") + "\r\n" + (!response.Error[0].IsDescriptionNull() ? response.Error[0].Description : "");
                showMessageBox(error);
            }
            else if (response.TrackInfo.Rows.Count > 0) {
                //Item found
                this.txtSummary.Text = response.TrackInfo[0].TrackSummary;
                //TODO: Detail
                tracked = true;
            }
            else {
                //Not verified
                showMessageBox("The item could not be tracked by the US Postal Service.");
            }
        }
        catch (Exception ex) { reportError(ex,4); }
        return tracked;
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
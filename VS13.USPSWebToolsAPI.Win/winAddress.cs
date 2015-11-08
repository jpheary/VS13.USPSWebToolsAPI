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
    public partial class winAddress:Form {
        //Members

        //Interface
        public winAddress() {
            //Constructor
            InitializeComponent();
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Event handler for form load event
            this.Cursor = Cursors.WaitCursor;
            try {
                this.txtName.Text = this.txtAddressLine1.Text = this.txtAddressLine2.Text = this.txtCity.Text = this.txtState.Text = this.txtZip5.Text = this.txtZip4.Text = "";
            }
            catch (Exception ex) { reportError(ex); }
            finally { OnValidateForm(null,EventArgs.Empty); this.Cursor = Cursors.Default; }
        }
        private void OnValidateForm(object sender,EventArgs e) {
            //Set user services
            try {
                //Set services
                this.btnVerifyAddress.Enabled = this.txtAddressLine1.Text.Length > 0 && this.txtCity.Text.Length > 0 && this.txtState.Text.Length == 2; // && this.txtZip5.Text.Length == 5;
            }
            catch (Exception ex) { reportError(ex); }
        }
        private void OnCommandClick(object sender,System.EventArgs e) {
            //Event handler for button selection
            this.Cursor = Cursors.WaitCursor;
            try {
                //USPS services
                Button btn = (Button)sender;
                switch (btn.Name) {
                    case "btnClose":
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        break;
                    case "btnVerifyAddress":
                        //Validate\correct the address
                        dlgVerifyAddress verify = new dlgVerifyAddress();
                        if (verify.VerifyAddress(this.txtName.Text,this.txtAddressLine1.Text,this.txtAddressLine2.Text,this.txtCity.Text,this.txtState.Text,this.txtZip5.Text,this.txtZip4.Text)) {
                            this.txtName.Text = verify.FirmName;
                            this.txtAddressLine1.Text = verify.AddressLine1;
                            this.txtAddressLine2.Text = verify.AddressLine2;
                            this.txtCity.Text = verify.City;
                            this.txtState.Text = verify.State;
                            this.txtZip5.Text = verify.Zip5;
                            this.txtZip4.Text = verify.Zip4;

                            MessageBox.Show("Address is valid.","USPS WebTools API",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

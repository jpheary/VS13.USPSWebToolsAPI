namespace VS13.USPS {
    partial class winAddress {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this._lblName = new System.Windows.Forms.Label();
            this._lblState = new System.Windows.Forms.Label();
            this._lblAddress = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this._lblCity = new System.Windows.Forms.Label();
            this.btnVerifyAddress = new System.Windows.Forms.Button();
            this.txtZip4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip5 = new System.Windows.Forms.TextBox();
            this._lblZip = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 58);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 21);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(128, 120);
            this.txtAddressLine2.MaxLength = 40;
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(291, 21);
            this.txtAddressLine2.TabIndex = 4;
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(128, 180);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(58, 21);
            this.txtState.TabIndex = 6;
            this.txtState.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblName
            // 
            this._lblName.Location = new System.Drawing.Point(29, 60);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(87, 23);
            this._lblName.TabIndex = 45;
            this._lblName.Text = "Name";
            this._lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblState
            // 
            this._lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblState.Location = new System.Drawing.Point(29, 180);
            this._lblState.Name = "_lblState";
            this._lblState.Size = new System.Drawing.Size(87, 23);
            this._lblState.TabIndex = 48;
            this._lblState.Text = "State";
            this._lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblAddress
            // 
            this._lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAddress.Location = new System.Drawing.Point(29, 90);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(87, 23);
            this._lblAddress.TabIndex = 46;
            this._lblAddress.Text = "Address";
            this._lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(128, 150);
            this.txtCity.MaxLength = 40;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(262, 21);
            this.txtCity.TabIndex = 5;
            this.txtCity.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(128, 90);
            this.txtAddressLine1.MaxLength = 40;
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(291, 21);
            this.txtAddressLine1.TabIndex = 3;
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblCity
            // 
            this._lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCity.Location = new System.Drawing.Point(29, 150);
            this._lblCity.Name = "_lblCity";
            this._lblCity.Size = new System.Drawing.Size(87, 23);
            this._lblCity.TabIndex = 47;
            this._lblCity.Text = "City";
            this._lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVerifyAddress
            // 
            this.btnVerifyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerifyAddress.Location = new System.Drawing.Point(223, 261);
            this.btnVerifyAddress.Name = "btnVerifyAddress";
            this.btnVerifyAddress.Size = new System.Drawing.Size(117, 27);
            this.btnVerifyAddress.TabIndex = 1;
            this.btnVerifyAddress.Text = "Verify Address";
            this.btnVerifyAddress.UseVisualStyleBackColor = true;
            this.btnVerifyAddress.Click += new System.EventHandler(this.OnCommandClick);
            // 
            // txtZip4
            // 
            this.txtZip4.Location = new System.Drawing.Point(350, 181);
            this.txtZip4.MaxLength = 4;
            this.txtZip4.Name = "txtZip4";
            this.txtZip4.Size = new System.Drawing.Size(40, 21);
            this.txtZip4.TabIndex = 8;
            this.txtZip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZip4.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(332, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtZip5
            // 
            this.txtZip5.Location = new System.Drawing.Point(268, 181);
            this.txtZip5.MaxLength = 5;
            this.txtZip5.Name = "txtZip5";
            this.txtZip5.Size = new System.Drawing.Size(58, 21);
            this.txtZip5.TabIndex = 7;
            this.txtZip5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZip5.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblZip
            // 
            this._lblZip.Location = new System.Drawing.Point(227, 180);
            this._lblZip.Name = "_lblZip";
            this._lblZip.Size = new System.Drawing.Size(29, 23);
            this._lblZip.TabIndex = 52;
            this._lblZip.Text = "Zip";
            this._lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(346, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnCommandClick);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(32, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(401, 23);
            this.lblInstructions.TabIndex = 54;
            this.lblInstructions.Text = "Enter street address, city, and state and click Verify Address.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // winAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 301);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtZip4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip5);
            this.Controls.Add(this._lblZip);
            this.Controls.Add(this.btnVerifyAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this._lblState);
            this.Controls.Add(this._lblAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this._lblCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "winAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblState;
        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label _lblCity;
        private System.Windows.Forms.Button btnVerifyAddress;
        private System.Windows.Forms.TextBox txtZip4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip5;
        private System.Windows.Forms.Label _lblZip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInstructions;
    }
}
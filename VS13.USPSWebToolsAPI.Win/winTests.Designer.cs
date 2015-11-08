namespace VS13.USPS {
    partial class winTests {
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
            this._lblReqZip = new System.Windows.Forms.Label();
            this.txtReqZip5 = new System.Windows.Forms.TextBox();
            this.btnVerifyAddress = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtReqState = new System.Windows.Forms.TextBox();
            this._lblReqState = new System.Windows.Forms.Label();
            this.txtReqCity = new System.Windows.Forms.TextBox();
            this._lblReqCity = new System.Windows.Forms.Label();
            this.txtReqAddressLine1 = new System.Windows.Forms.TextBox();
            this._lblReqAddressLine1 = new System.Windows.Forms.Label();
            this.txtReqName = new System.Windows.Forms.TextBox();
            this._lblReqName = new System.Windows.Forms.Label();
            this.txtReqAddressLine2 = new System.Windows.Forms.TextBox();
            this._lblReqAddressLine2 = new System.Windows.Forms.Label();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.txtReqZip4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdAddresses = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZip4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAddresses = new VS13.Data.AddressDataset();
            this._lblRequestType = new System.Windows.Forms.Label();
            this.cboRequestType = new System.Windows.Forms.ComboBox();
            this.gbResponse = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResZip4 = new System.Windows.Forms.TextBox();
            this.txtReturnText = new System.Windows.Forms.TextBox();
            this._lblReturnText = new System.Windows.Forms.Label();
            this.txtResName = new System.Windows.Forms.TextBox();
            this.txtResAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtResZip5 = new System.Windows.Forms.TextBox();
            this._lblResAddressLine2 = new System.Windows.Forms.Label();
            this.gbError = new System.Windows.Forms.GroupBox();
            this.txtErrNumber = new System.Windows.Forms.TextBox();
            this.txtErrDescription = new System.Windows.Forms.TextBox();
            this._lblErrDescription = new System.Windows.Forms.Label();
            this.txtErrHelpContext = new System.Windows.Forms.TextBox();
            this._lblErrNumber = new System.Windows.Forms.Label();
            this._lblErrSource = new System.Windows.Forms.Label();
            this.txtErrHelpFile = new System.Windows.Forms.TextBox();
            this.txtErrSource = new System.Windows.Forms.TextBox();
            this._lblErrHelp = new System.Windows.Forms.Label();
            this._lblResZip = new System.Windows.Forms.Label();
            this.txtResState = new System.Windows.Forms.TextBox();
            this._lblResName = new System.Windows.Forms.Label();
            this._lblResState = new System.Windows.Forms.Label();
            this._lblResAddressLine1 = new System.Windows.Forms.Label();
            this.txtResCity = new System.Windows.Forms.TextBox();
            this.txtResAddressLine1 = new System.Windows.Forms.TextBox();
            this._lblResCity = new System.Windows.Forms.Label();
            this.btnLookupZip = new System.Windows.Forms.Button();
            this.btnLookupCityState = new System.Windows.Forms.Button();
            this.gbRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAddresses)).BeginInit();
            this.gbResponse.SuspendLayout();
            this.gbError.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblReqZip
            // 
            this._lblReqZip.Location = new System.Drawing.Point(227, 216);
            this._lblReqZip.Name = "_lblReqZip";
            this._lblReqZip.Size = new System.Drawing.Size(29, 23);
            this._lblReqZip.TabIndex = 27;
            this._lblReqZip.Text = "Zip";
            this._lblReqZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReqZip5
            // 
            this.txtReqZip5.Location = new System.Drawing.Point(268, 217);
            this.txtReqZip5.MaxLength = 5;
            this.txtReqZip5.Name = "txtReqZip5";
            this.txtReqZip5.Size = new System.Drawing.Size(58, 21);
            this.txtReqZip5.TabIndex = 8;
            this.txtReqZip5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReqZip5.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // btnVerifyAddress
            // 
            this.btnVerifyAddress.Location = new System.Drawing.Point(63, 437);
            this.btnVerifyAddress.Name = "btnVerifyAddress";
            this.btnVerifyAddress.Size = new System.Drawing.Size(117, 27);
            this.btnVerifyAddress.TabIndex = 2;
            this.btnVerifyAddress.Text = "VerifyAddress";
            this.btnVerifyAddress.UseVisualStyleBackColor = true;
            this.btnVerifyAddress.Click += new System.EventHandler(this.OnCommandClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(876, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnCommandClick);
            // 
            // txtReqState
            // 
            this.txtReqState.Location = new System.Drawing.Point(128, 216);
            this.txtReqState.MaxLength = 2;
            this.txtReqState.Name = "txtReqState";
            this.txtReqState.Size = new System.Drawing.Size(58, 21);
            this.txtReqState.TabIndex = 7;
            this.txtReqState.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblReqState
            // 
            this._lblReqState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReqState.Location = new System.Drawing.Point(29, 216);
            this._lblReqState.Name = "_lblReqState";
            this._lblReqState.Size = new System.Drawing.Size(87, 23);
            this._lblReqState.TabIndex = 35;
            this._lblReqState.Text = "State";
            this._lblReqState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReqCity
            // 
            this.txtReqCity.Location = new System.Drawing.Point(128, 186);
            this.txtReqCity.MaxLength = 40;
            this.txtReqCity.Name = "txtReqCity";
            this.txtReqCity.Size = new System.Drawing.Size(262, 21);
            this.txtReqCity.TabIndex = 6;
            this.txtReqCity.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblReqCity
            // 
            this._lblReqCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReqCity.Location = new System.Drawing.Point(29, 186);
            this._lblReqCity.Name = "_lblReqCity";
            this._lblReqCity.Size = new System.Drawing.Size(87, 23);
            this._lblReqCity.TabIndex = 34;
            this._lblReqCity.Text = "City";
            this._lblReqCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReqAddressLine1
            // 
            this.txtReqAddressLine1.Location = new System.Drawing.Point(128, 126);
            this.txtReqAddressLine1.MaxLength = 40;
            this.txtReqAddressLine1.Name = "txtReqAddressLine1";
            this.txtReqAddressLine1.Size = new System.Drawing.Size(291, 21);
            this.txtReqAddressLine1.TabIndex = 4;
            this.txtReqAddressLine1.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblReqAddressLine1
            // 
            this._lblReqAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReqAddressLine1.Location = new System.Drawing.Point(29, 126);
            this._lblReqAddressLine1.Name = "_lblReqAddressLine1";
            this._lblReqAddressLine1.Size = new System.Drawing.Size(87, 23);
            this._lblReqAddressLine1.TabIndex = 33;
            this._lblReqAddressLine1.Text = "Address";
            this._lblReqAddressLine1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReqName
            // 
            this.txtReqName.Location = new System.Drawing.Point(128, 95);
            this.txtReqName.MaxLength = 40;
            this.txtReqName.Name = "txtReqName";
            this.txtReqName.Size = new System.Drawing.Size(291, 21);
            this.txtReqName.TabIndex = 3;
            this.txtReqName.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblReqName
            // 
            this._lblReqName.Location = new System.Drawing.Point(29, 96);
            this._lblReqName.Name = "_lblReqName";
            this._lblReqName.Size = new System.Drawing.Size(87, 23);
            this._lblReqName.TabIndex = 32;
            this._lblReqName.Text = "Name";
            this._lblReqName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReqAddressLine2
            // 
            this.txtReqAddressLine2.Location = new System.Drawing.Point(128, 156);
            this.txtReqAddressLine2.MaxLength = 40;
            this.txtReqAddressLine2.Name = "txtReqAddressLine2";
            this.txtReqAddressLine2.Size = new System.Drawing.Size(291, 21);
            this.txtReqAddressLine2.TabIndex = 5;
            this.txtReqAddressLine2.TextChanged += new System.EventHandler(this.OnValidateForm);
            // 
            // _lblReqAddressLine2
            // 
            this._lblReqAddressLine2.Location = new System.Drawing.Point(29, 156);
            this._lblReqAddressLine2.Name = "_lblReqAddressLine2";
            this._lblReqAddressLine2.Size = new System.Drawing.Size(87, 23);
            this._lblReqAddressLine2.TabIndex = 37;
            this._lblReqAddressLine2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbRequest
            // 
            this.gbRequest.Controls.Add(this.txtReqZip4);
            this.gbRequest.Controls.Add(this.label1);
            this.gbRequest.Controls.Add(this.grdAddresses);
            this.gbRequest.Controls.Add(this._lblRequestType);
            this.gbRequest.Controls.Add(this.cboRequestType);
            this.gbRequest.Controls.Add(this.txtReqName);
            this.gbRequest.Controls.Add(this.txtReqAddressLine2);
            this.gbRequest.Controls.Add(this.txtReqZip5);
            this.gbRequest.Controls.Add(this._lblReqAddressLine2);
            this.gbRequest.Controls.Add(this._lblReqZip);
            this.gbRequest.Controls.Add(this.txtReqState);
            this.gbRequest.Controls.Add(this._lblReqName);
            this.gbRequest.Controls.Add(this._lblReqState);
            this.gbRequest.Controls.Add(this._lblReqAddressLine1);
            this.gbRequest.Controls.Add(this.txtReqCity);
            this.gbRequest.Controls.Add(this.txtReqAddressLine1);
            this.gbRequest.Controls.Add(this._lblReqCity);
            this.gbRequest.Location = new System.Drawing.Point(14, 14);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(467, 404);
            this.gbRequest.TabIndex = 1;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Request";
            // 
            // txtReqZip4
            // 
            this.txtReqZip4.Location = new System.Drawing.Point(350, 217);
            this.txtReqZip4.MaxLength = 4;
            this.txtReqZip4.Name = "txtReqZip4";
            this.txtReqZip4.Size = new System.Drawing.Size(40, 21);
            this.txtReqZip4.TabIndex = 43;
            this.txtReqZip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(332, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdAddresses
            // 
            this.grdAddresses.AllowUserToAddRows = false;
            this.grdAddresses.AllowUserToDeleteRows = false;
            this.grdAddresses.AutoGenerateColumns = false;
            this.grdAddresses.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdAddresses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAddressLine1,
            this.colAddressLine2,
            this.colCity,
            this.colState,
            this.colZip,
            this.colZip4});
            this.grdAddresses.DataMember = "AddressTable";
            this.grdAddresses.DataSource = this.mAddresses;
            this.grdAddresses.Location = new System.Drawing.Point(14, 270);
            this.grdAddresses.Name = "grdAddresses";
            this.grdAddresses.ReadOnly = true;
            this.grdAddresses.Size = new System.Drawing.Size(436, 118);
            this.grdAddresses.TabIndex = 40;
            this.grdAddresses.SelectionChanged += new System.EventHandler(this.OnAddressSelected);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Visible = false;
            // 
            // colAddressLine1
            // 
            this.colAddressLine1.DataPropertyName = "AddressLine1";
            this.colAddressLine1.HeaderText = "AddressLine1";
            this.colAddressLine1.Name = "colAddressLine1";
            this.colAddressLine1.ReadOnly = true;
            // 
            // colAddressLine2
            // 
            this.colAddressLine2.DataPropertyName = "AddressLine2";
            this.colAddressLine2.HeaderText = "AddressLine2";
            this.colAddressLine2.Name = "colAddressLine2";
            this.colAddressLine2.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "State";
            this.colState.HeaderText = "State";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            this.colState.Width = 50;
            // 
            // colZip
            // 
            this.colZip.DataPropertyName = "Zip";
            this.colZip.HeaderText = "Zip";
            this.colZip.Name = "colZip";
            this.colZip.ReadOnly = true;
            this.colZip.Width = 75;
            // 
            // colZip4
            // 
            this.colZip4.DataPropertyName = "Zip4";
            this.colZip4.HeaderText = "Zip4";
            this.colZip4.Name = "colZip4";
            this.colZip4.ReadOnly = true;
            this.colZip4.Visible = false;
            this.colZip4.Width = 50;
            // 
            // mAddresses
            // 
            this.mAddresses.DataSetName = "AddressDataSet";
            this.mAddresses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _lblRequestType
            // 
            this._lblRequestType.Location = new System.Drawing.Point(29, 35);
            this._lblRequestType.Name = "_lblRequestType";
            this._lblRequestType.Size = new System.Drawing.Size(87, 23);
            this._lblRequestType.TabIndex = 39;
            this._lblRequestType.Text = "Request Type";
            this._lblRequestType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRequestType
            // 
            this.cboRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestType.FormattingEnabled = true;
            this.cboRequestType.Items.AddRange(new object[] {
            "Verify Address",
            "Lookup City/State",
            "Lookup Zip"});
            this.cboRequestType.Location = new System.Drawing.Point(128, 33);
            this.cboRequestType.Name = "cboRequestType";
            this.cboRequestType.Size = new System.Drawing.Size(174, 23);
            this.cboRequestType.TabIndex = 38;
            this.cboRequestType.SelectionChangeCommitted += new System.EventHandler(this.OnRequestTypeChanged);
            // 
            // gbResponse
            // 
            this.gbResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResponse.Controls.Add(this.label2);
            this.gbResponse.Controls.Add(this.txtResZip4);
            this.gbResponse.Controls.Add(this.txtReturnText);
            this.gbResponse.Controls.Add(this._lblReturnText);
            this.gbResponse.Controls.Add(this.txtResName);
            this.gbResponse.Controls.Add(this.txtResAddressLine2);
            this.gbResponse.Controls.Add(this.txtResZip5);
            this.gbResponse.Controls.Add(this._lblResAddressLine2);
            this.gbResponse.Controls.Add(this.gbError);
            this.gbResponse.Controls.Add(this._lblResZip);
            this.gbResponse.Controls.Add(this.txtResState);
            this.gbResponse.Controls.Add(this._lblResName);
            this.gbResponse.Controls.Add(this._lblResState);
            this.gbResponse.Controls.Add(this._lblResAddressLine1);
            this.gbResponse.Controls.Add(this.txtResCity);
            this.gbResponse.Controls.Add(this.txtResAddressLine1);
            this.gbResponse.Controls.Add(this._lblResCity);
            this.gbResponse.Location = new System.Drawing.Point(499, 14);
            this.gbResponse.Name = "gbResponse";
            this.gbResponse.Size = new System.Drawing.Size(467, 462);
            this.gbResponse.TabIndex = 5;
            this.gbResponse.TabStop = false;
            this.gbResponse.Text = "Response";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(332, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResZip4
            // 
            this.txtResZip4.Location = new System.Drawing.Point(350, 217);
            this.txtResZip4.MaxLength = 4;
            this.txtResZip4.Name = "txtResZip4";
            this.txtResZip4.ReadOnly = true;
            this.txtResZip4.Size = new System.Drawing.Size(40, 21);
            this.txtResZip4.TabIndex = 40;
            this.txtResZip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReturnText
            // 
            this.txtReturnText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturnText.Location = new System.Drawing.Point(128, 33);
            this.txtReturnText.Multiline = true;
            this.txtReturnText.Name = "txtReturnText";
            this.txtReturnText.ReadOnly = true;
            this.txtReturnText.Size = new System.Drawing.Size(326, 54);
            this.txtReturnText.TabIndex = 38;
            // 
            // _lblReturnText
            // 
            this._lblReturnText.Location = new System.Drawing.Point(29, 33);
            this._lblReturnText.Name = "_lblReturnText";
            this._lblReturnText.Size = new System.Drawing.Size(87, 23);
            this._lblReturnText.TabIndex = 39;
            this._lblReturnText.Text = "Return Text";
            this._lblReturnText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResName
            // 
            this.txtResName.Location = new System.Drawing.Point(128, 95);
            this.txtResName.MaxLength = 40;
            this.txtResName.Name = "txtResName";
            this.txtResName.ReadOnly = true;
            this.txtResName.Size = new System.Drawing.Size(291, 21);
            this.txtResName.TabIndex = 0;
            // 
            // txtResAddressLine2
            // 
            this.txtResAddressLine2.Location = new System.Drawing.Point(128, 156);
            this.txtResAddressLine2.MaxLength = 40;
            this.txtResAddressLine2.Name = "txtResAddressLine2";
            this.txtResAddressLine2.ReadOnly = true;
            this.txtResAddressLine2.Size = new System.Drawing.Size(291, 21);
            this.txtResAddressLine2.TabIndex = 2;
            // 
            // txtResZip5
            // 
            this.txtResZip5.Location = new System.Drawing.Point(268, 217);
            this.txtResZip5.MaxLength = 5;
            this.txtResZip5.Name = "txtResZip5";
            this.txtResZip5.ReadOnly = true;
            this.txtResZip5.Size = new System.Drawing.Size(58, 21);
            this.txtResZip5.TabIndex = 5;
            this.txtResZip5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _lblResAddressLine2
            // 
            this._lblResAddressLine2.Location = new System.Drawing.Point(29, 156);
            this._lblResAddressLine2.Name = "_lblResAddressLine2";
            this._lblResAddressLine2.Size = new System.Drawing.Size(87, 23);
            this._lblResAddressLine2.TabIndex = 37;
            this._lblResAddressLine2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbError
            // 
            this.gbError.Controls.Add(this.txtErrNumber);
            this.gbError.Controls.Add(this.txtErrDescription);
            this.gbError.Controls.Add(this._lblErrDescription);
            this.gbError.Controls.Add(this.txtErrHelpContext);
            this.gbError.Controls.Add(this._lblErrNumber);
            this.gbError.Controls.Add(this._lblErrSource);
            this.gbError.Controls.Add(this.txtErrHelpFile);
            this.gbError.Controls.Add(this.txtErrSource);
            this.gbError.Controls.Add(this._lblErrHelp);
            this.gbError.Location = new System.Drawing.Point(12, 270);
            this.gbError.Name = "gbError";
            this.gbError.Size = new System.Drawing.Size(443, 180);
            this.gbError.TabIndex = 6;
            this.gbError.TabStop = false;
            this.gbError.Text = "Error";
            // 
            // txtErrNumber
            // 
            this.txtErrNumber.Location = new System.Drawing.Point(117, 33);
            this.txtErrNumber.Name = "txtErrNumber";
            this.txtErrNumber.ReadOnly = true;
            this.txtErrNumber.Size = new System.Drawing.Size(174, 21);
            this.txtErrNumber.TabIndex = 0;
            // 
            // txtErrDescription
            // 
            this.txtErrDescription.Location = new System.Drawing.Point(117, 95);
            this.txtErrDescription.Name = "txtErrDescription";
            this.txtErrDescription.ReadOnly = true;
            this.txtErrDescription.Size = new System.Drawing.Size(300, 21);
            this.txtErrDescription.TabIndex = 2;
            // 
            // _lblErrDescription
            // 
            this._lblErrDescription.Location = new System.Drawing.Point(17, 95);
            this._lblErrDescription.Name = "_lblErrDescription";
            this._lblErrDescription.Size = new System.Drawing.Size(87, 23);
            this._lblErrDescription.TabIndex = 37;
            this._lblErrDescription.Text = "Description";
            this._lblErrDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtErrHelpContext
            // 
            this.txtErrHelpContext.Location = new System.Drawing.Point(267, 125);
            this.txtErrHelpContext.Name = "txtErrHelpContext";
            this.txtErrHelpContext.ReadOnly = true;
            this.txtErrHelpContext.Size = new System.Drawing.Size(150, 21);
            this.txtErrHelpContext.TabIndex = 4;
            // 
            // _lblErrNumber
            // 
            this._lblErrNumber.Location = new System.Drawing.Point(17, 35);
            this._lblErrNumber.Name = "_lblErrNumber";
            this._lblErrNumber.Size = new System.Drawing.Size(87, 23);
            this._lblErrNumber.TabIndex = 32;
            this._lblErrNumber.Text = "Number";
            this._lblErrNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblErrSource
            // 
            this._lblErrSource.Location = new System.Drawing.Point(17, 65);
            this._lblErrSource.Name = "_lblErrSource";
            this._lblErrSource.Size = new System.Drawing.Size(87, 23);
            this._lblErrSource.TabIndex = 33;
            this._lblErrSource.Text = "Source";
            this._lblErrSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtErrHelpFile
            // 
            this.txtErrHelpFile.Location = new System.Drawing.Point(117, 125);
            this.txtErrHelpFile.Name = "txtErrHelpFile";
            this.txtErrHelpFile.ReadOnly = true;
            this.txtErrHelpFile.Size = new System.Drawing.Size(150, 21);
            this.txtErrHelpFile.TabIndex = 3;
            // 
            // txtErrSource
            // 
            this.txtErrSource.Location = new System.Drawing.Point(117, 65);
            this.txtErrSource.Name = "txtErrSource";
            this.txtErrSource.ReadOnly = true;
            this.txtErrSource.Size = new System.Drawing.Size(231, 21);
            this.txtErrSource.TabIndex = 1;
            // 
            // _lblErrHelp
            // 
            this._lblErrHelp.Location = new System.Drawing.Point(17, 125);
            this._lblErrHelp.Name = "_lblErrHelp";
            this._lblErrHelp.Size = new System.Drawing.Size(87, 23);
            this._lblErrHelp.TabIndex = 34;
            this._lblErrHelp.Text = "Help";
            this._lblErrHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblResZip
            // 
            this._lblResZip.Location = new System.Drawing.Point(227, 216);
            this._lblResZip.Name = "_lblResZip";
            this._lblResZip.Size = new System.Drawing.Size(29, 23);
            this._lblResZip.TabIndex = 27;
            this._lblResZip.Text = "Zip";
            this._lblResZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResState
            // 
            this.txtResState.Location = new System.Drawing.Point(128, 216);
            this.txtResState.MaxLength = 2;
            this.txtResState.Name = "txtResState";
            this.txtResState.ReadOnly = true;
            this.txtResState.Size = new System.Drawing.Size(58, 21);
            this.txtResState.TabIndex = 4;
            // 
            // _lblResName
            // 
            this._lblResName.Location = new System.Drawing.Point(29, 96);
            this._lblResName.Name = "_lblResName";
            this._lblResName.Size = new System.Drawing.Size(87, 23);
            this._lblResName.TabIndex = 32;
            this._lblResName.Text = "Name";
            this._lblResName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblResState
            // 
            this._lblResState.Location = new System.Drawing.Point(29, 216);
            this._lblResState.Name = "_lblResState";
            this._lblResState.Size = new System.Drawing.Size(87, 23);
            this._lblResState.TabIndex = 35;
            this._lblResState.Text = "State";
            this._lblResState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblResAddressLine1
            // 
            this._lblResAddressLine1.Location = new System.Drawing.Point(29, 126);
            this._lblResAddressLine1.Name = "_lblResAddressLine1";
            this._lblResAddressLine1.Size = new System.Drawing.Size(87, 23);
            this._lblResAddressLine1.TabIndex = 33;
            this._lblResAddressLine1.Text = "Address";
            this._lblResAddressLine1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResCity
            // 
            this.txtResCity.Location = new System.Drawing.Point(128, 186);
            this.txtResCity.MaxLength = 40;
            this.txtResCity.Name = "txtResCity";
            this.txtResCity.ReadOnly = true;
            this.txtResCity.Size = new System.Drawing.Size(262, 21);
            this.txtResCity.TabIndex = 3;
            // 
            // txtResAddressLine1
            // 
            this.txtResAddressLine1.Location = new System.Drawing.Point(128, 126);
            this.txtResAddressLine1.MaxLength = 40;
            this.txtResAddressLine1.Name = "txtResAddressLine1";
            this.txtResAddressLine1.ReadOnly = true;
            this.txtResAddressLine1.Size = new System.Drawing.Size(291, 21);
            this.txtResAddressLine1.TabIndex = 1;
            // 
            // _lblResCity
            // 
            this._lblResCity.Location = new System.Drawing.Point(29, 186);
            this._lblResCity.Name = "_lblResCity";
            this._lblResCity.Size = new System.Drawing.Size(87, 23);
            this._lblResCity.TabIndex = 34;
            this._lblResCity.Text = "City";
            this._lblResCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLookupZip
            // 
            this.btnLookupZip.Location = new System.Drawing.Point(316, 437);
            this.btnLookupZip.Name = "btnLookupZip";
            this.btnLookupZip.Size = new System.Drawing.Size(117, 27);
            this.btnLookupZip.TabIndex = 4;
            this.btnLookupZip.Text = "Lookup Zip";
            this.btnLookupZip.UseVisualStyleBackColor = true;
            this.btnLookupZip.Click += new System.EventHandler(this.OnCommandClick);
            // 
            // btnLookupCityState
            // 
            this.btnLookupCityState.Location = new System.Drawing.Point(186, 437);
            this.btnLookupCityState.Name = "btnLookupCityState";
            this.btnLookupCityState.Size = new System.Drawing.Size(122, 27);
            this.btnLookupCityState.TabIndex = 3;
            this.btnLookupCityState.Text = "Lookup City/State";
            this.btnLookupCityState.UseVisualStyleBackColor = true;
            this.btnLookupCityState.Click += new System.EventHandler(this.OnCommandClick);
            // 
            // winTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.btnLookupCityState);
            this.Controls.Add(this.btnLookupZip);
            this.Controls.Add(this.gbResponse);
            this.Controls.Add(this.gbRequest);
            this.Controls.Add(this.btnVerifyAddress);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "winTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USPS Address Verification";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.gbRequest.ResumeLayout(false);
            this.gbRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAddresses)).EndInit();
            this.gbResponse.ResumeLayout(false);
            this.gbResponse.PerformLayout();
            this.gbError.ResumeLayout(false);
            this.gbError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblReqZip;
        private System.Windows.Forms.TextBox txtReqZip5;
        private System.Windows.Forms.Button btnVerifyAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtReqState;
        private System.Windows.Forms.Label _lblReqState;
        private System.Windows.Forms.TextBox txtReqCity;
        private System.Windows.Forms.Label _lblReqCity;
        private System.Windows.Forms.TextBox txtReqAddressLine1;
        private System.Windows.Forms.Label _lblReqAddressLine1;
        private System.Windows.Forms.TextBox txtReqName;
        private System.Windows.Forms.Label _lblReqName;
        private System.Windows.Forms.TextBox txtReqAddressLine2;
        private System.Windows.Forms.Label _lblReqAddressLine2;
        private System.Windows.Forms.GroupBox gbRequest;
        private System.Windows.Forms.GroupBox gbResponse;
        private System.Windows.Forms.TextBox txtResName;
        private System.Windows.Forms.TextBox txtResAddressLine2;
        private System.Windows.Forms.TextBox txtResZip5;
        private System.Windows.Forms.Label _lblResAddressLine2;
        private System.Windows.Forms.Label _lblResZip;
        private System.Windows.Forms.TextBox txtResState;
        private System.Windows.Forms.Label _lblResName;
        private System.Windows.Forms.Label _lblResState;
        private System.Windows.Forms.Label _lblResAddressLine1;
        private System.Windows.Forms.TextBox txtResCity;
        private System.Windows.Forms.TextBox txtResAddressLine1;
        private System.Windows.Forms.Label _lblResCity;
        private System.Windows.Forms.GroupBox gbError;
        private System.Windows.Forms.TextBox txtErrNumber;
        private System.Windows.Forms.TextBox txtErrDescription;
        private System.Windows.Forms.Label _lblErrDescription;
        private System.Windows.Forms.TextBox txtErrHelpContext;
        private System.Windows.Forms.Label _lblErrNumber;
        private System.Windows.Forms.Label _lblErrSource;
        private System.Windows.Forms.TextBox txtErrHelpFile;
        private System.Windows.Forms.TextBox txtErrSource;
        private System.Windows.Forms.Label _lblErrHelp;
        private System.Windows.Forms.Button btnLookupZip;
        private System.Windows.Forms.Button btnLookupCityState;
        private System.Windows.Forms.TextBox txtReturnText;
        private System.Windows.Forms.Label _lblReturnText;
        private System.Windows.Forms.ComboBox cboRequestType;
        private System.Windows.Forms.Label _lblRequestType;
        private System.Windows.Forms.DataGridView grdAddresses;
        private VS13.Data.AddressDataset mAddresses;
        private System.Windows.Forms.TextBox txtReqZip4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResZip4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZip4;
    }
}


﻿namespace NetMailSample
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtBoxDomain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.mskPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserSmtp = new System.Windows.Forms.Label();
            this.grpMailMessage = new System.Windows.Forms.GroupBox();
            this.richTxtBody = new System.Windows.Forms.RichTextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.txtBoxBCC = new System.Windows.Forms.TextBox();
            this.txtBoxCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSmtpSettings = new System.Windows.Forms.GroupBox();
            this.chkPasswordRequired = new System.Windows.Forms.CheckBox();
            this.txtPickupFolder = new System.Windows.Forms.TextBox();
            this.chkBoxSpecificPickupFolder = new System.Windows.Forms.CheckBox();
            this.rdoSendByPickupFolder = new System.Windows.Forms.RadioButton();
            this.rdoSendByPort = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnableSSL = new System.Windows.Forms.CheckBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxErrorLog = new System.Windows.Forms.TextBox();
            this.btnOpenLogFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgGridAttachments = new System.Windows.Forms.DataGridView();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContentType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripAttachments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editContentIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colInline = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnInsertAttachment = new System.Windows.Forms.Button();
            this.btnDeleteAttachment = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgGridHeaders = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripHeaders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.btnAddHeaders = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkTimeBasedSend = new System.Windows.Forms.CheckBox();
            this.btnStopSendLoop = new System.Windows.Forms.Button();
            this.btnStartSendLoop = new System.Windows.Forms.Button();
            this.numUpDnSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblNumSeconds = new System.Windows.Forms.Label();
            this.btnAltView = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoadSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMailMessage.SuspendLayout();
            this.grpSmtpSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridAttachments)).BeginInit();
            this.contextMenuStripAttachments.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridHeaders)).BeginInit();
            this.contextMenuStripHeaders.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSeconds)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(873, 545);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(88, 23);
            this.btnSendEmail.TabIndex = 20;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtBoxDomain
            // 
            this.txtBoxDomain.Location = new System.Drawing.Point(67, 76);
            this.txtBoxDomain.Name = "txtBoxDomain";
            this.txtBoxDomain.Size = new System.Drawing.Size(178, 20);
            this.txtBoxDomain.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Domain:";
            // 
            // txtBoxEmailAddress
            // 
            this.txtBoxEmailAddress.Location = new System.Drawing.Point(67, 18);
            this.txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            this.txtBoxEmailAddress.Size = new System.Drawing.Size(178, 20);
            this.txtBoxEmailAddress.TabIndex = 1;
            // 
            // mskPassword
            // 
            this.mskPassword.Location = new System.Drawing.Point(67, 48);
            this.mskPassword.Name = "mskPassword";
            this.mskPassword.Size = new System.Drawing.Size(178, 20);
            this.mskPassword.TabIndex = 2;
            this.mskPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 51);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserSmtp
            // 
            this.lblUserSmtp.AutoSize = true;
            this.lblUserSmtp.Location = new System.Drawing.Point(6, 23);
            this.lblUserSmtp.Name = "lblUserSmtp";
            this.lblUserSmtp.Size = new System.Drawing.Size(35, 13);
            this.lblUserSmtp.TabIndex = 0;
            this.lblUserSmtp.Text = "Email:";
            // 
            // grpMailMessage
            // 
            this.grpMailMessage.Controls.Add(this.richTxtBody);
            this.grpMailMessage.Controls.Add(this.txtBoxSubject);
            this.grpMailMessage.Controls.Add(this.txtBoxBCC);
            this.grpMailMessage.Controls.Add(this.txtBoxCC);
            this.grpMailMessage.Controls.Add(this.label6);
            this.grpMailMessage.Controls.Add(this.label5);
            this.grpMailMessage.Controls.Add(this.label4);
            this.grpMailMessage.Controls.Add(this.txtBoxTo);
            this.grpMailMessage.Controls.Add(this.label3);
            this.grpMailMessage.Location = new System.Drawing.Point(12, 202);
            this.grpMailMessage.Name = "grpMailMessage";
            this.grpMailMessage.Size = new System.Drawing.Size(530, 323);
            this.grpMailMessage.TabIndex = 3;
            this.grpMailMessage.TabStop = false;
            this.grpMailMessage.Text = "Mail Message - separate multiple addresses with comma";
            // 
            // richTxtBody
            // 
            this.richTxtBody.Location = new System.Drawing.Point(6, 133);
            this.richTxtBody.Name = "richTxtBody";
            this.richTxtBody.Size = new System.Drawing.Size(516, 184);
            this.richTxtBody.TabIndex = 16;
            this.richTxtBody.Text = "";
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Location = new System.Drawing.Point(62, 101);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(456, 20);
            this.txtBoxSubject.TabIndex = 15;
            // 
            // txtBoxBCC
            // 
            this.txtBoxBCC.Location = new System.Drawing.Point(62, 74);
            this.txtBoxBCC.Name = "txtBoxBCC";
            this.txtBoxBCC.Size = new System.Drawing.Size(456, 20);
            this.txtBoxBCC.TabIndex = 14;
            // 
            // txtBoxCC
            // 
            this.txtBoxCC.Location = new System.Drawing.Point(62, 48);
            this.txtBoxCC.Name = "txtBoxCC";
            this.txtBoxCC.Size = new System.Drawing.Size(456, 20);
            this.txtBoxCC.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bcc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cc:";
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Location = new System.Drawing.Point(62, 22);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(456, 20);
            this.txtBoxTo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "To:";
            // 
            // grpSmtpSettings
            // 
            this.grpSmtpSettings.Controls.Add(this.chkPasswordRequired);
            this.grpSmtpSettings.Controls.Add(this.txtBoxDomain);
            this.grpSmtpSettings.Controls.Add(this.txtPickupFolder);
            this.grpSmtpSettings.Controls.Add(this.chkBoxSpecificPickupFolder);
            this.grpSmtpSettings.Controls.Add(this.label7);
            this.grpSmtpSettings.Controls.Add(this.rdoSendByPickupFolder);
            this.grpSmtpSettings.Controls.Add(this.rdoSendByPort);
            this.grpSmtpSettings.Controls.Add(this.txtBoxEmailAddress);
            this.grpSmtpSettings.Controls.Add(this.label2);
            this.grpSmtpSettings.Controls.Add(this.chkEnableSSL);
            this.grpSmtpSettings.Controls.Add(this.mskPassword);
            this.grpSmtpSettings.Controls.Add(this.cmbPort);
            this.grpSmtpSettings.Controls.Add(this.cmbServer);
            this.grpSmtpSettings.Controls.Add(this.lblPassword);
            this.grpSmtpSettings.Controls.Add(this.label1);
            this.grpSmtpSettings.Controls.Add(this.lblUserSmtp);
            this.grpSmtpSettings.Location = new System.Drawing.Point(12, 27);
            this.grpSmtpSettings.Name = "grpSmtpSettings";
            this.grpSmtpSettings.Size = new System.Drawing.Size(530, 169);
            this.grpSmtpSettings.TabIndex = 4;
            this.grpSmtpSettings.TabStop = false;
            this.grpSmtpSettings.Text = "SMTP Settings";
            // 
            // chkPasswordRequired
            // 
            this.chkPasswordRequired.AutoSize = true;
            this.chkPasswordRequired.Checked = true;
            this.chkPasswordRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPasswordRequired.Location = new System.Drawing.Point(11, 117);
            this.chkPasswordRequired.Name = "chkPasswordRequired";
            this.chkPasswordRequired.Size = new System.Drawing.Size(118, 17);
            this.chkPasswordRequired.TabIndex = 10;
            this.chkPasswordRequired.Text = "Password Required";
            this.chkPasswordRequired.UseVisualStyleBackColor = true;
            // 
            // txtPickupFolder
            // 
            this.txtPickupFolder.Enabled = false;
            this.txtPickupFolder.Location = new System.Drawing.Point(302, 138);
            this.txtPickupFolder.Name = "txtPickupFolder";
            this.txtPickupFolder.Size = new System.Drawing.Size(216, 20);
            this.txtPickupFolder.TabIndex = 9;
            // 
            // chkBoxSpecificPickupFolder
            // 
            this.chkBoxSpecificPickupFolder.AutoSize = true;
            this.chkBoxSpecificPickupFolder.Enabled = false;
            this.chkBoxSpecificPickupFolder.Location = new System.Drawing.Point(286, 117);
            this.chkBoxSpecificPickupFolder.Name = "chkBoxSpecificPickupFolder";
            this.chkBoxSpecificPickupFolder.Size = new System.Drawing.Size(174, 17);
            this.chkBoxSpecificPickupFolder.TabIndex = 8;
            this.chkBoxSpecificPickupFolder.Text = "Specify a custom pickup folder:";
            this.chkBoxSpecificPickupFolder.UseVisualStyleBackColor = true;
            this.chkBoxSpecificPickupFolder.CheckedChanged += new System.EventHandler(this.chkBoxSpecificPickupFolder_CheckedChanged);
            // 
            // rdoSendByPickupFolder
            // 
            this.rdoSendByPickupFolder.AutoSize = true;
            this.rdoSendByPickupFolder.Location = new System.Drawing.Point(263, 94);
            this.rdoSendByPickupFolder.Name = "rdoSendByPickupFolder";
            this.rdoSendByPickupFolder.Size = new System.Drawing.Size(136, 17);
            this.rdoSendByPickupFolder.TabIndex = 7;
            this.rdoSendByPickupFolder.Text = "Send By Pickup Folder:";
            this.rdoSendByPickupFolder.UseVisualStyleBackColor = true;
            this.rdoSendByPickupFolder.CheckedChanged += new System.EventHandler(this.rdoSendByPickupFolder_CheckedChanged);
            // 
            // rdoSendByPort
            // 
            this.rdoSendByPort.AutoSize = true;
            this.rdoSendByPort.Checked = true;
            this.rdoSendByPort.Location = new System.Drawing.Point(263, 19);
            this.rdoSendByPort.Name = "rdoSendByPort";
            this.rdoSendByPort.Size = new System.Drawing.Size(90, 17);
            this.rdoSendByPort.TabIndex = 4;
            this.rdoSendByPort.TabStop = true;
            this.rdoSendByPort.Text = "Send By Port:";
            this.rdoSendByPort.UseVisualStyleBackColor = true;
            this.rdoSendByPort.CheckedChanged += new System.EventHandler(this.rdoSendByPort_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Checked = true;
            this.chkEnableSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSSL.Location = new System.Drawing.Point(11, 138);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(82, 17);
            this.chkEnableSSL.TabIndex = 11;
            this.chkEnableSSL.Text = "Enable SSL";
            this.chkEnableSSL.UseVisualStyleBackColor = true;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "25",
            "465",
            "587",
            "995"});
            this.cmbPort.Location = new System.Drawing.Point(327, 64);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(55, 21);
            this.cmbPort.TabIndex = 6;
            this.cmbPort.Text = "587";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "smtp-mail.outlook.com ",
            "smtp.office365.com",
            "smtp.gmail.com",
            "smtp.zoho.com",
            "smtp.mail.yahoo.com"});
            this.cmbServer.Location = new System.Drawing.Point(327, 37);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(191, 21);
            this.cmbServer.TabIndex = 5;
            this.cmbServer.Text = "smtp.office365.com";
            this.cmbServer.SelectedIndexChanged += new System.EventHandler(this.cboServer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxErrorLog);
            this.groupBox1.Location = new System.Drawing.Point(548, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operational Result Logs";
            // 
            // txtBoxErrorLog
            // 
            this.txtBoxErrorLog.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxErrorLog.Location = new System.Drawing.Point(7, 20);
            this.txtBoxErrorLog.Multiline = true;
            this.txtBoxErrorLog.Name = "txtBoxErrorLog";
            this.txtBoxErrorLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxErrorLog.Size = new System.Drawing.Size(398, 143);
            this.txtBoxErrorLog.TabIndex = 0;
            // 
            // btnOpenLogFile
            // 
            this.btnOpenLogFile.Location = new System.Drawing.Point(637, 546);
            this.btnOpenLogFile.Name = "btnOpenLogFile";
            this.btnOpenLogFile.Size = new System.Drawing.Size(105, 23);
            this.btnOpenLogFile.TabIndex = 1;
            this.btnOpenLogFile.Tag = "";
            this.btnOpenLogFile.Text = "Open Error Log";
            this.btnOpenLogFile.UseVisualStyleBackColor = true;
            this.btnOpenLogFile.Click += new System.EventHandler(this.btnOpenLogFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgGridAttachments);
            this.groupBox3.Controls.Add(this.btnInsertAttachment);
            this.groupBox3.Controls.Add(this.btnDeleteAttachment);
            this.groupBox3.Location = new System.Drawing.Point(548, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 180);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message Attachments";
            // 
            // dgGridAttachments
            // 
            this.dgGridAttachments.AllowUserToAddRows = false;
            this.dgGridAttachments.AllowUserToDeleteRows = false;
            this.dgGridAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilePath,
            this.colContentType,
            this.colFileSize,
            this.colContentId,
            this.colInline});
            this.dgGridAttachments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgGridAttachments.Location = new System.Drawing.Point(7, 19);
            this.dgGridAttachments.MultiSelect = false;
            this.dgGridAttachments.Name = "dgGridAttachments";
            this.dgGridAttachments.Size = new System.Drawing.Size(349, 155);
            this.dgGridAttachments.TabIndex = 25;
            this.dgGridAttachments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAttachments_CellClick);
            this.dgGridAttachments.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridAttachments_CellMouseDown);
            // 
            // colFilePath
            // 
            this.colFilePath.HeaderText = "File Path";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            // 
            // colContentType
            // 
            this.colContentType.AutoComplete = false;
            this.colContentType.HeaderText = "Content Type";
            this.colContentType.Items.AddRange(new object[] {
            "Octet",
            "Pdf",
            "Rtf",
            "Soap",
            "Zip",
            "Gif",
            "Jpeg",
            "Tiff",
            "Html",
            "Plain",
            "RichText",
            "Xml"});
            this.colContentType.Name = "colContentType";
            this.colContentType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colContentType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFileSize
            // 
            this.colFileSize.HeaderText = "Size";
            this.colFileSize.Name = "colFileSize";
            // 
            // colContentId
            // 
            this.colContentId.ContextMenuStrip = this.contextMenuStripAttachments;
            this.colContentId.HeaderText = "Content Id";
            this.colContentId.Name = "colContentId";
            // 
            // contextMenuStripAttachments
            // 
            this.contextMenuStripAttachments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editContentIDToolStripMenuItem,
            this.editInlineToolStripMenuItem});
            this.contextMenuStripAttachments.Name = "contextMenuStripAttachments";
            this.contextMenuStripAttachments.Size = new System.Drawing.Size(155, 48);
            // 
            // editContentIDToolStripMenuItem
            // 
            this.editContentIDToolStripMenuItem.Name = "editContentIDToolStripMenuItem";
            this.editContentIDToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editContentIDToolStripMenuItem.Text = "Edit Content ID";
            this.editContentIDToolStripMenuItem.Click += new System.EventHandler(this.editContentIDToolStripMenuItem_Click);
            // 
            // editInlineToolStripMenuItem
            // 
            this.editInlineToolStripMenuItem.Name = "editInlineToolStripMenuItem";
            this.editInlineToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editInlineToolStripMenuItem.Text = "Edit Inline";
            this.editInlineToolStripMenuItem.Click += new System.EventHandler(this.editInlineToolStripMenuItem_Click);
            // 
            // colInline
            // 
            this.colInline.ContextMenuStrip = this.contextMenuStripAttachments;
            this.colInline.HeaderText = "Inline";
            this.colInline.Items.AddRange(new object[] {
            "True",
            "False"});
            this.colInline.Name = "colInline";
            this.colInline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnInsertAttachment
            // 
            this.btnInsertAttachment.Image = global::NetMailSample.Properties.Resources.AddMark_10580;
            this.btnInsertAttachment.Location = new System.Drawing.Point(362, 19);
            this.btnInsertAttachment.Name = "btnInsertAttachment";
            this.btnInsertAttachment.Size = new System.Drawing.Size(43, 23);
            this.btnInsertAttachment.TabIndex = 23;
            this.btnInsertAttachment.UseVisualStyleBackColor = true;
            this.btnInsertAttachment.Click += new System.EventHandler(this.btnInsertAttachment_Click);
            // 
            // btnDeleteAttachment
            // 
            this.btnDeleteAttachment.Image = global::NetMailSample.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteAttachment.Location = new System.Drawing.Point(362, 48);
            this.btnDeleteAttachment.Name = "btnDeleteAttachment";
            this.btnDeleteAttachment.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteAttachment.TabIndex = 24;
            this.btnDeleteAttachment.UseVisualStyleBackColor = true;
            this.btnDeleteAttachment.Click += new System.EventHandler(this.btnDeleteAttachment_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Select attachment to insert";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgGridHeaders);
            this.groupBox2.Controls.Add(this.btnDeleteHeader);
            this.groupBox2.Controls.Add(this.btnAddHeaders);
            this.groupBox2.Location = new System.Drawing.Point(548, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 137);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Headers";
            // 
            // dgGridHeaders
            // 
            this.dgGridHeaders.AllowUserToAddRows = false;
            this.dgGridHeaders.AllowUserToDeleteRows = false;
            this.dgGridHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue});
            this.dgGridHeaders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgGridHeaders.Location = new System.Drawing.Point(7, 16);
            this.dgGridHeaders.MultiSelect = false;
            this.dgGridHeaders.Name = "dgGridHeaders";
            this.dgGridHeaders.Size = new System.Drawing.Size(349, 115);
            this.dgGridHeaders.TabIndex = 20;
            this.dgGridHeaders.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridHeaders_CellMouseDown);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colName.ContextMenuStrip = this.contextMenuStripHeaders;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 60;
            // 
            // contextMenuStripHeaders
            // 
            this.contextMenuStripHeaders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNameToolStripMenuItem,
            this.editValueToolStripMenuItem});
            this.contextMenuStripHeaders.Name = "contextMenuStripHeaders";
            this.contextMenuStripHeaders.Size = new System.Drawing.Size(130, 48);
            // 
            // editNameToolStripMenuItem
            // 
            this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
            this.editNameToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editNameToolStripMenuItem.Text = "Edit Name";
            this.editNameToolStripMenuItem.Click += new System.EventHandler(this.editNameToolStripMenuItem_Click);
            // 
            // editValueToolStripMenuItem
            // 
            this.editValueToolStripMenuItem.Name = "editValueToolStripMenuItem";
            this.editValueToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editValueToolStripMenuItem.Text = "Edit Value";
            this.editValueToolStripMenuItem.Click += new System.EventHandler(this.editValueToolStripMenuItem_Click);
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colValue.ContextMenuStrip = this.contextMenuStripHeaders;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Width = 59;
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.Image = global::NetMailSample.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteHeader.Location = new System.Drawing.Point(362, 44);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteHeader.TabIndex = 22;
            this.btnDeleteHeader.UseVisualStyleBackColor = true;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // btnAddHeaders
            // 
            this.btnAddHeaders.Image = global::NetMailSample.Properties.Resources.AddMark_10580;
            this.btnAddHeaders.Location = new System.Drawing.Point(362, 15);
            this.btnAddHeaders.Name = "btnAddHeaders";
            this.btnAddHeaders.Size = new System.Drawing.Size(43, 23);
            this.btnAddHeaders.TabIndex = 21;
            this.btnAddHeaders.UseVisualStyleBackColor = true;
            this.btnAddHeaders.Click += new System.EventHandler(this.btnAddHeaders_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkTimeBasedSend);
            this.groupBox4.Controls.Add(this.btnStopSendLoop);
            this.groupBox4.Controls.Add(this.btnStartSendLoop);
            this.groupBox4.Controls.Add(this.numUpDnSeconds);
            this.groupBox4.Controls.Add(this.lblNumSeconds);
            this.groupBox4.Location = new System.Drawing.Point(12, 532);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 43);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sending Loop";
            // 
            // chkTimeBasedSend
            // 
            this.chkTimeBasedSend.AutoSize = true;
            this.chkTimeBasedSend.Location = new System.Drawing.Point(11, 17);
            this.chkTimeBasedSend.Name = "chkTimeBasedSend";
            this.chkTimeBasedSend.Size = new System.Drawing.Size(152, 17);
            this.chkTimeBasedSend.TabIndex = 29;
            this.chkTimeBasedSend.Text = "Enable Time Based Send :";
            this.chkTimeBasedSend.UseVisualStyleBackColor = true;
            this.chkTimeBasedSend.CheckStateChanged += new System.EventHandler(this.chkTimeBasedSend_CheckStateChanged);
            // 
            // btnStopSendLoop
            // 
            this.btnStopSendLoop.Enabled = false;
            this.btnStopSendLoop.Location = new System.Drawing.Point(490, 14);
            this.btnStopSendLoop.Name = "btnStopSendLoop";
            this.btnStopSendLoop.Size = new System.Drawing.Size(64, 23);
            this.btnStopSendLoop.TabIndex = 27;
            this.btnStopSendLoop.Text = "Stop";
            this.btnStopSendLoop.UseVisualStyleBackColor = true;
            this.btnStopSendLoop.Click += new System.EventHandler(this.btnStopSendLoop_Click);
            // 
            // btnStartSendLoop
            // 
            this.btnStartSendLoop.Enabled = false;
            this.btnStartSendLoop.Location = new System.Drawing.Point(420, 14);
            this.btnStartSendLoop.Name = "btnStartSendLoop";
            this.btnStartSendLoop.Size = new System.Drawing.Size(64, 23);
            this.btnStartSendLoop.TabIndex = 26;
            this.btnStartSendLoop.Text = "Start";
            this.btnStartSendLoop.UseVisualStyleBackColor = true;
            this.btnStartSendLoop.Click += new System.EventHandler(this.btnStartSendLoop_Click);
            // 
            // numUpDnSeconds
            // 
            this.numUpDnSeconds.Enabled = false;
            this.numUpDnSeconds.Location = new System.Drawing.Point(371, 16);
            this.numUpDnSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDnSeconds.Name = "numUpDnSeconds";
            this.numUpDnSeconds.Size = new System.Drawing.Size(43, 20);
            this.numUpDnSeconds.TabIndex = 25;
            this.numUpDnSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNumSeconds
            // 
            this.lblNumSeconds.AutoSize = true;
            this.lblNumSeconds.Enabled = false;
            this.lblNumSeconds.Location = new System.Drawing.Point(159, 18);
            this.lblNumSeconds.Name = "lblNumSeconds";
            this.lblNumSeconds.Size = new System.Drawing.Size(211, 13);
            this.lblNumSeconds.TabIndex = 0;
            this.lblNumSeconds.Text = "Number of seconds to wait between sends:";
            // 
            // btnAltView
            // 
            this.btnAltView.Location = new System.Drawing.Point(748, 545);
            this.btnAltView.Name = "btnAltView";
            this.btnAltView.Size = new System.Drawing.Size(119, 23);
            this.btnAltView.TabIndex = 19;
            this.btnAltView.Text = "Add Alternate Views";
            this.btnAltView.UseVisualStyleBackColor = true;
            this.btnAltView.Click += new System.EventHandler(this.btnAltView_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoadSettings,
            this.mnuFileSaveSettings,
            this.mnuFileOptions});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // mnuFileLoadSettings
            // 
            this.mnuFileLoadSettings.Name = "mnuFileLoadSettings";
            this.mnuFileLoadSettings.Size = new System.Drawing.Size(152, 22);
            this.mnuFileLoadSettings.Text = "&Load Settings";
            this.mnuFileLoadSettings.Click += new System.EventHandler(this.mnuFileLoadSettings_Click);
            // 
            // mnuFileSaveSettings
            // 
            this.mnuFileSaveSettings.Name = "mnuFileSaveSettings";
            this.mnuFileSaveSettings.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveSettings.Text = "&Save Settings";
            this.mnuFileSaveSettings.Click += new System.EventHandler(this.mnuFileSaveSettings_Click);
            // 
            // mnuFileOptions
            // 
            this.mnuFileOptions.Name = "mnuFileOptions";
            this.mnuFileOptions.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOptions.Text = "&Options";
            this.mnuFileOptions.Click += new System.EventHandler(this.mnuFileOptions_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStrip,
            this.feedbackToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "&Help";
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStrip.Text = "&About";
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStrip_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.feedbackToolStripMenuItem.Text = "F&eedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 583);
            this.Controls.Add(this.btnOpenLogFile);
            this.Controls.Add(this.btnAltView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSmtpSettings);
            this.Controls.Add(this.grpMailMessage);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetMail Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpMailMessage.ResumeLayout(false);
            this.grpMailMessage.PerformLayout();
            this.grpSmtpSettings.ResumeLayout(false);
            this.grpSmtpSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridAttachments)).EndInit();
            this.contextMenuStripAttachments.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridHeaders)).EndInit();
            this.contextMenuStripHeaders.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSeconds)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtBoxEmailAddress;
        private System.Windows.Forms.MaskedTextBox mskPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserSmtp;
        private System.Windows.Forms.GroupBox grpMailMessage;
        private System.Windows.Forms.GroupBox grpSmtpSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnableSSL;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTxtBody;
        private System.Windows.Forms.TextBox txtBoxSubject;
        private System.Windows.Forms.TextBox txtBoxBCC;
        private System.Windows.Forms.TextBox txtBoxCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxErrorLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInsertAttachment;
        private System.Windows.Forms.Button btnAddHeaders;
        private System.Windows.Forms.Button btnDeleteAttachment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteHeader;
        private System.Windows.Forms.DataGridView dgGridHeaders;
        private System.Windows.Forms.TextBox txtBoxDomain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPickupFolder;
        private System.Windows.Forms.CheckBox chkBoxSpecificPickupFolder;
        private System.Windows.Forms.RadioButton rdoSendByPickupFolder;
        private System.Windows.Forms.RadioButton rdoSendByPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStopSendLoop;
        private System.Windows.Forms.Button btnStartSendLoop;
        private System.Windows.Forms.NumericUpDown numUpDnSeconds;
        private System.Windows.Forms.Label lblNumSeconds;
        private System.Windows.Forms.Button btnAltView;
        private System.Windows.Forms.CheckBox chkPasswordRequired;
        private System.Windows.Forms.DataGridView dgGridAttachments;
        private System.Windows.Forms.CheckBox chkTimeBasedSend;
        private System.Windows.Forms.Button btnOpenLogFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoadSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHeaders;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editValueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAttachments;
        private System.Windows.Forms.ToolStripMenuItem editContentIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInlineToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
        private System.Windows.Forms.DataGridViewComboBoxColumn colContentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContentId;
        private System.Windows.Forms.DataGridViewComboBoxColumn colInline;
    }
}


﻿namespace lorakon
{
    partial class FormSampleInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSampleInput));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbSTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSampleQuant = new System.Windows.Forms.Panel();
            this.tbSQuantErr = new System.Windows.Forms.TextBox();
            this.tbSQuant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxLocation = new System.Windows.Forms.ComboBox();
            this.tbSLoctn = new System.Windows.Forms.TextBox();
            this.cboxCoordType = new System.Windows.Forms.ComboBox();
            this.panelCoords = new System.Windows.Forms.Panel();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.tbAltitude = new System.Windows.Forms.TextBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.lblCommunity = new System.Windows.Forms.Label();
            this.cboxCommunity = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelReferenceDate = new System.Windows.Forms.Panel();
            this.dtpSTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.panelError = new System.Windows.Forms.Panel();
            this.tbSSysterr = new System.Windows.Forms.TextBox();
            this.tbSSyserr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSampleType = new System.Windows.Forms.Panel();
            this.cboxSampleType = new System.Windows.Forms.ComboBox();
            this.btnBrowseSampleType = new System.Windows.Forms.Button();
            this.panelUnitGeom = new System.Windows.Forms.Panel();
            this.cboxSGeomtry = new System.Windows.Forms.ComboBox();
            this.cboxSUnits = new System.Windows.Forms.ComboBox();
            this.panelCoordLabel = new System.Windows.Forms.Panel();
            this.labelCoordAltitude = new System.Windows.Forms.Label();
            this.labelCoordLongitude = new System.Windows.Forms.Label();
            this.labelCoordLatitude = new System.Windows.Forms.Label();
            this.panelLab = new System.Windows.Forms.Panel();
            this.tbScollName = new System.Windows.Forms.TextBox();
            this.tbLab = new System.Windows.Forms.TextBox();
            this.panelSampleCompID = new System.Windows.Forms.Panel();
            this.tbSIdent = new System.Windows.Forms.TextBox();
            this.cboxComponent = new System.Windows.Forms.ComboBox();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.btnImport = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnImportSampReg = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.panelSampleQuant.SuspendLayout();
            this.panelCoords.SuspendLayout();
            this.panelReferenceDate.SuspendLayout();
            this.panelError.SuspendLayout();
            this.panelSampleType.SuspendLayout();
            this.panelUnitGeom.SuspendLayout();
            this.panelCoordLabel.SuspendLayout();
            this.panelLab.SuspendLayout();
            this.panelSampleCompID.SuspendLayout();
            this.tools.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(543, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnOk.Location = new System.Drawing.Point(667, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 32);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.Controls.Add(this.tbSTitle, 1, 1);
            this.tableLayoutMain.Controls.Add(this.label2, 0, 2);
            this.tableLayoutMain.Controls.Add(this.label1, 0, 1);
            this.tableLayoutMain.Controls.Add(this.label8, 0, 9);
            this.tableLayoutMain.Controls.Add(this.label12, 0, 10);
            this.tableLayoutMain.Controls.Add(this.panelSampleQuant, 1, 9);
            this.tableLayoutMain.Controls.Add(this.label7, 0, 0);
            this.tableLayoutMain.Controls.Add(this.cboxLocation, 0, 7);
            this.tableLayoutMain.Controls.Add(this.tbSLoctn, 1, 7);
            this.tableLayoutMain.Controls.Add(this.cboxCoordType, 0, 6);
            this.tableLayoutMain.Controls.Add(this.panelCoords, 1, 6);
            this.tableLayoutMain.Controls.Add(this.lblCommunity, 0, 4);
            this.tableLayoutMain.Controls.Add(this.cboxCommunity, 1, 4);
            this.tableLayoutMain.Controls.Add(this.label14, 0, 11);
            this.tableLayoutMain.Controls.Add(this.panelReferenceDate, 1, 11);
            this.tableLayoutMain.Controls.Add(this.panelError, 1, 13);
            this.tableLayoutMain.Controls.Add(this.label11, 0, 13);
            this.tableLayoutMain.Controls.Add(this.label9, 0, 14);
            this.tableLayoutMain.Controls.Add(this.tbComment, 1, 14);
            this.tableLayoutMain.Controls.Add(this.label10, 0, 3);
            this.tableLayoutMain.Controls.Add(this.panelSampleType, 1, 2);
            this.tableLayoutMain.Controls.Add(this.panelUnitGeom, 1, 10);
            this.tableLayoutMain.Controls.Add(this.panelCoordLabel, 1, 5);
            this.tableLayoutMain.Controls.Add(this.panelLab, 1, 0);
            this.tableLayoutMain.Controls.Add(this.panelSampleCompID, 1, 3);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 16;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(784, 482);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // tbSTitle
            // 
            this.tbSTitle.BackColor = System.Drawing.SystemColors.Window;
            this.tbSTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSTitle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSTitle.Location = new System.Drawing.Point(243, 35);
            this.tbSTitle.MaxLength = 64;
            this.tbSTitle.Name = "tbSTitle";
            this.tbSTitle.Size = new System.Drawing.Size(538, 23);
            this.tbSTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prosjekt / Oppdrag";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(3, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mengde / Abs. Usikk.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(3, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 32);
            this.label12.TabIndex = 15;
            this.label12.Text = "Mengde enhet / Geom.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSampleQuant
            // 
            this.panelSampleQuant.Controls.Add(this.tbSQuantErr);
            this.panelSampleQuant.Controls.Add(this.tbSQuant);
            this.panelSampleQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSampleQuant.Location = new System.Drawing.Point(243, 279);
            this.panelSampleQuant.Name = "panelSampleQuant";
            this.panelSampleQuant.Size = new System.Drawing.Size(538, 26);
            this.panelSampleQuant.TabIndex = 11;
            this.panelSampleQuant.TabStop = true;
            // 
            // tbSQuantErr
            // 
            this.tbSQuantErr.BackColor = System.Drawing.SystemColors.Window;
            this.tbSQuantErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSQuantErr.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSQuantErr.Location = new System.Drawing.Point(246, 0);
            this.tbSQuantErr.MaxLength = 16;
            this.tbSQuantErr.Name = "tbSQuantErr";
            this.tbSQuantErr.Size = new System.Drawing.Size(292, 23);
            this.tbSQuantErr.TabIndex = 1;
            // 
            // tbSQuant
            // 
            this.tbSQuant.BackColor = System.Drawing.SystemColors.Window;
            this.tbSQuant.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSQuant.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSQuant.Location = new System.Drawing.Point(0, 0);
            this.tbSQuant.MaxLength = 16;
            this.tbSQuant.Name = "tbSQuant";
            this.tbSQuant.Size = new System.Drawing.Size(246, 23);
            this.tbSQuant.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Laboratorie / Operatør";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxLocation
            // 
            this.cboxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLocation.DropDownWidth = 300;
            this.cboxLocation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLocation.FormattingEnabled = true;
            this.cboxLocation.Location = new System.Drawing.Point(3, 227);
            this.cboxLocation.MaxLength = 255;
            this.cboxLocation.Name = "cboxLocation";
            this.cboxLocation.Size = new System.Drawing.Size(234, 23);
            this.cboxLocation.TabIndex = 9;
            this.cboxLocation.SelectedIndexChanged += new System.EventHandler(this.cboxLocation_SelectedIndexChanged);
            this.cboxLocation.MouseHover += new System.EventHandler(this.cboxLocation_MouseHover);
            // 
            // tbSLoctn
            // 
            this.tbSLoctn.BackColor = System.Drawing.SystemColors.Window;
            this.tbSLoctn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSLoctn.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSLoctn.Location = new System.Drawing.Point(243, 227);
            this.tbSLoctn.MaxLength = 78;
            this.tbSLoctn.Name = "tbSLoctn";
            this.tbSLoctn.Size = new System.Drawing.Size(538, 23);
            this.tbSLoctn.TabIndex = 10;
            // 
            // cboxCoordType
            // 
            this.cboxCoordType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxCoordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCoordType.DropDownWidth = 300;
            this.cboxCoordType.FormattingEnabled = true;
            this.cboxCoordType.Location = new System.Drawing.Point(3, 195);
            this.cboxCoordType.MaxLength = 255;
            this.cboxCoordType.Name = "cboxCoordType";
            this.cboxCoordType.Size = new System.Drawing.Size(234, 24);
            this.cboxCoordType.TabIndex = 7;
            this.cboxCoordType.SelectedIndexChanged += new System.EventHandler(this.cboxCoordType_SelectedIndexChanged);
            this.cboxCoordType.MouseHover += new System.EventHandler(this.cboxCoordType_MouseHover);
            // 
            // panelCoords
            // 
            this.panelCoords.Controls.Add(this.tbLongitude);
            this.panelCoords.Controls.Add(this.tbAltitude);
            this.panelCoords.Controls.Add(this.tbLatitude);
            this.panelCoords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoords.Location = new System.Drawing.Point(243, 195);
            this.panelCoords.Name = "panelCoords";
            this.panelCoords.Size = new System.Drawing.Size(538, 26);
            this.panelCoords.TabIndex = 8;
            // 
            // tbLongitude
            // 
            this.tbLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLongitude.Location = new System.Drawing.Point(163, 0);
            this.tbLongitude.MaxLength = 16;
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(206, 22);
            this.tbLongitude.TabIndex = 1;
            // 
            // tbAltitude
            // 
            this.tbAltitude.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbAltitude.Location = new System.Drawing.Point(369, 0);
            this.tbAltitude.MaxLength = 16;
            this.tbAltitude.Name = "tbAltitude";
            this.tbAltitude.Size = new System.Drawing.Size(169, 22);
            this.tbAltitude.TabIndex = 2;
            // 
            // tbLatitude
            // 
            this.tbLatitude.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbLatitude.Location = new System.Drawing.Point(0, 0);
            this.tbLatitude.MaxLength = 16;
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(163, 22);
            this.tbLatitude.TabIndex = 0;
            // 
            // lblCommunity
            // 
            this.lblCommunity.AutoSize = true;
            this.lblCommunity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCommunity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommunity.Location = new System.Drawing.Point(3, 128);
            this.lblCommunity.Name = "lblCommunity";
            this.lblCommunity.Size = new System.Drawing.Size(234, 32);
            this.lblCommunity.TabIndex = 32;
            this.lblCommunity.Text = "Fylke / Kommune";
            this.lblCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxCommunity
            // 
            this.cboxCommunity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxCommunity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxCommunity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxCommunity.FormattingEnabled = true;
            this.cboxCommunity.Location = new System.Drawing.Point(243, 131);
            this.cboxCommunity.MaxLength = 255;
            this.cboxCommunity.Name = "cboxCommunity";
            this.cboxCommunity.Size = new System.Drawing.Size(538, 24);
            this.cboxCommunity.Sorted = true;
            this.cboxCommunity.TabIndex = 6;
            this.cboxCommunity.Leave += new System.EventHandler(this.cboxCommunity_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(3, 340);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 32);
            this.label14.TabIndex = 18;
            this.label14.Text = "Referansedato";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelReferenceDate
            // 
            this.panelReferenceDate.Controls.Add(this.dtpSTime);
            this.panelReferenceDate.Controls.Add(this.dtpSDate);
            this.panelReferenceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReferenceDate.Location = new System.Drawing.Point(243, 343);
            this.panelReferenceDate.Name = "panelReferenceDate";
            this.panelReferenceDate.Size = new System.Drawing.Size(538, 26);
            this.panelReferenceDate.TabIndex = 14;
            this.panelReferenceDate.TabStop = true;
            // 
            // dtpSTime
            // 
            this.dtpSTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpSTime.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpSTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSTime.Location = new System.Drawing.Point(246, 0);
            this.dtpSTime.Name = "dtpSTime";
            this.dtpSTime.ShowUpDown = true;
            this.dtpSTime.Size = new System.Drawing.Size(292, 23);
            this.dtpSTime.TabIndex = 1;
            // 
            // dtpSDate
            // 
            this.dtpSDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpSDate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSDate.Location = new System.Drawing.Point(0, 0);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(246, 23);
            this.dtpSDate.TabIndex = 0;
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.tbSSysterr);
            this.panelError.Controls.Add(this.tbSSyserr);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelError.Location = new System.Drawing.Point(243, 395);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(538, 26);
            this.panelError.TabIndex = 16;
            this.panelError.TabStop = true;
            // 
            // tbSSysterr
            // 
            this.tbSSysterr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSSysterr.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSSysterr.Location = new System.Drawing.Point(246, 0);
            this.tbSSysterr.MaxLength = 8;
            this.tbSSysterr.Name = "tbSSysterr";
            this.tbSSysterr.Size = new System.Drawing.Size(292, 23);
            this.tbSSysterr.TabIndex = 1;
            // 
            // tbSSyserr
            // 
            this.tbSSyserr.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSSyserr.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSSyserr.Location = new System.Drawing.Point(0, 0);
            this.tbSSyserr.MaxLength = 8;
            this.tbSSyserr.Name = "tbSSyserr";
            this.tbSSyserr.Size = new System.Drawing.Size(246, 23);
            this.tbSSyserr.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label11.Location = new System.Drawing.Point(3, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 32);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tilf. / Syst. Feil (%)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 32);
            this.label9.TabIndex = 37;
            this.label9.Text = "Kommentar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Location = new System.Drawing.Point(243, 427);
            this.tbComment.MaxLength = 78;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(538, 22);
            this.tbComment.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 32);
            this.label10.TabIndex = 39;
            this.label10.Text = "Komponent / ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSampleType
            // 
            this.panelSampleType.Controls.Add(this.cboxSampleType);
            this.panelSampleType.Controls.Add(this.btnBrowseSampleType);
            this.panelSampleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSampleType.Location = new System.Drawing.Point(243, 67);
            this.panelSampleType.Name = "panelSampleType";
            this.panelSampleType.Size = new System.Drawing.Size(538, 26);
            this.panelSampleType.TabIndex = 3;
            // 
            // cboxSampleType
            // 
            this.cboxSampleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxSampleType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSampleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSampleType.FormattingEnabled = true;
            this.cboxSampleType.Location = new System.Drawing.Point(0, 0);
            this.cboxSampleType.MaxLength = 255;
            this.cboxSampleType.Name = "cboxSampleType";
            this.cboxSampleType.Size = new System.Drawing.Size(504, 24);
            this.cboxSampleType.Sorted = true;
            this.cboxSampleType.TabIndex = 0;
            this.cboxSampleType.SelectedIndexChanged += new System.EventHandler(this.cboxSampleType_SelectedIndexChanged);
            this.cboxSampleType.Leave += new System.EventHandler(this.cboxSampleType_Leave);
            // 
            // btnBrowseSampleType
            // 
            this.btnBrowseSampleType.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowseSampleType.Location = new System.Drawing.Point(504, 0);
            this.btnBrowseSampleType.Name = "btnBrowseSampleType";
            this.btnBrowseSampleType.Size = new System.Drawing.Size(34, 26);
            this.btnBrowseSampleType.TabIndex = 1;
            this.btnBrowseSampleType.Text = "...";
            this.btnBrowseSampleType.UseVisualStyleBackColor = true;
            this.btnBrowseSampleType.Click += new System.EventHandler(this.btnBrowseSampleType_Click);
            // 
            // panelUnitGeom
            // 
            this.panelUnitGeom.Controls.Add(this.cboxSGeomtry);
            this.panelUnitGeom.Controls.Add(this.cboxSUnits);
            this.panelUnitGeom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUnitGeom.Location = new System.Drawing.Point(243, 311);
            this.panelUnitGeom.Name = "panelUnitGeom";
            this.panelUnitGeom.Size = new System.Drawing.Size(538, 26);
            this.panelUnitGeom.TabIndex = 12;
            // 
            // cboxSGeomtry
            // 
            this.cboxSGeomtry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSGeomtry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSGeomtry.FormattingEnabled = true;
            this.cboxSGeomtry.Location = new System.Drawing.Point(246, 0);
            this.cboxSGeomtry.MaxLength = 16;
            this.cboxSGeomtry.Name = "cboxSGeomtry";
            this.cboxSGeomtry.Size = new System.Drawing.Size(292, 24);
            this.cboxSGeomtry.Sorted = true;
            this.cboxSGeomtry.TabIndex = 1;
            // 
            // cboxSUnits
            // 
            this.cboxSUnits.BackColor = System.Drawing.SystemColors.Window;
            this.cboxSUnits.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxSUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSUnits.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboxSUnits.FormattingEnabled = true;
            this.cboxSUnits.Items.AddRange(new object[] {
            "Kg",
            "g",
            "L"});
            this.cboxSUnits.Location = new System.Drawing.Point(0, 0);
            this.cboxSUnits.MaxLength = 16;
            this.cboxSUnits.Name = "cboxSUnits";
            this.cboxSUnits.Size = new System.Drawing.Size(246, 24);
            this.cboxSUnits.TabIndex = 0;
            // 
            // panelCoordLabel
            // 
            this.panelCoordLabel.Controls.Add(this.labelCoordAltitude);
            this.panelCoordLabel.Controls.Add(this.labelCoordLongitude);
            this.panelCoordLabel.Controls.Add(this.labelCoordLatitude);
            this.panelCoordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoordLabel.Location = new System.Drawing.Point(243, 163);
            this.panelCoordLabel.Name = "panelCoordLabel";
            this.panelCoordLabel.Size = new System.Drawing.Size(538, 26);
            this.panelCoordLabel.TabIndex = 40;
            // 
            // labelCoordAltitude
            // 
            this.labelCoordAltitude.AutoSize = true;
            this.labelCoordAltitude.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCoordAltitude.Location = new System.Drawing.Point(328, 4);
            this.labelCoordAltitude.Name = "labelCoordAltitude";
            this.labelCoordAltitude.Size = new System.Drawing.Size(106, 16);
            this.labelCoordAltitude.TabIndex = 1;
            this.labelCoordAltitude.Text = "Høyde over havet";
            this.labelCoordAltitude.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCoordLongitude
            // 
            this.labelCoordLongitude.AutoSize = true;
            this.labelCoordLongitude.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCoordLongitude.Location = new System.Drawing.Point(160, 4);
            this.labelCoordLongitude.Name = "labelCoordLongitude";
            this.labelCoordLongitude.Size = new System.Drawing.Size(75, 16);
            this.labelCoordLongitude.TabIndex = 2;
            this.labelCoordLongitude.Text = "Lengdegrad";
            this.labelCoordLongitude.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCoordLatitude
            // 
            this.labelCoordLatitude.AutoSize = true;
            this.labelCoordLatitude.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCoordLatitude.Location = new System.Drawing.Point(3, 4);
            this.labelCoordLatitude.Name = "labelCoordLatitude";
            this.labelCoordLatitude.Size = new System.Drawing.Size(74, 16);
            this.labelCoordLatitude.TabIndex = 0;
            this.labelCoordLatitude.Text = "Breddegrad";
            this.labelCoordLatitude.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelLab
            // 
            this.panelLab.Controls.Add(this.tbScollName);
            this.panelLab.Controls.Add(this.tbLab);
            this.panelLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLab.Location = new System.Drawing.Point(243, 3);
            this.panelLab.Name = "panelLab";
            this.panelLab.Size = new System.Drawing.Size(538, 26);
            this.panelLab.TabIndex = 0;
            // 
            // tbScollName
            // 
            this.tbScollName.BackColor = System.Drawing.SystemColors.Window;
            this.tbScollName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScollName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbScollName.Location = new System.Drawing.Point(246, 0);
            this.tbScollName.MaxLength = 24;
            this.tbScollName.Name = "tbScollName";
            this.tbScollName.Size = new System.Drawing.Size(292, 23);
            this.tbScollName.TabIndex = 1;
            // 
            // tbLab
            // 
            this.tbLab.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbLab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLab.Location = new System.Drawing.Point(0, 0);
            this.tbLab.MaxLength = 16;
            this.tbLab.Name = "tbLab";
            this.tbLab.Size = new System.Drawing.Size(246, 22);
            this.tbLab.TabIndex = 0;
            // 
            // panelSampleCompID
            // 
            this.panelSampleCompID.Controls.Add(this.tbSIdent);
            this.panelSampleCompID.Controls.Add(this.cboxComponent);
            this.panelSampleCompID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSampleCompID.Location = new System.Drawing.Point(243, 99);
            this.panelSampleCompID.Name = "panelSampleCompID";
            this.panelSampleCompID.Size = new System.Drawing.Size(538, 26);
            this.panelSampleCompID.TabIndex = 5;
            // 
            // tbSIdent
            // 
            this.tbSIdent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSIdent.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbSIdent.Location = new System.Drawing.Point(246, 0);
            this.tbSIdent.MaxLength = 16;
            this.tbSIdent.Name = "tbSIdent";
            this.tbSIdent.Size = new System.Drawing.Size(292, 23);
            this.tbSIdent.TabIndex = 1;
            // 
            // cboxComponent
            // 
            this.cboxComponent.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxComponent.FormattingEnabled = true;
            this.cboxComponent.Location = new System.Drawing.Point(0, 0);
            this.cboxComponent.MaxLength = 255;
            this.cboxComponent.Name = "cboxComponent";
            this.cboxComponent.Size = new System.Drawing.Size(246, 24);
            this.cboxComponent.TabIndex = 0;
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImport});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(784, 25);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // btnImport
            // 
            this.btnImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportSampReg});
            this.btnImport.Enabled = false;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 22);
            this.btnImport.Text = "Import fra fil";
            // 
            // btnImportSampReg
            // 
            this.btnImportSampReg.Name = "btnImportSampReg";
            this.btnImportSampReg.Size = new System.Drawing.Size(203, 22);
            this.btnImportSampReg.Text = "Sample registration logg";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 539);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(784, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(82, 17);
            this.statusLabel.Text = "<statusLabel>";
            // 
            // FormSampleInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSampleInput";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prøveinformasjon";
            this.Load += new System.EventHandler(this.FormSampleInput_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSampleInput_Paint);
            this.Resize += new System.EventHandler(this.FormSampleInput_Resize);
            this.panel1.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.panelSampleQuant.ResumeLayout(false);
            this.panelSampleQuant.PerformLayout();
            this.panelCoords.ResumeLayout(false);
            this.panelCoords.PerformLayout();
            this.panelReferenceDate.ResumeLayout(false);
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.panelSampleType.ResumeLayout(false);
            this.panelUnitGeom.ResumeLayout(false);
            this.panelCoordLabel.ResumeLayout(false);
            this.panelCoordLabel.PerformLayout();
            this.panelLab.ResumeLayout(false);
            this.panelLab.PerformLayout();
            this.panelSampleCompID.ResumeLayout(false);
            this.panelSampleCompID.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbScollName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSTitle;
        private System.Windows.Forms.TextBox tbSIdent;
        private System.Windows.Forms.TextBox tbSLoctn;
        private System.Windows.Forms.TextBox tbSQuant;
        private System.Windows.Forms.TextBox tbSQuantErr;
        private System.Windows.Forms.ComboBox cboxSUnits;
        private System.Windows.Forms.TextBox tbSSyserr;
        private System.Windows.Forms.TextBox tbSSysterr;
        private System.Windows.Forms.Panel panelReferenceDate;
        private System.Windows.Forms.DateTimePicker dtpSTime;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.Panel panelSampleQuant;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ComboBox cboxLocation;
        private System.Windows.Forms.ComboBox cboxSGeomtry;
        private System.Windows.Forms.ToolStripDropDownButton btnImport;
        private System.Windows.Forms.ToolStripMenuItem btnImportSampReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLab;
        private System.Windows.Forms.Panel panelCoords;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.ComboBox cboxCoordType;
        private System.Windows.Forms.ComboBox cboxCommunity;
        private System.Windows.Forms.Label lblCommunity;
        private System.Windows.Forms.ComboBox cboxSampleType;
        private System.Windows.Forms.TextBox tbAltitude;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxComponent;
        private System.Windows.Forms.Panel panelSampleType;
        private System.Windows.Forms.Button btnBrowseSampleType;
        private System.Windows.Forms.Panel panelUnitGeom;
        private System.Windows.Forms.Panel panelCoordLabel;
        private System.Windows.Forms.Label labelCoordLatitude;
        private System.Windows.Forms.Label labelCoordAltitude;
        private System.Windows.Forms.Label labelCoordLongitude;
        private System.Windows.Forms.Panel panelLab;
        private System.Windows.Forms.Panel panelSampleCompID;
    }
}


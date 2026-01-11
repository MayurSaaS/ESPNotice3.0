namespace ESPNotice3._0.Forms
{
    partial class frmImportTagEdit
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
        private static frmImportTagEdit sForm = null;
        public static frmImportTagEdit Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmImportTagEdit(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            lblDeviceID = new Label();
            dgvCSV = new DataGridView();
            btnImportCSVFile = new Button();
            btnBrowse = new Button();
            tbxCSVFilePath = new TextBox();
            lblCSVFilePath = new Label();
            dtpCSVFile = new DateTimePicker();
            lblDelimeter = new Label();
            cbxDelimeter = new ComboBox();
            lblCenterCode = new Label();
            lblCenterName = new Label();
            cbxCenterName = new ComboBox();
            lblCSVFileDate = new Label();
            lblStarCSVFileDate = new Label();
            lblStarCSVFilePath = new Label();
            lblStarCenterName = new Label();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCSV).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Controls.Add(lblStarCenterName);
            pnlMain.Controls.Add(lblStarCSVFilePath);
            pnlMain.Controls.Add(lblStarCSVFileDate);
            pnlMain.Controls.Add(lblDeviceID);
            pnlMain.Controls.Add(dgvCSV);
            pnlMain.Controls.Add(btnImportCSVFile);
            pnlMain.Controls.Add(btnBrowse);
            pnlMain.Controls.Add(tbxCSVFilePath);
            pnlMain.Controls.Add(lblCSVFilePath);
            pnlMain.Controls.Add(dtpCSVFile);
            pnlMain.Controls.Add(lblDelimeter);
            pnlMain.Controls.Add(cbxDelimeter);
            pnlMain.Controls.Add(lblCenterCode);
            pnlMain.Controls.Add(lblCenterName);
            pnlMain.Controls.Add(cbxCenterName);
            pnlMain.Controls.Add(lblCSVFileDate);
            pnlMain.Location = new Point(6, 76);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1320, 662);
            pnlMain.TabIndex = 10;
            // 
            // lblDeviceID
            // 
            lblDeviceID.BackColor = Color.Gainsboro;
            lblDeviceID.BorderStyle = BorderStyle.FixedSingle;
            lblDeviceID.Location = new Point(778, 25);
            lblDeviceID.Name = "lblDeviceID";
            lblDeviceID.Size = new Size(104, 27);
            lblDeviceID.TabIndex = 27;
            lblDeviceID.TextAlign = ContentAlignment.MiddleLeft;
            lblDeviceID.Visible = false;
            // 
            // dgvCSV
            // 
            dgvCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCSV.Location = new Point(28, 155);
            dgvCSV.Name = "dgvCSV";
            dgvCSV.RowHeadersWidth = 51;
            dgvCSV.Size = new Size(1268, 485);
            dgvCSV.TabIndex = 6;
            // 
            // btnImportCSVFile
            // 
            btnImportCSVFile.Location = new Point(1028, 24);
            btnImportCSVFile.Name = "btnImportCSVFile";
            btnImportCSVFile.Size = new Size(268, 79);
            btnImportCSVFile.TabIndex = 5;
            btnImportCSVFile.Text = "&Import CSV File\r\n(Only valid records will be imported)";
            btnImportCSVFile.UseVisualStyleBackColor = true;
            btnImportCSVFile.Click += btnImportCSVFile_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(976, 74);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(48, 29);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tbxCSVFilePath
            // 
            tbxCSVFilePath.BorderStyle = BorderStyle.FixedSingle;
            tbxCSVFilePath.Location = new Point(141, 75);
            tbxCSVFilePath.Name = "tbxCSVFilePath";
            tbxCSVFilePath.ReadOnly = true;
            tbxCSVFilePath.Size = new Size(823, 27);
            tbxCSVFilePath.TabIndex = 0;
            tbxCSVFilePath.TabStop = false;
            // 
            // lblCSVFilePath
            // 
            lblCSVFilePath.Location = new Point(28, 75);
            lblCSVFilePath.Name = "lblCSVFilePath";
            lblCSVFilePath.Size = new Size(101, 27);
            lblCSVFilePath.TabIndex = 26;
            lblCSVFilePath.Text = "CSV File Path";
            lblCSVFilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpCSVFile
            // 
            dtpCSVFile.CustomFormat = "dd-MMM-yyyy";
            dtpCSVFile.Format = DateTimePickerFormat.Custom;
            dtpCSVFile.Location = new Point(141, 25);
            dtpCSVFile.Name = "dtpCSVFile";
            dtpCSVFile.Size = new Size(137, 27);
            dtpCSVFile.TabIndex = 1;
            // 
            // lblDelimeter
            // 
            lblDelimeter.Location = new Point(888, 25);
            lblDelimeter.Name = "lblDelimeter";
            lblDelimeter.Size = new Size(76, 27);
            lblDelimeter.TabIndex = 24;
            lblDelimeter.Text = "Delimeter";
            lblDelimeter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxDelimeter
            // 
            cbxDelimeter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDelimeter.FormattingEnabled = true;
            cbxDelimeter.Items.AddRange(new object[] { ",", ";" });
            cbxDelimeter.Location = new Point(976, 24);
            cbxDelimeter.Name = "cbxDelimeter";
            cbxDelimeter.Size = new Size(48, 28);
            cbxDelimeter.TabIndex = 3;
            // 
            // lblCenterCode
            // 
            lblCenterCode.BackColor = Color.Gainsboro;
            lblCenterCode.BorderStyle = BorderStyle.FixedSingle;
            lblCenterCode.Location = new Point(711, 25);
            lblCenterCode.Name = "lblCenterCode";
            lblCenterCode.Size = new Size(50, 27);
            lblCenterCode.TabIndex = 22;
            lblCenterCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCenterName
            // 
            lblCenterName.Location = new Point(290, 25);
            lblCenterName.Name = "lblCenterName";
            lblCenterName.Size = new Size(96, 27);
            lblCenterName.TabIndex = 21;
            lblCenterName.Text = "Center Name";
            lblCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxCenterName
            // 
            cbxCenterName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCenterName.FormattingEnabled = true;
            cbxCenterName.Location = new Point(398, 24);
            cbxCenterName.Name = "cbxCenterName";
            cbxCenterName.Size = new Size(301, 28);
            cbxCenterName.TabIndex = 2;
            cbxCenterName.SelectedIndexChanged += cbxCenterName_SelectedIndexChanged;
            // 
            // lblCSVFileDate
            // 
            lblCSVFileDate.Location = new Point(28, 25);
            lblCSVFileDate.Name = "lblCSVFileDate";
            lblCSVFileDate.Size = new Size(101, 27);
            lblCSVFileDate.TabIndex = 19;
            lblCSVFileDate.Text = "CSV File Date";
            lblCSVFileDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStarCSVFileDate
            // 
            lblStarCSVFileDate.ForeColor = Color.Red;
            lblStarCSVFileDate.Location = new Point(18, 25);
            lblStarCSVFileDate.Name = "lblStarCSVFileDate";
            lblStarCSVFileDate.Size = new Size(10, 10);
            lblStarCSVFileDate.TabIndex = 28;
            lblStarCSVFileDate.Text = "*";
            lblStarCSVFileDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStarCSVFilePath
            // 
            lblStarCSVFilePath.ForeColor = Color.Red;
            lblStarCSVFilePath.Location = new Point(18, 75);
            lblStarCSVFilePath.Name = "lblStarCSVFilePath";
            lblStarCSVFilePath.Size = new Size(10, 10);
            lblStarCSVFilePath.TabIndex = 29;
            lblStarCSVFilePath.Text = "*";
            lblStarCSVFilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStarCenterName
            // 
            lblStarCenterName.ForeColor = Color.Red;
            lblStarCenterName.Location = new Point(280, 25);
            lblStarCenterName.Name = "lblStarCenterName";
            lblStarCenterName.Size = new Size(10, 10);
            lblStarCenterName.TabIndex = 30;
            lblStarCenterName.Text = "*";
            lblStarCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmImportTagEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Controls.Add(pnlMain);
            Name = "frmImportTagEdit";
            Text = "Import TagEdit File (CSV)";
            Load += frmImportTagEdit_Load;
            Controls.SetChildIndex(tabControl, 0);
            Controls.SetChildIndex(pnlMain, 0);
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCSV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private DataGridView dgvCSV;
        private Button btnImportCSVFile;
        private Button btnBrowse;
        private TextBox tbxCSVFilePath;
        private Label lblCSVFilePath;
        private DateTimePicker dtpCSVFile;
        private Label lblDelimeter;
        private ComboBox cbxDelimeter;
        private Label lblCenterCode;
        private Label lblCenterName;
        private ComboBox cbxCenterName;
        private Label lblCSVFileDate;
        private Label lblDeviceID;
        private Label lblStarCSVFilePath;
        private Label lblStarCSVFileDate;
        private Label lblStarCenterName;
    }
}
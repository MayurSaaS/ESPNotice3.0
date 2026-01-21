
namespace ESPNotice3._0.Forms
{
    partial class frmNoticeGeneration
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
        private static frmNoticeGeneration sForm = null;
        public static frmNoticeGeneration Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmNoticeGeneration(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcessNotices = new Button();
            btnOpenPDF = new Button();
            btnBrowse = new Button();
            lblPDFFile = new Label();
            cbxPDFFiles = new ComboBox();
            lblPicsPath = new Label();
            tbxInputFilePath = new TextBox();
            tbxCenterCode = new TextBox();
            cbxCenterName = new ComboBox();
            lblCenterName = new Label();
            lblCSVDate = new Label();
            dtpCSVDate = new DateTimePicker();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lblStarCSVDate = new Label();
            lblStarPicsPath = new Label();
            lblStarPDFFile = new Label();
            lblStarCenterName = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            tabNoticeView = new TabPage();
            grbNoticeView = new GroupBox();
            btnNoticeView = new Button();
            lblListCenter = new Label();
            cbxListCenter = new ComboBox();
            grbFormView.SuspendLayout();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            tabNoticeView.SuspendLayout();
            grbNoticeView.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // grbFormView
            // 
            grbFormView.Controls.Add(lblStarCenterName);
            grbFormView.Controls.Add(lblStarPDFFile);
            grbFormView.Controls.Add(lblStarPicsPath);
            grbFormView.Controls.Add(lblStarCSVDate);
            grbFormView.Controls.Add(btnProcessNotices);
            grbFormView.Controls.Add(btnOpenPDF);
            grbFormView.Controls.Add(btnBrowse);
            grbFormView.Controls.Add(lblPDFFile);
            grbFormView.Controls.Add(cbxPDFFiles);
            grbFormView.Controls.Add(lblPicsPath);
            grbFormView.Controls.Add(tbxInputFilePath);
            grbFormView.Controls.Add(tbxCenterCode);
            grbFormView.Controls.Add(cbxCenterName);
            grbFormView.Controls.Add(lblCenterName);
            grbFormView.Controls.Add(lblCSVDate);
            grbFormView.Controls.Add(dtpCSVDate);
            grbFormView.Controls.SetChildIndex(dtpCSVDate, 0);
            grbFormView.Controls.SetChildIndex(lblCSVDate, 0);
            grbFormView.Controls.SetChildIndex(lblCenterName, 0);
            grbFormView.Controls.SetChildIndex(cbxCenterName, 0);
            grbFormView.Controls.SetChildIndex(tbxCenterCode, 0);
            grbFormView.Controls.SetChildIndex(tbxInputFilePath, 0);
            grbFormView.Controls.SetChildIndex(lblPicsPath, 0);
            grbFormView.Controls.SetChildIndex(cbxPDFFiles, 0);
            grbFormView.Controls.SetChildIndex(lblPDFFile, 0);
            grbFormView.Controls.SetChildIndex(btnBrowse, 0);
            grbFormView.Controls.SetChildIndex(btnOpenPDF, 0);
            grbFormView.Controls.SetChildIndex(btnProcessNotices, 0);
            grbFormView.Controls.SetChildIndex(lblStarCSVDate, 0);
            grbFormView.Controls.SetChildIndex(lblStarPicsPath, 0);
            grbFormView.Controls.SetChildIndex(lblStarPDFFile, 0);
            grbFormView.Controls.SetChildIndex(lblStarCenterName, 0);
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNoticeView);
            tabControl.Controls.SetChildIndex(tabNoticeView, 0);
            tabControl.Controls.SetChildIndex(tabGridView, 0);
            // add to search panel
            // lblListCenter
            //Label lblListCenter = new Label();
            lblListCenter.Text = "Center";
            lblListCenter.Location = new Point(420, 20);
            lblListCenter.Size = new Size(60, 25);

            // cbxListCenter
            //ComboBox cbxListCenter = new ComboBox();
            cbxListCenter.Name = "cbxListCenter";
            cbxListCenter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxListCenter.Location = new Point(485, 20);
            cbxListCenter.Size = new Size(300, 28);
            cbxListCenter.SelectedIndexChanged += cbxListCenter_SelectedIndexChanged;

            // add to search panel
            pnlSearch.Controls.Add(lblListCenter);
            pnlSearch.Controls.Add(cbxListCenter);

            pnlSearch.Controls.Add(lblListCenter);
            pnlSearch.Controls.Add(cbxListCenter);
            // 
            // btnProcessNotices
            // 
            btnProcessNotices.BackColor = Color.FromArgb(41, 128, 185);
            btnProcessNotices.FlatStyle = FlatStyle.Flat;
            btnProcessNotices.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcessNotices.ForeColor = Color.White;
            btnProcessNotices.Location = new Point(1039, 40);
            btnProcessNotices.Name = "btnProcessNotices";
            btnProcessNotices.Size = new Size(140, 73);
            btnProcessNotices.TabIndex = 23;
            btnProcessNotices.Text = "Process Notices";
            btnProcessNotices.UseVisualStyleBackColor = false;
            btnProcessNotices.Click += btnProcessNotices_Click;
            // 
            // btnOpenPDF
            // 
            btnOpenPDF.Enabled = false;
            btnOpenPDF.Location = new Point(921, 132);
            btnOpenPDF.Name = "btnOpenPDF";
            btnOpenPDF.Size = new Size(94, 28);
            btnOpenPDF.TabIndex = 22;
            btnOpenPDF.Text = "Open File";
            btnOpenPDF.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(921, 86);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(50, 27);
            btnBrowse.TabIndex = 21;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblPDFFile
            // 
            lblPDFFile.Location = new Point(73, 132);
            lblPDFFile.Name = "lblPDFFile";
            lblPDFFile.Size = new Size(78, 27);
            lblPDFFile.TabIndex = 20;
            lblPDFFile.Text = "PDF File";
            lblPDFFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxPDFFiles
            // 
            cbxPDFFiles.Enabled = false;
            cbxPDFFiles.FormattingEnabled = true;
            cbxPDFFiles.Location = new Point(154, 132);
            cbxPDFFiles.Name = "cbxPDFFiles";
            cbxPDFFiles.Size = new Size(733, 28);
            cbxPDFFiles.TabIndex = 19;
            // 
            // lblPicsPath
            // 
            lblPicsPath.Location = new Point(73, 86);
            lblPicsPath.Name = "lblPicsPath";
            lblPicsPath.Size = new Size(78, 27);
            lblPicsPath.TabIndex = 18;
            lblPicsPath.Text = "Pics Path";
            lblPicsPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxInputFilePath
            // 
            tbxInputFilePath.BorderStyle = BorderStyle.FixedSingle;
            tbxInputFilePath.Enabled = false;
            tbxInputFilePath.Location = new Point(154, 86);
            tbxInputFilePath.Name = "tbxInputFilePath";
            tbxInputFilePath.Size = new Size(733, 27);
            tbxInputFilePath.TabIndex = 17;
            // 
            // tbxCenterCode
            // 
            tbxCenterCode.BackColor = Color.Gainsboro;
            tbxCenterCode.BorderStyle = BorderStyle.FixedSingle;
            tbxCenterCode.Enabled = false;
            tbxCenterCode.Location = new Point(921, 40);
            tbxCenterCode.Name = "tbxCenterCode";
            tbxCenterCode.Size = new Size(50, 27);
            tbxCenterCode.TabIndex = 16;
            // 
            // cbxCenterName
            // 
            cbxCenterName.FormattingEnabled = true;
            cbxCenterName.Location = new Point(432, 40);
            cbxCenterName.Name = "cbxCenterName";
            cbxCenterName.Size = new Size(455, 28);
            cbxCenterName.TabIndex = 15;
            cbxCenterName.SelectedIndexChanged += cbxCenterName_SelectedIndexChanged;
            // 
            // lblCenterName
            // 
            lblCenterName.Location = new Point(332, 40);
            lblCenterName.Name = "lblCenterName";
            lblCenterName.Size = new Size(100, 27);
            lblCenterName.TabIndex = 14;
            lblCenterName.Text = "Center Name";
            lblCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCSVDate
            // 
            lblCSVDate.Location = new Point(73, 40);
            lblCSVDate.Name = "lblCSVDate";
            lblCSVDate.Size = new Size(78, 27);
            lblCSVDate.TabIndex = 13;
            lblCSVDate.Text = "CSV File";
            lblCSVDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpCSVDate
            // 
            dtpCSVDate.CustomFormat = "dd-MMM-yyyy";
            dtpCSVDate.Format = DateTimePickerFormat.Custom;
            dtpCSVDate.Location = new Point(154, 40);
            dtpCSVDate.Name = "dtpCSVDate";
            dtpCSVDate.Size = new Size(141, 27);
            dtpCSVDate.TabIndex = 12;
            dtpCSVDate.ValueChanged += dtpCSVDate_ValueChanged;
            // 
            // lblStarCSVDate
            // 
            lblStarCSVDate.ForeColor = Color.Red;
            lblStarCSVDate.Location = new Point(63, 40);
            lblStarCSVDate.Name = "lblStarCSVDate";
            lblStarCSVDate.Size = new Size(10, 10);
            lblStarCSVDate.TabIndex = 24;
            lblStarCSVDate.Text = "*";
            lblStarCSVDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStarPicsPath
            // 
            lblStarPicsPath.ForeColor = Color.Red;
            lblStarPicsPath.Location = new Point(63, 86);
            lblStarPicsPath.Name = "lblStarPicsPath";
            lblStarPicsPath.Size = new Size(10, 10);
            lblStarPicsPath.TabIndex = 25;
            lblStarPicsPath.Text = "*";
            lblStarPicsPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStarPDFFile
            // 
            lblStarPDFFile.ForeColor = Color.Red;
            lblStarPDFFile.Location = new Point(63, 132);
            lblStarPDFFile.Name = "lblStarPDFFile";
            lblStarPDFFile.Size = new Size(10, 10);
            lblStarPDFFile.TabIndex = 26;
            lblStarPDFFile.Text = "*";
            lblStarPDFFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStarCenterName
            // 
            lblStarCenterName.ForeColor = Color.Red;
            lblStarCenterName.Location = new Point(322, 40);
            lblStarCenterName.Name = "lblStarCenterName";
            lblStarCenterName.Size = new Size(10, 10);
            lblStarCenterName.TabIndex = 27;
            lblStarCenterName.Text = "*";
            lblStarCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // reportViewer1
            // 
            reportViewer1.LocalReport.ReportEmbeddedResource = "ESPNotice3._0.RDLC.rptNotices.rdlc";
            reportViewer1.Location = new Point(10, 100);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1280, 500);
            reportViewer1.TabIndex = 0;
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // tabNoticeView
            // 
            tabNoticeView.Controls.Add(grbNoticeView);
            tabNoticeView.Location = new Point(4, 44);
            tabNoticeView.Name = "tabNoticeView";
            tabNoticeView.Size = new Size(1312, 614);
            tabNoticeView.TabIndex = 2;
            tabNoticeView.Text = "Notice View";
            tabNoticeView.UseVisualStyleBackColor = true;
            // 
            // grbNoticeView
            // 
            grbNoticeView.Controls.Add(btnNoticeView);
            grbNoticeView.Controls.Add(reportViewer1);
            grbNoticeView.Location = new Point(10, 0);
            grbNoticeView.Name = "grbNoticeView";
            grbNoticeView.Size = new Size(1312, 608);
            grbNoticeView.TabIndex = 0;
            grbNoticeView.TabStop = false;
            // 
            // btnNoticeView
            // 
            btnNoticeView.BackColor = Color.FromArgb(41, 128, 185);
            btnNoticeView.FlatStyle = FlatStyle.Flat;
            btnNoticeView.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNoticeView.ForeColor = Color.White;
            btnNoticeView.Location = new Point(623, 29);
            btnNoticeView.Name = "btnNoticeView";
            btnNoticeView.Size = new Size(148, 59);
            btnNoticeView.TabIndex = 1;
            btnNoticeView.Text = "View Notices";
            btnNoticeView.UseVisualStyleBackColor = false;
            btnNoticeView.Click += btnNoticeView_Click;
            // 
            // frmNoticeGeneration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmNoticeGeneration";
            Text = "Notice Generation";
            Load += frmNoticeGeneration_Load;
            grbFormView.ResumeLayout(false);
            grbFormView.PerformLayout();
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            tabNoticeView.ResumeLayout(false);
            grbNoticeView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcessNotices;
        private Button btnOpenPDF;
        private Button btnBrowse;
        private Label lblPDFFile;
        private ComboBox cbxPDFFiles;
        private Label lblPicsPath;
        private TextBox tbxInputFilePath;
        private TextBox tbxCenterCode;
        private ComboBox cbxCenterName;
        private Label lblCenterName;
        private Label lblCSVDate;
        private DateTimePicker dtpCSVDate;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lblStarCSVDate;
        private Label lblStarCenterName;
        private Label lblStarPDFFile;
        private Label lblStarPicsPath;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TabPage tabNoticeView;
        private GroupBox grbNoticeView;
        private Button btnNoticeView;
        private Label lblListCenter;
        private ComboBox cbxListCenter;
    }
}
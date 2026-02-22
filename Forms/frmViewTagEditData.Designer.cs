namespace ESPNotice3._0.Forms
{
    partial class frmViewTagEditData
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
        private static frmViewTagEditData sForm = null;
        public static frmViewTagEditData Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmViewTagEditData(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCSVFileDate = new Label();
            dtpCSVFileDate = new DateTimePicker();
            cbxCenterName = new ComboBox();
            lblCenterName = new Label();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(cbxCenterName);
            pnlSearch.Controls.Add(lblCenterName);
            pnlSearch.Controls.Add(dtpCSVFileDate);
            pnlSearch.Controls.Add(lblCSVFileDate);
            pnlSearch.Controls.SetChildIndex(btnSearch, 0);
            pnlSearch.Controls.SetChildIndex(tbxSearch, 0);
            pnlSearch.Controls.SetChildIndex(lblCSVFileDate, 0);
            pnlSearch.Controls.SetChildIndex(dtpCSVFileDate, 0);
            pnlSearch.Controls.SetChildIndex(lblCenterName, 0);
            pnlSearch.Controls.SetChildIndex(cbxCenterName, 0);
            // 
            // lblCSVFileDate
            // 
            lblCSVFileDate.Location = new Point(413, 23);
            lblCSVFileDate.Name = "lblCSVFileDate";
            lblCSVFileDate.Size = new Size(110, 25);
            lblCSVFileDate.TabIndex = 2;
            lblCSVFileDate.Text = "CSV FIle Date:";
            // 
            // dtpCSVFileDate
            // 
            dtpCSVFileDate.CustomFormat = "dd-MMM-yyyy";
            dtpCSVFileDate.Format = DateTimePickerFormat.Custom;
            dtpCSVFileDate.Location = new Point(525, 22);
            dtpCSVFileDate.Name = "dtpCSVFileDate";
            dtpCSVFileDate.Size = new Size(134, 27);
            dtpCSVFileDate.TabIndex = 3;
            dtpCSVFileDate.ValueChanged += dtpCSVFileDate_ValueChanged;
            // 
            // cbxCenterName
            // 
            cbxCenterName.FormattingEnabled = true;
            cbxCenterName.Location = new Point(774, 22);
            cbxCenterName.Name = "cbxCenterName";
            cbxCenterName.Size = new Size(306, 28);
            cbxCenterName.TabIndex = 17;
            // 
            // lblCenterName
            // 
            lblCenterName.Location = new Point(674, 22);
            lblCenterName.Name = "lblCenterName";
            lblCenterName.Size = new Size(100, 27);
            lblCenterName.TabIndex = 16;
            lblCenterName.Text = "Center Name";
            lblCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmViewTagEditData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmViewTagEditData";
            Text = "View TagEdit Data";
            FormClosing += frmViewTagEditData_FormClosing;
            Load += frmViewTagEditData_Load;
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpCSVFileDate;
        private Label lblCSVFileDate;
        private ComboBox cbxCenterName;
        private Label lblCenterName;
    }
}
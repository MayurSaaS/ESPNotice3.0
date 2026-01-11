namespace ESPNotice3._0.Forms
{
    partial class frmHistoryTagEditData
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
        private static frmHistoryTagEditData sForm = null;
        public static frmHistoryTagEditData Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmHistoryTagEditData(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFromCSVFileDate = new DateTimePicker();
            lblFromCSVFileDate = new Label();
            dtpToCSVFileDate = new DateTimePicker();
            lblToCSVFileDate = new Label();
            tbxValidGas = new TextBox();
            lblValidGas = new Label();
            tbxTotalRecord = new TextBox();
            lblTotalRecord = new Label();
            tbxCenterName = new TextBox();
            lblCenterName = new Label();
            tbxCenterCode = new TextBox();
            lblCenterCode = new Label();
            tbxDate = new TextBox();
            lblDate = new Label();
            grbFormView.SuspendLayout();
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
            // grbFormView
            // 
            grbFormView.Controls.Add(tbxValidGas);
            grbFormView.Controls.Add(lblValidGas);
            grbFormView.Controls.Add(tbxTotalRecord);
            grbFormView.Controls.Add(lblTotalRecord);
            grbFormView.Controls.Add(tbxCenterName);
            grbFormView.Controls.Add(lblCenterName);
            grbFormView.Controls.Add(tbxCenterCode);
            grbFormView.Controls.Add(lblCenterCode);
            grbFormView.Controls.Add(tbxDate);
            grbFormView.Controls.Add(lblDate);
            grbFormView.Controls.SetChildIndex(lblDate, 0);
            grbFormView.Controls.SetChildIndex(tbxDate, 0);
            grbFormView.Controls.SetChildIndex(lblCenterCode, 0);
            grbFormView.Controls.SetChildIndex(tbxCenterCode, 0);
            grbFormView.Controls.SetChildIndex(lblCenterName, 0);
            grbFormView.Controls.SetChildIndex(tbxCenterName, 0);
            grbFormView.Controls.SetChildIndex(lblTotalRecord, 0);
            grbFormView.Controls.SetChildIndex(tbxTotalRecord, 0);
            grbFormView.Controls.SetChildIndex(lblValidGas, 0);
            grbFormView.Controls.SetChildIndex(tbxValidGas, 0);
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(dtpToCSVFileDate);
            pnlSearch.Controls.Add(lblToCSVFileDate);
            pnlSearch.Controls.Add(dtpFromCSVFileDate);
            pnlSearch.Controls.Add(lblFromCSVFileDate);
            pnlSearch.Controls.SetChildIndex(btnSearch, 0);
            pnlSearch.Controls.SetChildIndex(tbxSearch, 0);
            pnlSearch.Controls.SetChildIndex(lblFromCSVFileDate, 0);
            pnlSearch.Controls.SetChildIndex(dtpFromCSVFileDate, 0);
            pnlSearch.Controls.SetChildIndex(lblToCSVFileDate, 0);
            pnlSearch.Controls.SetChildIndex(dtpToCSVFileDate, 0);
            // 
            // dtpFromCSVFileDate
            // 
            dtpFromCSVFileDate.CustomFormat = "dd-MMM-yyyy";
            dtpFromCSVFileDate.Format = DateTimePickerFormat.Custom;
            dtpFromCSVFileDate.Location = new Point(560, 22);
            dtpFromCSVFileDate.Name = "dtpFromCSVFileDate";
            dtpFromCSVFileDate.Size = new Size(157, 27);
            dtpFromCSVFileDate.TabIndex = 5;
            dtpFromCSVFileDate.ValueChanged += dtpFromCSVFileDate_ValueChanged;
            // 
            // lblFromCSVFileDate
            // 
            lblFromCSVFileDate.Location = new Point(415, 23);
            lblFromCSVFileDate.Name = "lblFromCSVFileDate";
            lblFromCSVFileDate.Size = new Size(140, 25);
            lblFromCSVFileDate.TabIndex = 4;
            lblFromCSVFileDate.Text = "From CSV FIle Date:";
            // 
            // dtpToCSVFileDate
            // 
            dtpToCSVFileDate.CustomFormat = "dd-MMM-yyyy";
            dtpToCSVFileDate.Format = DateTimePickerFormat.Custom;
            dtpToCSVFileDate.Location = new Point(888, 22);
            dtpToCSVFileDate.Name = "dtpToCSVFileDate";
            dtpToCSVFileDate.Size = new Size(157, 27);
            dtpToCSVFileDate.TabIndex = 7;
            dtpToCSVFileDate.ValueChanged += dtpToCSVFileDate_ValueChanged;
            // 
            // lblToCSVFileDate
            // 
            lblToCSVFileDate.Location = new Point(744, 23);
            lblToCSVFileDate.Name = "lblToCSVFileDate";
            lblToCSVFileDate.Size = new Size(140, 25);
            lblToCSVFileDate.TabIndex = 6;
            lblToCSVFileDate.Text = "To CSV FIle Date:";
            // 
            // tbxValidGas
            // 
            tbxValidGas.BorderStyle = BorderStyle.FixedSingle;
            tbxValidGas.Location = new Point(253, 304);
            tbxValidGas.Name = "tbxValidGas";
            tbxValidGas.Size = new Size(300, 27);
            tbxValidGas.TabIndex = 38;
            // 
            // lblValidGas
            // 
            lblValidGas.Location = new Point(78, 304);
            lblValidGas.Name = "lblValidGas";
            lblValidGas.Size = new Size(175, 27);
            lblValidGas.TabIndex = 37;
            lblValidGas.Text = "Valid Gas";
            lblValidGas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxTotalRecord
            // 
            tbxTotalRecord.BorderStyle = BorderStyle.FixedSingle;
            tbxTotalRecord.Location = new Point(912, 246);
            tbxTotalRecord.Name = "tbxTotalRecord";
            tbxTotalRecord.Size = new Size(300, 27);
            tbxTotalRecord.TabIndex = 36;
            // 
            // lblTotalRecord
            // 
            lblTotalRecord.Location = new Point(737, 246);
            lblTotalRecord.Name = "lblTotalRecord";
            lblTotalRecord.Size = new Size(175, 27);
            lblTotalRecord.TabIndex = 35;
            lblTotalRecord.Text = "Total Record(s)";
            lblTotalRecord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCenterName
            // 
            tbxCenterName.BorderStyle = BorderStyle.FixedSingle;
            tbxCenterName.Location = new Point(253, 246);
            tbxCenterName.Name = "tbxCenterName";
            tbxCenterName.Size = new Size(300, 27);
            tbxCenterName.TabIndex = 34;
            // 
            // lblCenterName
            // 
            lblCenterName.Location = new Point(78, 246);
            lblCenterName.Name = "lblCenterName";
            lblCenterName.Size = new Size(175, 27);
            lblCenterName.TabIndex = 33;
            lblCenterName.Text = "Center Name";
            lblCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCenterCode
            // 
            tbxCenterCode.BorderStyle = BorderStyle.FixedSingle;
            tbxCenterCode.Location = new Point(912, 193);
            tbxCenterCode.Name = "tbxCenterCode";
            tbxCenterCode.Size = new Size(300, 27);
            tbxCenterCode.TabIndex = 32;
            // 
            // lblCenterCode
            // 
            lblCenterCode.Location = new Point(737, 193);
            lblCenterCode.Name = "lblCenterCode";
            lblCenterCode.Size = new Size(175, 27);
            lblCenterCode.TabIndex = 31;
            lblCenterCode.Text = "Center Code";
            lblCenterCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxDate
            // 
            tbxDate.BorderStyle = BorderStyle.FixedSingle;
            tbxDate.Location = new Point(253, 193);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(300, 27);
            tbxDate.TabIndex = 30;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(78, 193);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(175, 27);
            lblDate.TabIndex = 29;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmHistoryTagEditData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmHistoryTagEditData";
            Text = "History TagEdit Data";
            grbFormView.ResumeLayout(false);
            grbFormView.PerformLayout();
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFromCSVFileDate;
        private Label lblFromCSVFileDate;
        private DateTimePicker dtpToCSVFileDate;
        private Label lblToCSVFileDate;
        private TextBox tbxValidGas;
        private Label lblValidGas;
        private TextBox tbxTotalRecord;
        private Label lblTotalRecord;
        private TextBox tbxCenterName;
        private Label lblCenterName;
        private TextBox tbxCenterCode;
        private Label lblCenterCode;
        private TextBox tbxDate;
        private Label lblDate;
    }
}
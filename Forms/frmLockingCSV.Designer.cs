using System.Windows.Forms;

namespace ESPNotice3._0.Forms
{
    partial class frmLockingCSV
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
        private static frmLockingCSV sForm = null;
        public static frmLockingCSV Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmLockingCSV(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpLockingToDate = new DateTimePicker();
            lblLockingToDate = new Label();
            dtpLockingFromDate = new DateTimePicker();
            lblLockingFromDate = new Label();
            lblListRTO = new Label();
            cbxListRTO = new ComboBox();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(lblListRTO);
            pnlSearch.Controls.Add(cbxListRTO);
            pnlSearch.Controls.Add(dtpLockingToDate);
            pnlSearch.Controls.Add(dtpLockingFromDate);
            pnlSearch.Controls.Add(lblLockingFromDate);
            pnlSearch.Controls.Add(lblLockingToDate);
            pnlSearch.Controls.SetChildIndex(lblLockingToDate, 0);
            pnlSearch.Controls.SetChildIndex(btnSearch, 0);
            pnlSearch.Controls.SetChildIndex(tbxSearch, 0);
            pnlSearch.Controls.SetChildIndex(lblLockingFromDate, 0);
            pnlSearch.Controls.SetChildIndex(dtpLockingFromDate, 0);
            pnlSearch.Controls.SetChildIndex(dtpLockingToDate, 0);
            pnlSearch.Controls.SetChildIndex(cbxListRTO, 0);
            pnlSearch.Controls.SetChildIndex(lblListRTO, 0);
            // 
            // dtpLockingToDate
            // 
            dtpLockingToDate.CustomFormat = "dd-MMM-yyyy";
            dtpLockingToDate.Format = DateTimePickerFormat.Custom;
            dtpLockingToDate.Location = new Point(1020, 22);
            dtpLockingToDate.Name = "dtpLockingToDate";
            dtpLockingToDate.Size = new Size(157, 27);
            dtpLockingToDate.TabIndex = 11;
            dtpLockingToDate.ValueChanged += dtpLockingToDate_ValueChanged;
            // 
            // lblLockingToDate
            // 
            lblLockingToDate.Location = new Point(940, 23);
            lblLockingToDate.Name = "lblLockingToDate";
            lblLockingToDate.Size = new Size(68, 25);
            lblLockingToDate.TabIndex = 10;
            lblLockingToDate.Text = "To Date:";
            lblLockingToDate.TextAlign = ContentAlignment.TopRight;
            // 
            // dtpLockingFromDate
            // 
            dtpLockingFromDate.CustomFormat = "dd-MMM-yyyy";
            dtpLockingFromDate.Format = DateTimePickerFormat.Custom;
            dtpLockingFromDate.Location = new Point(771, 22);
            dtpLockingFromDate.Name = "dtpLockingFromDate";
            dtpLockingFromDate.Size = new Size(157, 27);
            dtpLockingFromDate.TabIndex = 9;
            dtpLockingFromDate.ValueChanged += dtpLockingFromDate_ValueChanged;
            // 
            // lblLockingFromDate
            // 
            lblLockingFromDate.Location = new Point(674, 23);
            lblLockingFromDate.Name = "lblLockingFromDate";
            lblLockingFromDate.Size = new Size(85, 25);
            lblLockingFromDate.TabIndex = 8;
            lblLockingFromDate.Text = "From Date:";
            lblLockingFromDate.TextAlign = ContentAlignment.TopRight;
            // 
            // lblListRTO
            // 
            lblListRTO.Location = new Point(412, 21);
            lblListRTO.Name = "lblListRTO";
            lblListRTO.Size = new Size(38, 25);
            lblListRTO.TabIndex = 12;
            lblListRTO.Text = "RTO: ";
            // 
            // cbxListRTO
            // 
            cbxListRTO.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxListRTO.Location = new Point(462, 21);
            cbxListRTO.Name = "cbxListRTO";
            cbxListRTO.Size = new Size(200, 28);
            cbxListRTO.TabIndex = 13;
            // 
            // frmLockingCSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 128, 185);
            ClientSize = new Size(1338, 750);
            Name = "frmLockingCSV";
            Text = "frmLockingCSV";
            Load += frmLockingCSV_Load;
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpLockingToDate;
        private Label lblLockingToDate;
        private DateTimePicker dtpLockingFromDate;
        private Label lblLockingFromDate;
        private Label lblListRTO;
        private ComboBox cbxListRTO;
    }
}
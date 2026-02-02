
namespace ESPNotice3._0.Forms
{
    partial class frmCenters
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
        private static frmCenters sForm = null;
        public static frmCenters Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmCenters(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxCenterName = new TextBox();
            lblCenterName = new Label();
            tbxCenterCode = new TextBox();
            lblCenterCode = new Label();
            tbxStateCode = new TextBox();
            lblStateCode = new Label();
            grbFormView.SuspendLayout();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1254, 18);
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1254, 17);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1089, 15);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1254, 15);
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(1428, 12);
            // 
            // grbFormView
            // 
            grbFormView.Controls.Add(tbxStateCode);
            grbFormView.Controls.Add(lblStateCode);
            grbFormView.Controls.Add(tbxCenterName);
            grbFormView.Controls.Add(lblCenterName);
            grbFormView.Controls.Add(tbxCenterCode);
            grbFormView.Controls.Add(lblCenterCode);
            grbFormView.Controls.SetChildIndex(lblCenterCode, 0);
            grbFormView.Controls.SetChildIndex(tbxCenterCode, 0);
            grbFormView.Controls.SetChildIndex(lblCenterName, 0);
            grbFormView.Controls.SetChildIndex(tbxCenterName, 0);
            grbFormView.Controls.SetChildIndex(lblStateCode, 0);
            grbFormView.Controls.SetChildIndex(tbxStateCode, 0);
            // 
            // tabControl
            // 
            tabControl.Selected += tabControl_Selected;
            // 
            // tbxCenterName
            // 
            tbxCenterName.BorderStyle = BorderStyle.FixedSingle;
            tbxCenterName.Location = new Point(906, 45);
            tbxCenterName.Name = "tbxCenterName";
            tbxCenterName.Size = new Size(300, 27);
            tbxCenterName.TabIndex = 8;
            // 
            // lblCenterName
            // 
            lblCenterName.Location = new Point(731, 45);
            lblCenterName.Name = "lblCenterName";
            lblCenterName.Size = new Size(175, 27);
            lblCenterName.TabIndex = 7;
            lblCenterName.Text = "Center Name";
            lblCenterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCenterCode
            // 
            tbxCenterCode.BorderStyle = BorderStyle.FixedSingle;
            tbxCenterCode.Location = new Point(247, 45);
            tbxCenterCode.MaxLength = 4;
            tbxCenterCode.Name = "tbxCenterCode";
            tbxCenterCode.Size = new Size(300, 27);
            tbxCenterCode.TabIndex = 6;
            // 
            // lblCenterCode
            // 
            lblCenterCode.Location = new Point(72, 45);
            lblCenterCode.Name = "lblCenterCode";
            lblCenterCode.Size = new Size(175, 27);
            lblCenterCode.TabIndex = 5;
            lblCenterCode.Text = "Center Code";
            lblCenterCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxStateCode
            // 
            tbxStateCode.BorderStyle = BorderStyle.FixedSingle;
            tbxStateCode.Location = new Point(247, 105);
            tbxStateCode.MaxLength = 2;
            tbxStateCode.Name = "tbxStateCode";
            tbxStateCode.Size = new Size(300, 27);
            tbxStateCode.TabIndex = 10;
            // 
            // lblStateCode
            // 
            lblStateCode.Location = new Point(72, 105);
            lblStateCode.Name = "lblStateCode";
            lblStateCode.Size = new Size(175, 27);
            lblStateCode.TabIndex = 9;
            lblStateCode.Text = "State Code";
            lblStateCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmCenters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmCenters";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Centers";
            Load += frmCenters_Load;
            KeyDown += frmCenters_KeyDown;
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

        private TextBox tbxContactName;
        private Label lblContactName;
        private TextBox tbxCompanyName;
        private Label lblCompanyName;
        private TextBox tbxCenterCode;
        private Label lblCenterCode;
        private TextBox tbxCenterName;
        private Label lblCenterName;
        private TextBox tbxStateCode;
        private Label lblStateCode;
    }
}
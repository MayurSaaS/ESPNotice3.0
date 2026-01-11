namespace ESPNotice3._0.Forms
{
    partial class frmUsers
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
        private static frmUsers sForm = null;
        public static frmUsers Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmUsers(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxPassword = new TextBox();
            lblPassword = new Label();
            tbxLoginID = new TextBox();
            lblLoginID = new Label();
            tbxUserType = new TextBox();
            lblUserType = new Label();
            tbxName = new TextBox();
            lblName = new Label();
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
            grbFormView.Controls.Add(tbxPassword);
            grbFormView.Controls.Add(lblPassword);
            grbFormView.Controls.Add(tbxLoginID);
            grbFormView.Controls.Add(lblLoginID);
            grbFormView.Controls.Add(tbxUserType);
            grbFormView.Controls.Add(lblUserType);
            grbFormView.Controls.Add(tbxName);
            grbFormView.Controls.Add(lblName);
            grbFormView.Controls.SetChildIndex(lblName, 0);
            grbFormView.Controls.SetChildIndex(tbxName, 0);
            grbFormView.Controls.SetChildIndex(lblUserType, 0);
            grbFormView.Controls.SetChildIndex(tbxUserType, 0);
            grbFormView.Controls.SetChildIndex(lblLoginID, 0);
            grbFormView.Controls.SetChildIndex(tbxLoginID, 0);
            grbFormView.Controls.SetChildIndex(lblPassword, 0);
            grbFormView.Controls.SetChildIndex(tbxPassword, 0);
            // 
            // tbxPassword
            // 
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Location = new Point(912, 275);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(300, 27);
            tbxPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(737, 275);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(175, 27);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxLoginID
            // 
            tbxLoginID.BorderStyle = BorderStyle.FixedSingle;
            tbxLoginID.Location = new Point(253, 275);
            tbxLoginID.Name = "tbxLoginID";
            tbxLoginID.Size = new Size(300, 27);
            tbxLoginID.TabIndex = 14;
            // 
            // lblLoginID
            // 
            lblLoginID.Location = new Point(78, 275);
            lblLoginID.Name = "lblLoginID";
            lblLoginID.Size = new Size(175, 27);
            lblLoginID.TabIndex = 13;
            lblLoginID.Text = "LoginID";
            lblLoginID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxUserType
            // 
            tbxUserType.BorderStyle = BorderStyle.FixedSingle;
            tbxUserType.Location = new Point(912, 222);
            tbxUserType.Name = "tbxUserType";
            tbxUserType.Size = new Size(300, 27);
            tbxUserType.TabIndex = 12;
            // 
            // lblUserType
            // 
            lblUserType.Location = new Point(737, 222);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(175, 27);
            lblUserType.TabIndex = 11;
            lblUserType.Text = "UserType";
            lblUserType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            tbxName.BorderStyle = BorderStyle.FixedSingle;
            tbxName.Location = new Point(253, 222);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(300, 27);
            tbxName.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.Location = new Point(78, 222);
            lblName.Name = "lblName";
            lblName.Size = new Size(175, 27);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmUsers";
            Text = "Users";
            Load += frmUsers_Load;
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

        private TextBox tbxPassword;
        private Label lblPassword;
        private TextBox tbxLoginID;
        private Label lblLoginID;
        private TextBox tbxUserType;
        private Label lblUserType;
        private TextBox tbxName;
        private Label lblName;
    }
}
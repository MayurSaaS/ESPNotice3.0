namespace ESPNotice3._0.Forms
{
    partial class frmProfile
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
        private static frmProfile sForm = null;
        public static frmProfile Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmProfile(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCompanyName = new Label();
            tbxCompanyName = new TextBox();
            tbxContactName = new TextBox();
            lblContactName = new Label();
            tbxFaxNumber = new TextBox();
            lblFaxNumber = new Label();
            tbxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            tbxWebsite = new TextBox();
            lblWebsite = new Label();
            tbxEmailAddress = new TextBox();
            lblEmailAddress = new Label();
            tbxPincode = new TextBox();
            lblPincode = new Label();
            tbxAddress = new TextBox();
            lblAddress = new Label();
            grbFormView.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // grbFormView
            // 
            grbFormView.Controls.Add(tbxPincode);
            grbFormView.Controls.Add(lblPincode);
            grbFormView.Controls.Add(tbxAddress);
            grbFormView.Controls.Add(lblAddress);
            grbFormView.Controls.Add(tbxWebsite);
            grbFormView.Controls.Add(lblWebsite);
            grbFormView.Controls.Add(tbxEmailAddress);
            grbFormView.Controls.Add(lblEmailAddress);
            grbFormView.Controls.Add(tbxFaxNumber);
            grbFormView.Controls.Add(lblFaxNumber);
            grbFormView.Controls.Add(tbxPhoneNumber);
            grbFormView.Controls.Add(lblPhoneNumber);
            grbFormView.Controls.Add(tbxContactName);
            grbFormView.Controls.Add(lblContactName);
            grbFormView.Controls.Add(tbxCompanyName);
            grbFormView.Controls.Add(lblCompanyName);
            grbFormView.Controls.SetChildIndex(lblCompanyName, 0);
            grbFormView.Controls.SetChildIndex(tbxCompanyName, 0);
            grbFormView.Controls.SetChildIndex(lblContactName, 0);
            grbFormView.Controls.SetChildIndex(tbxContactName, 0);
            grbFormView.Controls.SetChildIndex(lblPhoneNumber, 0);
            grbFormView.Controls.SetChildIndex(tbxPhoneNumber, 0);
            grbFormView.Controls.SetChildIndex(lblFaxNumber, 0);
            grbFormView.Controls.SetChildIndex(tbxFaxNumber, 0);
            grbFormView.Controls.SetChildIndex(lblEmailAddress, 0);
            grbFormView.Controls.SetChildIndex(tbxEmailAddress, 0);
            grbFormView.Controls.SetChildIndex(lblWebsite, 0);
            grbFormView.Controls.SetChildIndex(tbxWebsite, 0);
            grbFormView.Controls.SetChildIndex(lblAddress, 0);
            grbFormView.Controls.SetChildIndex(tbxAddress, 0);
            grbFormView.Controls.SetChildIndex(lblPincode, 0);
            grbFormView.Controls.SetChildIndex(tbxPincode, 0);
            // 
            // tabControl
            // 
            tabControl.Selected += tabControl_Selected;
            // 
            // lblCompanyName
            // 
            lblCompanyName.Location = new Point(75, 46);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(175, 27);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "CompanyName";
            lblCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCompanyName
            // 
            tbxCompanyName.BorderStyle = BorderStyle.FixedSingle;
            tbxCompanyName.Location = new Point(250, 46);
            tbxCompanyName.Name = "tbxCompanyName";
            tbxCompanyName.Size = new Size(300, 27);
            tbxCompanyName.TabIndex = 2;
            // 
            // tbxContactName
            // 
            tbxContactName.BorderStyle = BorderStyle.FixedSingle;
            tbxContactName.Location = new Point(909, 46);
            tbxContactName.Name = "tbxContactName";
            tbxContactName.Size = new Size(300, 27);
            tbxContactName.TabIndex = 4;
            // 
            // lblContactName
            // 
            lblContactName.Location = new Point(734, 46);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(175, 27);
            lblContactName.TabIndex = 3;
            lblContactName.Text = "Contact Name";
            lblContactName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxFaxNumber
            // 
            tbxFaxNumber.BorderStyle = BorderStyle.FixedSingle;
            tbxFaxNumber.Location = new Point(909, 99);
            tbxFaxNumber.Name = "tbxFaxNumber";
            tbxFaxNumber.Size = new Size(300, 27);
            tbxFaxNumber.TabIndex = 8;
            // 
            // lblFaxNumber
            // 
            lblFaxNumber.Location = new Point(734, 99);
            lblFaxNumber.Name = "lblFaxNumber";
            lblFaxNumber.Size = new Size(175, 27);
            lblFaxNumber.TabIndex = 7;
            lblFaxNumber.Text = "Fax Number";
            lblFaxNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            tbxPhoneNumber.Location = new Point(250, 99);
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.Size = new Size(300, 27);
            tbxPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(75, 99);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(175, 27);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxWebsite
            // 
            tbxWebsite.BorderStyle = BorderStyle.FixedSingle;
            tbxWebsite.Location = new Point(909, 157);
            tbxWebsite.Name = "tbxWebsite";
            tbxWebsite.Size = new Size(300, 27);
            tbxWebsite.TabIndex = 12;
            // 
            // lblWebsite
            // 
            lblWebsite.Location = new Point(734, 157);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(175, 27);
            lblWebsite.TabIndex = 11;
            lblWebsite.Text = "Website";
            lblWebsite.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxEmailAddress
            // 
            tbxEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            tbxEmailAddress.Location = new Point(250, 157);
            tbxEmailAddress.Name = "tbxEmailAddress";
            tbxEmailAddress.Size = new Size(300, 27);
            tbxEmailAddress.TabIndex = 10;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.Location = new Point(75, 157);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(175, 27);
            lblEmailAddress.TabIndex = 9;
            lblEmailAddress.Text = "Email Address";
            lblEmailAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxPincode
            // 
            tbxPincode.BorderStyle = BorderStyle.FixedSingle;
            tbxPincode.Location = new Point(909, 211);
            tbxPincode.Name = "tbxPincode";
            tbxPincode.Size = new Size(300, 27);
            tbxPincode.TabIndex = 16;
            // 
            // lblPincode
            // 
            lblPincode.Location = new Point(734, 211);
            lblPincode.Name = "lblPincode";
            lblPincode.Size = new Size(175, 27);
            lblPincode.TabIndex = 15;
            lblPincode.Text = "Pincode";
            lblPincode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxAddress
            // 
            tbxAddress.BorderStyle = BorderStyle.FixedSingle;
            tbxAddress.Location = new Point(250, 211);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(300, 27);
            tbxAddress.TabIndex = 14;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(75, 211);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(175, 27);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmProfile";
            Text = "Profiles";
            Load += frmProfile_Load;
            grbFormView.ResumeLayout(false);
            grbFormView.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCompanyName;
        private TextBox tbxCompanyName;
        private TextBox tbxContactName;
        private Label lblContactName;
        private TextBox tbxPincode;
        private Label lblPincode;
        private TextBox tbxAddress;
        private Label lblAddress;
        private TextBox tbxWebsite;
        private Label lblWebsite;
        private TextBox tbxEmailAddress;
        private Label lblEmailAddress;
        private TextBox tbxFaxNumber;
        private Label lblFaxNumber;
        private TextBox tbxPhoneNumber;
        private Label lblPhoneNumber;
    }
}
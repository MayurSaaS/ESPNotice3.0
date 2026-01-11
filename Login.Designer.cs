namespace ESPNotice3._0
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblLicenceTo = new Label();
            lblAppNameDetail = new Label();
            lblAppName = new Label();
            pbxLogo = new PictureBox();
            pnlMain = new Panel();
            btnLogin = new Button();
            pnlPassword = new Panel();
            tbxPassword = new TextBox();
            pbxPassword = new PictureBox();
            pnlUser = new Panel();
            tbxUser = new TextBox();
            pbxUser = new PictureBox();
            lblLogin = new Label();
            btnClose = new Button();
            lblPoweredByValue = new Label();
            lblPoweredBy = new Label();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            pnlMain.SuspendLayout();
            pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).BeginInit();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(41, 128, 185);
            pnlLeft.Controls.Add(lblLicenceTo);
            pnlLeft.Controls.Add(lblAppNameDetail);
            pnlLeft.Controls.Add(lblAppName);
            pnlLeft.Controls.Add(pbxLogo);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(400, 600);
            pnlLeft.TabIndex = 0;
            // 
            // lblLicenceTo
            // 
            lblLicenceTo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenceTo.ForeColor = Color.Silver;
            lblLicenceTo.Location = new Point(10, 570);
            lblLicenceTo.Name = "lblLicenceTo";
            lblLicenceTo.Size = new Size(380, 20);
            lblLicenceTo.TabIndex = 3;
            lblLicenceTo.Text = "ESP Notice 3.0 licence to ESP India Pvt. Ltd.";
            lblLicenceTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppNameDetail
            // 
            lblAppNameDetail.Font = new Font("Segoe UI", 13.8F);
            lblAppNameDetail.ForeColor = Color.White;
            lblAppNameDetail.Location = new Point(3, 237);
            lblAppNameDetail.Name = "lblAppNameDetail";
            lblAppNameDetail.Size = new Size(265, 127);
            lblAppNameDetail.TabIndex = 2;
            lblAppNameDetail.Text = "Welcome to the\r\nNotice Management\r\nSystem 3.0";
            lblAppNameDetail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.Silver;
            lblAppName.Location = new Point(120, 122);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(148, 30);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "ESP Notice 3.0";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.esp_logo;
            pbxLogo.Location = new Point(120, 50);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(148, 71);
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Controls.Add(btnLogin);
            pnlMain.Controls.Add(pnlPassword);
            pnlMain.Controls.Add(pnlUser);
            pnlMain.Controls.Add(lblLogin);
            pnlMain.Controls.Add(btnClose);
            pnlMain.Controls.Add(lblPoweredByValue);
            pnlMain.Controls.Add(lblPoweredBy);
            pnlMain.Location = new Point(400, 5);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(595, 589);
            pnlMain.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(12, 400);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = SystemColors.Control;
            pnlPassword.Controls.Add(tbxPassword);
            pnlPassword.Controls.Add(pbxPassword);
            pnlPassword.Location = new Point(0, 299);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(600, 55);
            pnlPassword.TabIndex = 7;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = SystemColors.Control;
            tbxPassword.BorderStyle = BorderStyle.None;
            tbxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(54, 16);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(500, 27);
            tbxPassword.TabIndex = 1;
            tbxPassword.Text = "admin";
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.Click += tbxPassword_Click;
            tbxPassword.Enter += tbxPassword_Click;
            // 
            // pbxPassword
            // 
            pbxPassword.BackgroundImage = Properties.Resources.lock_blue;
            pbxPassword.BackgroundImageLayout = ImageLayout.Center;
            pbxPassword.Location = new Point(12, 12);
            pbxPassword.Name = "pbxPassword";
            pbxPassword.Size = new Size(32, 32);
            pbxPassword.TabIndex = 10;
            pbxPassword.TabStop = false;
            pbxPassword.MouseDown += pbxPassword_MouseDown;
            pbxPassword.MouseUp += pbxPassword_MouseUp;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.White;
            pnlUser.Controls.Add(tbxUser);
            pnlUser.Controls.Add(pbxUser);
            pnlUser.Location = new Point(0, 241);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(595, 55);
            pnlUser.TabIndex = 6;
            // 
            // tbxUser
            // 
            tbxUser.BorderStyle = BorderStyle.None;
            tbxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(55, 16);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(500, 27);
            tbxUser.TabIndex = 0;
            tbxUser.Text = "Admin";
            tbxUser.Click += tbxUser_Click;
            tbxUser.Enter += tbxUser_Click;
            // 
            // pbxUser
            // 
            pbxUser.BackgroundImage = Properties.Resources.user;
            pbxUser.BackgroundImageLayout = ImageLayout.Center;
            pbxUser.Location = new Point(12, 12);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(32, 32);
            pbxUser.TabIndex = 9;
            pbxUser.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(41, 128, 185);
            lblLogin.Location = new Point(6, 188);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(591, 40);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Login to your account";
            lblLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(563, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPoweredByValue
            // 
            lblPoweredByValue.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoweredByValue.ForeColor = Color.Silver;
            lblPoweredByValue.Location = new Point(12, 570);
            lblPoweredByValue.Name = "lblPoweredByValue";
            lblPoweredByValue.Size = new Size(200, 20);
            lblPoweredByValue.TabIndex = 3;
            lblPoweredByValue.Text = "MS SOFTWARE SOLUTIONS";
            lblPoweredByValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPoweredBy
            // 
            lblPoweredBy.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoweredBy.ForeColor = Color.Silver;
            lblPoweredBy.Location = new Point(12, 547);
            lblPoweredBy.Name = "lblPoweredBy";
            lblPoweredBy.Size = new Size(148, 20);
            lblPoweredBy.TabIndex = 2;
            lblPoweredBy.Text = "Powered by";
            lblPoweredBy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 128, 185);
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlMain);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Activated += Login_Activated;
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            pnlMain.ResumeLayout(false);
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).EndInit();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private PictureBox pbxLogo;
        private Panel pnlMain;
        private Label lblAppNameDetail;
        private Label lblAppName;
        private Button btnClose;
        private Label lblPoweredByValue;
        private Label lblPoweredBy;
        private Label lblLogin;
        private Panel pnlPassword;
        private Panel pnlUser;
        private Button btnLogin;
        private PictureBox pbxPassword;
        private TextBox tbxUser;
        private PictureBox pbxUser;
        private TextBox tbxPassword;
        private Label lblLicenceTo;
    }
}

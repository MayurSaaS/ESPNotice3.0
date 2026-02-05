namespace ESPNotice3._0
{
    partial class Home
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
            pnlHeader = new Panel();
            lblLoginDatetime = new Label();
            lblUser = new Label();
            lblAppName = new Label();
            pbxUser = new PictureBox();
            btnClose = new Button();
            pbxLogo = new PictureBox();
            pnlFooter = new Panel();
            lblMessage = new Label();
            mspMain = new MenuStrip();
            mnuDashboard = new ToolStripMenuItem();
            mnuUtilities = new ToolStripMenuItem();
            mnuTransImportTagEdit = new ToolStripMenuItem();
            mnuTransNoticeGeneration = new ToolStripMenuItem();
            mnuTransHistoryTagEditData = new ToolStripMenuItem();
            mnuTransViewTagEditData = new ToolStripMenuItem();
            mnuTransactions = new ToolStripMenuItem();
            mnuUtilitiesCSV = new ToolStripMenuItem();
            mnuUtilitiesSMS = new ToolStripMenuItem();
            mnuMasters = new ToolStripMenuItem();
            mnuProfiles = new ToolStripMenuItem();
            mnuCenters = new ToolStripMenuItem();
            mnuVehicleClasses = new ToolStripMenuItem();
            mnuNoticeFormat = new ToolStripMenuItem();
            mnuInvalidRegnNo = new ToolStripMenuItem();
            mnuLimits = new ToolStripMenuItem();
            mnuVIDData = new ToolStripMenuItem();
            mnuUsers = new ToolStripMenuItem();
            tspSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            pnlFooter.SuspendLayout();
            mspMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblLoginDatetime);
            pnlHeader.Controls.Add(lblUser);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pbxUser);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(pbxLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1325, 71);
            pnlHeader.TabIndex = 7;
            // 
            // lblLoginDatetime
            // 
            lblLoginDatetime.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginDatetime.ForeColor = Color.Silver;
            lblLoginDatetime.Location = new Point(974, 44);
            lblLoginDatetime.Name = "lblLoginDatetime";
            lblLoginDatetime.Size = new Size(280, 20);
            lblLoginDatetime.TabIndex = 14;
            lblLoginDatetime.Text = "17-Nov-2024 20:47";
            lblLoginDatetime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.Silver;
            lblUser.Location = new Point(974, 12);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(280, 32);
            lblUser.TabIndex = 13;
            lblUser.Text = "Administrator";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(41, 128, 185);
            lblAppName.Location = new Point(153, 12);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(756, 40);
            lblAppName.TabIndex = 12;
            lblAppName.Text = "Notice Management System 3.0";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbxUser
            // 
            pbxUser.BackColor = SystemColors.Control;
            pbxUser.BackgroundImage = Properties.Resources.user;
            pbxUser.BackgroundImageLayout = ImageLayout.Center;
            pbxUser.Location = new Point(915, 12);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(52, 52);
            pbxUser.TabIndex = 11;
            pbxUser.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(41, 128, 185);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1265, 12);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(2, 0, 0, 0);
            btnClose.Size = new Size(48, 48);
            btnClose.TabIndex = 10;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.BackgroundImage = Properties.Resources.esp_logo;
            pbxLogo.BackgroundImageLayout = ImageLayout.Center;
            pbxLogo.Location = new Point(0, 0);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(152, 71);
            pbxLogo.TabIndex = 9;
            pbxLogo.TabStop = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(41, 128, 185);
            pnlFooter.BorderStyle = BorderStyle.FixedSingle;
            pnlFooter.Controls.Add(lblMessage);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 744);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1325, 40);
            pnlFooter.TabIndex = 9;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(6, 10);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1312, 20);
            lblMessage.TabIndex = 14;
            lblMessage.Text = "17-Nov-2024 20:47";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mspMain
            // 
            mspMain.AutoSize = false;
            mspMain.BackColor = Color.FromArgb(224, 224, 224);
            mspMain.ImageScalingSize = new Size(32, 32);
            mspMain.Items.AddRange(new ToolStripItem[] { mnuDashboard, mnuUtilities, mnuTransactions, mnuMasters });
            mspMain.Location = new Point(0, 71);
            mspMain.Name = "mspMain";
            mspMain.Padding = new Padding(6, 0, 0, 0);
            mspMain.Size = new Size(1325, 50);
            mspMain.TabIndex = 0;
            mspMain.Text = "menuStrip1";
            // 
            // mnuDashboard
            // 
            mnuDashboard.AutoSize = false;
            mnuDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnuDashboard.ForeColor = Color.FromArgb(41, 128, 185);
            mnuDashboard.Image = Properties.Resources.dashboard_icon;
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(250, 50);
            mnuDashboard.Text = "Dashboard";
            mnuDashboard.Click += mnuDashboard_Click;
            // 
            // mnuUtilities
            // 
            mnuUtilities.AutoSize = false;
            mnuUtilities.DropDownItems.AddRange(new ToolStripItem[] { mnuTransImportTagEdit, mnuTransNoticeGeneration, mnuTransHistoryTagEditData, mnuTransViewTagEditData });
            mnuUtilities.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnuUtilities.ForeColor = Color.FromArgb(41, 128, 185);
            mnuUtilities.Image = Properties.Resources.paperclip_icon;
            mnuUtilities.Name = "mnuUtilities";
            mnuUtilities.Size = new Size(250, 50);
            mnuUtilities.Text = "Transaction(s)";
            mnuUtilities.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mnuTransImportTagEdit
            // 
            mnuTransImportTagEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuTransImportTagEdit.ForeColor = Color.FromArgb(41, 128, 185);
            mnuTransImportTagEdit.Image = Properties.Resources.icons8_import_csv_100_outline;
            mnuTransImportTagEdit.Name = "mnuTransImportTagEdit";
            mnuTransImportTagEdit.ShortcutKeys = Keys.F9;
            mnuTransImportTagEdit.Size = new Size(245, 26);
            mnuTransImportTagEdit.Text = "Import TagEdit";
            mnuTransImportTagEdit.Click += mnuTransImportTagEdit_Click;
            // 
            // mnuTransNoticeGeneration
            // 
            mnuTransNoticeGeneration.Font = new Font("Segoe UI", 9F);
            mnuTransNoticeGeneration.ForeColor = Color.FromArgb(41, 128, 185);
            mnuTransNoticeGeneration.Image = Properties.Resources.icons8_secured_file_64;
            mnuTransNoticeGeneration.Name = "mnuTransNoticeGeneration";
            mnuTransNoticeGeneration.ShortcutKeys = Keys.F10;
            mnuTransNoticeGeneration.Size = new Size(245, 26);
            mnuTransNoticeGeneration.Text = "Notice Generation";
            mnuTransNoticeGeneration.Click += mnuTransNoticeGeneration_Click;
            // 
            // mnuTransHistoryTagEditData
            // 
            mnuTransHistoryTagEditData.Font = new Font("Segoe UI", 9F);
            mnuTransHistoryTagEditData.ForeColor = Color.FromArgb(41, 128, 185);
            mnuTransHistoryTagEditData.Image = Properties.Resources.icons8_activity_history_80;
            mnuTransHistoryTagEditData.Name = "mnuTransHistoryTagEditData";
            mnuTransHistoryTagEditData.Size = new Size(245, 26);
            mnuTransHistoryTagEditData.Text = "History TagEdit Data";
            mnuTransHistoryTagEditData.Click += mnuTransHistoryTagEditData_Click;
            // 
            // mnuTransViewTagEditData
            // 
            mnuTransViewTagEditData.Font = new Font("Segoe UI", 9F);
            mnuTransViewTagEditData.ForeColor = Color.FromArgb(41, 128, 185);
            mnuTransViewTagEditData.Image = Properties.Resources.icons8_view_64;
            mnuTransViewTagEditData.Name = "mnuTransViewTagEditData";
            mnuTransViewTagEditData.Size = new Size(245, 26);
            mnuTransViewTagEditData.Text = "View TagEdit Data";
            mnuTransViewTagEditData.Click += mnuTransViewTagEditData_Click;
            // 
            // mnuTransactions
            // 
            mnuTransactions.AutoSize = false;
            mnuTransactions.DropDownItems.AddRange(new ToolStripItem[] { mnuUtilitiesCSV, mnuUtilitiesSMS });
            mnuTransactions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnuTransactions.ForeColor = Color.FromArgb(41, 128, 185);
            mnuTransactions.Image = Properties.Resources.compass_north_icon;
            mnuTransactions.Name = "mnuTransactions";
            mnuTransactions.Size = new Size(250, 50);
            mnuTransactions.Text = "Utilities";
            mnuTransactions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mnuUtilitiesCSV
            // 
            mnuUtilitiesCSV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuUtilitiesCSV.ForeColor = Color.FromArgb(41, 128, 185);
            mnuUtilitiesCSV.Image = Properties.Resources.icons8_csv_100;
            mnuUtilitiesCSV.Name = "mnuUtilitiesCSV";
            mnuUtilitiesCSV.Size = new Size(121, 26);
            mnuUtilitiesCSV.Text = "CSV";
            // 
            // mnuUtilitiesSMS
            // 
            mnuUtilitiesSMS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuUtilitiesSMS.ForeColor = Color.FromArgb(41, 128, 185);
            mnuUtilitiesSMS.Image = Properties.Resources.icons8_sms_100;
            mnuUtilitiesSMS.Name = "mnuUtilitiesSMS";
            mnuUtilitiesSMS.Size = new Size(121, 26);
            mnuUtilitiesSMS.Text = "SMS";
            // 
            // mnuMasters
            // 
            mnuMasters.AutoSize = false;
            mnuMasters.DropDownItems.AddRange(new ToolStripItem[] { mnuProfiles, mnuCenters, mnuVehicleClasses, mnuNoticeFormat, mnuInvalidRegnNo, mnuLimits, mnuVIDData, mnuUsers, tspSeparator1, exitToolStripMenuItem });
            mnuMasters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnuMasters.ForeColor = Color.FromArgb(41, 128, 185);
            mnuMasters.Image = Properties.Resources.compass_south_icon;
            mnuMasters.Name = "mnuMasters";
            mnuMasters.Size = new Size(250, 50);
            mnuMasters.Text = "Masters";
            mnuMasters.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mnuProfiles
            // 
            mnuProfiles.AutoSize = false;
            mnuProfiles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuProfiles.ForeColor = Color.FromArgb(41, 128, 185);
            mnuProfiles.Image = Properties.Resources.profile_icon;
            mnuProfiles.Name = "mnuProfiles";
            mnuProfiles.ShortcutKeys = Keys.F1;
            mnuProfiles.Size = new Size(250, 38);
            mnuProfiles.Text = "Profile";
            mnuProfiles.Click += mnuProfiles_Click;
            // 
            // mnuCenters
            // 
            mnuCenters.AutoSize = false;
            mnuCenters.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuCenters.ForeColor = Color.FromArgb(41, 128, 185);
            mnuCenters.Image = Properties.Resources.target_icon;
            mnuCenters.Name = "mnuCenters";
            mnuCenters.ShortcutKeys = Keys.F2;
            mnuCenters.Size = new Size(250, 38);
            mnuCenters.Text = "Centers";
            mnuCenters.Click += mnuCenters_Click;
            // 
            // mnuVehicleClasses
            // 
            mnuVehicleClasses.AutoSize = false;
            mnuVehicleClasses.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuVehicleClasses.ForeColor = Color.FromArgb(41, 128, 185);
            mnuVehicleClasses.Image = Properties.Resources.auto_car_icon;
            mnuVehicleClasses.Name = "mnuVehicleClasses";
            mnuVehicleClasses.ShortcutKeys = Keys.F3;
            mnuVehicleClasses.Size = new Size(250, 38);
            mnuVehicleClasses.Text = "Vehicle Classes";
            mnuVehicleClasses.Click += mnuVehicleClasses_Click;
            // 
            // mnuNoticeFormat
            // 
            mnuNoticeFormat.AutoSize = false;
            mnuNoticeFormat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuNoticeFormat.ForeColor = Color.FromArgb(41, 128, 185);
            mnuNoticeFormat.Image = Properties.Resources.file_gear_icon;
            mnuNoticeFormat.Name = "mnuNoticeFormat";
            mnuNoticeFormat.ShortcutKeys = Keys.F4;
            mnuNoticeFormat.Size = new Size(250, 38);
            mnuNoticeFormat.Text = "Notice Format";
            mnuNoticeFormat.Click += mnuNoticeFormat_Click;
            // 
            // mnuInvalidRegnNo
            // 
            mnuInvalidRegnNo.AutoSize = false;
            mnuInvalidRegnNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuInvalidRegnNo.ForeColor = Color.FromArgb(41, 128, 185);
            mnuInvalidRegnNo.Image = Properties.Resources.credit_card_debit_icon;
            mnuInvalidRegnNo.Name = "mnuInvalidRegnNo";
            mnuInvalidRegnNo.ShortcutKeys = Keys.F5;
            mnuInvalidRegnNo.Size = new Size(250, 38);
            mnuInvalidRegnNo.Text = "Invalid Regn. No";
            mnuInvalidRegnNo.Click += mnuInvalidRegnNo_Click;
            // 
            // mnuLimits
            // 
            mnuLimits.AutoSize = false;
            mnuLimits.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuLimits.ForeColor = Color.FromArgb(41, 128, 185);
            mnuLimits.Image = Properties.Resources.settings_icon;
            mnuLimits.Name = "mnuLimits";
            mnuLimits.ShortcutKeys = Keys.F6;
            mnuLimits.Size = new Size(250, 38);
            mnuLimits.Text = "Limits";
            mnuLimits.Click += mnuLimits_Click;
            // 
            // mnuVIDData
            // 
            mnuVIDData.AutoSize = false;
            mnuVIDData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuVIDData.ForeColor = Color.FromArgb(41, 128, 185);
            mnuVIDData.Image = Properties.Resources.show;
            mnuVIDData.Name = "mnuVIDData";
            mnuVIDData.ShortcutKeys = Keys.F7;
            mnuVIDData.Size = new Size(250, 38);
            mnuVIDData.Text = "VID Data";
            mnuVIDData.Click += mnuVIDData_Click;
            // 
            // mnuUsers
            // 
            mnuUsers.AutoSize = false;
            mnuUsers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuUsers.ForeColor = Color.FromArgb(41, 128, 185);
            mnuUsers.Image = Properties.Resources.user_interface_icon;
            mnuUsers.Name = "mnuUsers";
            mnuUsers.ShortcutKeys = Keys.F8;
            mnuUsers.Size = new Size(250, 38);
            mnuUsers.Text = "Users";
            mnuUsers.Click += mnuUsers_Click;
            // 
            // tspSeparator1
            // 
            tspSeparator1.Name = "tspSeparator1";
            tspSeparator1.Size = new Size(222, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.AutoSize = false;
            exitToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.ForeColor = Color.FromArgb(41, 128, 185);
            exitToolStripMenuItem.Image = Properties.Resources.exit;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "Esc";
            exitToolStripMenuItem.Size = new Size(250, 38);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 784);
            ControlBox = false;
            Controls.Add(mspMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            KeyPreview = true;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            KeyDown += Home_KeyDown;
            Resize += Home_Resize;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            pnlFooter.ResumeLayout(false);
            mspMain.ResumeLayout(false);
            mspMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pbxUser;
        private Button btnClose;
        private PictureBox pbxLogo;
        private TabControl tabControlHome;
        private TabPage tabDashboard;
        private TabPage tabNoticeProcess;
        private TabPage tabReports;
        private TabPage tabMasters;
        private Label lblAppName;
        private Label lblUser;
        private Label lblLoginDatetime;
        private Panel pnlFooter;
        private Label lblMessage;
        private Panel panel1;
        private Label lblHeader;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Button button7;
        private Button button8;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private Panel panel3;
        private Button button5;
        private Button button6;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button4;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button2;
        private MenuStrip mspMain;
        private ToolStripMenuItem mnuMasters;
        private ToolStripMenuItem mnuCenters;
        private ToolStripMenuItem mnuVehicleClasses;
        private ToolStripMenuItem mnuNoticeFormat;
        private ToolStripMenuItem mnuInvalidRegnNo;
        private ToolStripMenuItem mnuProfiles;
        private ToolStripMenuItem mnuLimits;
        private ToolStripMenuItem mnuVIDData;
        private ToolStripMenuItem mnuUsers;
        private ToolStripSeparator tspSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuTransactions;
        private ToolStripMenuItem mnuUtilities;
        private ToolStripMenuItem mnuTransImportTagEdit;
        private ToolStripMenuItem mnuTransNoticeGeneration;
        private ToolStripMenuItem mnuTransHistoryTagEditData;
        private ToolStripMenuItem mnuTransViewTagEditData;
        private ToolStripMenuItem mnuUtilitiesCSV;
        private ToolStripMenuItem mnuUtilitiesSMS;
    }
}
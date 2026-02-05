using ESPNotice3._0.Forms;

namespace ESPNotice3._0
{
    public partial class Home : Form
    {
        string sMsgExitConfirmation = "Are you sure you want to exit from application?";
        public Home()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(sMsgExitConfirmation, Program.sMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = screenHeight;// - 70;
            this.Width = screenWidth;

            btnClose.Left = pnlHeader.Width - (btnClose.Width + 12);
            lblUser.Left = btnClose.Left - (lblUser.Width + 12);
            lblLoginDatetime.Left = lblUser.Left;
            pbxUser.Left = lblUser.Left - (pbxUser.Width + 12);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblLoginDatetime.Text = DateTime.Now.ToString("dd-MMM-yy HH:mm");
            lblMessage.Text = lblLoginDatetime.Text;
            lblUser.Text = Program.sUserName;
            lblAppName.Text = $"Notice Management System 3.0 ({Program.sStateName + " - " + Program.dRelaxed.ToString().Replace(".00","") + "%"})";
            mnuDashboard_Click(sender, e);
        }

        private void mnuProfiles_Click(object sender, EventArgs e)
        {
            frmProfile _frmProfile = frmProfile.Instance();
            _frmProfile.MdiParent = this;
            _frmProfile.Show();
            _frmProfile.Activate();
        }

        private void mnuCenters_Click(object sender, EventArgs e)
        {
            frmCenters _frmCenters = frmCenters.Instance();
            _frmCenters.MdiParent = this;
            _frmCenters.Show();
            _frmCenters.Activate();
        }

        private void mnuVehicleClasses_Click(object sender, EventArgs e)
        {
            frmVehicleClasses _frmVehicleClasses = frmVehicleClasses.Instance();
            _frmVehicleClasses.MdiParent = this;
            _frmVehicleClasses.Show();
            _frmVehicleClasses.Activate();
        }
        private void mnuNoticeFormat_Click(object sender, EventArgs e)
        {
            frmNoticeFormat _frmNoticeFormat = frmNoticeFormat.Instance();
            _frmNoticeFormat.MdiParent = this;
            _frmNoticeFormat.Show();
            _frmNoticeFormat.Activate();
        }
        private void mnuInvalidRegnNo_Click(object sender, EventArgs e)
        {
            frmInvalidRegnNo _frmInvalidRegnNo = frmInvalidRegnNo.Instance();
            _frmInvalidRegnNo.MdiParent = this;
            _frmInvalidRegnNo.Show();
            _frmInvalidRegnNo.Activate();
        }
        private void mnuLimits_Click(object sender, EventArgs e)
        {
            frmLimits _frmLimits = frmLimits.Instance();
            _frmLimits.MdiParent = this;
            _frmLimits.Show();
            _frmLimits.Activate();
        }
        private void mnuVIDData_Click(object sender, EventArgs e)
        {
            frmVIDData _frmVIDData = frmVIDData.Instance();
            _frmVIDData.MdiParent = this;
            _frmVIDData.Show();
            _frmVIDData.Activate();
        }
        private void mnuUsers_Click(object sender, EventArgs e)
        {
            frmUsers _frmUsers = frmUsers.Instance();
            _frmUsers.MdiParent = this;
            _frmUsers.Show();
            _frmUsers.Activate();
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    btnClose_Click(sender, e);
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void mnuDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard _frmDashboard = frmDashboard.Instance();
            _frmDashboard.MdiParent = this;
            _frmDashboard.Show();
            _frmDashboard.Activate();
        }

        private void mnuTransNoticeGeneration_Click(object sender, EventArgs e)
        {
            frmNoticeGeneration _frmNoticeGeneration = frmNoticeGeneration.Instance();
            _frmNoticeGeneration.MdiParent = this;
            _frmNoticeGeneration.Show();
            _frmNoticeGeneration.Activate();
        }

        private void mnuTransImportTagEdit_Click(object sender, EventArgs e)
        {
            frmImportTagEdit _frmImportTagEdit = frmImportTagEdit.Instance();
            _frmImportTagEdit.MdiParent = this;
            _frmImportTagEdit.Show();
            _frmImportTagEdit.Activate();
        }

        private void mnuTransHistoryTagEditData_Click(object sender, EventArgs e)
        {
            frmHistoryTagEditData _frmHistoryTagEditData = frmHistoryTagEditData.Instance();
            _frmHistoryTagEditData.MdiParent = this;
            _frmHistoryTagEditData.Show();
            _frmHistoryTagEditData.Activate();

        }

        private void mnuTransViewTagEditData_Click(object sender, EventArgs e)
        {
            frmViewTagEditData _frmViewTagEditData = frmViewTagEditData.Instance();
            _frmViewTagEditData.MdiParent = this;
            _frmViewTagEditData.Show();
            _frmViewTagEditData.Activate();
        }
    }//Class
}//Namespace

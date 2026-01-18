using ESPNotice3._0.Classes;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ESPNotice3._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void Login_Load(object sender, EventArgs e)
        {
            LoadStates();
        }
        public void Login_Activated(object sender, EventArgs e)
        {
            tbxUser.Focus();
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl.Name == tbxPassword.Name)
                {
                    btnLogin_Click(sender, e);
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = false;
        }
        private void pbxPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = true;
        }
        private void tbxUser_Click(object sender, EventArgs e)
        {
            tbxUser.BackColor = Color.White;
            pnlUser.BackColor = Color.White;
            tbxPassword.BackColor = SystemColors.Control;
            pnlPassword.BackColor = SystemColors.Control;
            cmbState.BackColor = SystemColors.Control;
            pnlState.BackColor = SystemColors.Control;
        }
        private void tbxPassword_Click(object sender, EventArgs e)
        {
            tbxPassword.BackColor = Color.White;
            pnlPassword.BackColor = Color.White;
            tbxUser.BackColor = SystemColors.Control;
            pnlUser.BackColor = SystemColors.Control;
            cmbState.BackColor = SystemColors.Control;
            pnlState.BackColor = SystemColors.Control;
        }
        private void cmbState_Click(object sender, EventArgs e)
        {
            cmbState.BackColor = Color.White; 
            pnlState.BackColor = Color.White;
            tbxUser.BackColor = SystemColors.Control;
            pnlUser.BackColor = SystemColors.Control;
            tbxPassword.BackColor = SystemColors.Control;
            pnlPassword.BackColor = SystemColors.Control;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(cmbState.SelectedIndex == 0)
            {
                MessageBox.Show("Please select state", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbState.Focus();
                return;
            }
            if (Program.bdemo & Program.demoDate <= DateTime.Today)
            {
                MessageBox.Show("Demo expired", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.ExitThread();
            }
            //else if (!IsValid_LicenseKey(FingerPrint.Value()))
            //{
            //    if (MessageBox.Show("Invalid license key found, Do you want to register your license key?", Program.sMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
            //        LicenseRegistration obj = new LicenseRegistration();
            //        obj.ShowDialog();
            //    }
            //    else
            //    {
            //        Application.ExitThread();
            //    }
            //}
            else
            {
                if (checkLogin())
                {
                    Program.sStateCode = cmbState.SelectedValue.ToString();
                    Program.sStateName = cmbState.Text;
                    Program.bLogin = true;
                    this.Hide();
                    Program.IsBindEvent = true;
                    Home obj = new Home();
                    obj.ShowDialog();
                }
                else
                    Program.bLogin = false;
            }
        }
        private bool checkLogin()
        {
            bool bResult = false;
            string sUserName = String.Empty;
            try
            {
                //DataTable dt = DBAccess.GetDataTable("SELECT UM.Code, UM.Name, UM.UserID, UM.UserType, CD.Control_Type AS UserTypeName, UM.RoleCode, RM.Name As RoleName FROM UserMaster UM LEFT OUTER JOIN ControlDetailMaster CD ON CD.Control_ID = UM.UserType LEFT OUTER JOIN RoleMaster RM ON RM.Code = UM.RoleCode WHERE UM.UserID = '" + tbxUser.Text + "' AND UM.Password = dbo.UDF_EncodePassword('" + tbxPassword.Text + "')");
                DataTable dt = DBAccess.GetDataTable("SELECT Code, Name, UserType, LoginID FROM Users WHERE LoginID = '" + tbxUser.Text + "' AND Password = '" + tbxPassword.Text + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["Name"] != DBNull.Value)
                        {
                            sUserName = dt.Rows[0]["Name"].ToString() ?? string.Empty;

                            Program.iUserCode = Convert.ToInt32(dt.Rows[0]["Code"]);
                            Program.sUserName = dt.Rows[0]["Name"].ToString() ?? string.Empty;
                            //Program.iRoleCode = Convert.ToInt32(dt.Rows[0]["RoleCode"]);
                            //Program.sRoleName = dt.Rows[0]["RoleName"].ToString() ?? string.Empty;
                        }
                    }
                }
                sUserName = tbxUser.Text;

                if (String.IsNullOrEmpty(sUserName))
                {
                    MessageBox.Show("User Name or Password is incorrect", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bResult = false;
                    tbxPassword.Focus();
                }
                else
                {
                    bResult = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("checkLogin(): " + ex.Message, Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bResult;
        }
        private void LoadStates()
        {
            DataTable dt = DBAccess.GetSelectByQuery("SELECT StateCode, StateName FROM StateMaster WHERE Active = 1 ORDER BY StateName");

            // Create placeholder row
            DataRow dr = dt.NewRow();
            dr["StateCode"] = 0;
            dr["StateName"] = "-- Select State --";

            // Insert at top
            dt.Rows.InsertAt(dr, 0);

            cmbState.DataSource = dt;
            cmbState.DisplayMember = "StateName";
            cmbState.ValueMember = "StateCode";
            cmbState.SelectedIndex = 0;
            //Program.sStateCode = dt.Rows[0]["StateCode"].ToString();
            //Program.sStateName = dt.Rows[0]["StateName"].ToString();
             
        }

    }
}

using ESPNotice3._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPNotice3._0.Forms
{
    public partial class frmLockingCSV : frmBase
    {
        public frmLockingCSV()
        {
            InitializeComponent();
        }

        private void frmLockingCSV_Load(object sender, EventArgs e)
        {
            this.lblFormTitle.Text = this.Text;
            LoadRTODropdown();
        }

        private void dtpLockingFromDate_ValueChanged(object sender, EventArgs e)
        {
            this.strLockingFromDate = dtpLockingFromDate.Value.ToString("dd-MMM-yyyy");
        }

        private void dtpLockingToDate_ValueChanged(object sender, EventArgs e)
        {
            this.strLockingToDate = dtpLockingToDate.Value.ToString("dd-MMM-yyyy");
        }
        private void LoadRTODropdown()
        {
            string sql = "SELECT Code, Name FROM RTOGroups ";

            //string sql = $"SELECT DISTINCT CenterCode,CenterName FROM CSV WHERE StateCode = '{Program.sStateCode}' ";
            DataTable dt = DBAccess.GetSelectByQuery(sql);

            cbxListRTO.DataSource = dt;
            cbxListRTO.DisplayMember = "Name";
            cbxListRTO.ValueMember = "Code";
            cbxListRTO.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxListRTO.SelectedIndex >= 0)
                this.strRTOCode = Convert.ToString(cbxListRTO.SelectedValue);
            else
            {
                MessageBox.Show(
                            "Please select RTO",
                            Program.sMsgTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                return;
            }
        }
    }
}

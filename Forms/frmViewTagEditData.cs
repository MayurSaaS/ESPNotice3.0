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
    public partial class frmViewTagEditData : frmBase
    {
        public frmViewTagEditData()
        {
            InitializeComponent();
        }

        private void frmViewTagEditData_Load(object sender, EventArgs e)
        {
            this.lblFormTitle.Text = this.Text;
            tabControl.TabPages.RemoveByKey("tabFormView");
            btnDelete.Visible = true;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            dtpCSVFileDate.Value = DateTime.Now;
            this.strCSVFileDate = dtpCSVFileDate.Value.ToString("dd-MMM-yyyy");
        }

        private void dtpCSVFileDate_ValueChanged(object sender, EventArgs e)
        {
            string fromDate = dtpCSVFileDate.Value.ToString("yyyy-MM-dd");
            this.strCSVFileDate = dtpCSVFileDate.Value.ToString("dd-MMM-yyyy");
            string strQry = "SELECT CM.CenterCode AS Code,  CM.CenterName + '  -  (' + CM.Centercode +')' + ' - (' + CONVERT(VARCHAR(10),COUNT(CSV.CenterCode)) + ')' AS CenterName FROM CenterMaster CM\r\nLEFT OUTER JOIN CSV ON CSV.CenterCode = CM.CenterCode\r\nWHERE CSV.vdfDateTime = '" + fromDate + "'\r\nGROUP BY CM.CenterCode, CM.CenterName";
            DBAccess.FillDropDownList(strQry, "Code", "CenterName", cbxCenterName);
            this.strCenterCode = string.Empty;
            if (cbxCenterName.SelectedValue != null)
                this.strCenterCode = cbxCenterName.SelectedValue.ToString();
        }

        private void frmViewTagEditData_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.strCenterCode = string.Empty;
            btnDelete.Visible = false;
        }
    }//Class
}//Namespace
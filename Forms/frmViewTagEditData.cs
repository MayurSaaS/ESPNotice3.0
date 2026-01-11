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
            btnNew.Visible = false;
            btnEdit.Visible = false;
            dtpCSVFileDate.Value = DateTime.Now;
            this.strCSVFileDate = dtpCSVFileDate.Value.ToString("dd-MMM-yyyy");
        }

        private void dtpCSVFileDate_ValueChanged(object sender, EventArgs e)
        {
            this.strCSVFileDate = dtpCSVFileDate.Value.ToString("dd-MMM-yyyy");
        }
    }//Class
}//Namespace
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
    public partial class frmHistoryTagEditData : frmBase
    {
        public frmHistoryTagEditData()
        {
            InitializeComponent();
        }

        private void frmNoticeGeneration_Load(object sender, EventArgs e)
        {
            this.lblFormTitle.Text = this.Text;
        }

        private void dtpFromCSVFileDate_ValueChanged(object sender, EventArgs e)
        {
            this.strFromCSVFileDate = dtpFromCSVFileDate.Value.ToString("dd-MMM-yyyy");
        }

        private void dtpToCSVFileDate_ValueChanged(object sender, EventArgs e)
        {
            this.strToCSVFileDate = dtpToCSVFileDate.Value.ToString("dd-MMM-yyyy");
        }
    }//Class
}//Namespace
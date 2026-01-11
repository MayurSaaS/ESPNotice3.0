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
    public partial class frmLimits : frmBase
    {
        public frmLimits()
        {
            InitializeComponent();
        }
        private void frmLimits_Load(object sender, EventArgs e)
        {
            //pro_LoadGrid();
        }

        //private void pro_LoadGrid()
        //{
        //    DataTable dt = DBAccess.GetDataTable("Select * from Limits");
        //    dgvGrid.DataSource = dt;
        //    dgvGrid.Columns[0].Visible = false;
        //}


    }//Class
}//Namespace
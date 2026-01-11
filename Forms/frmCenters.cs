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
    public partial class frmCenters : frmBase
    {
        //string strTableName = "CenterMaster";
        //string strMsgSave = "The record has been saved successfully.";
        //string strMsgUpdate = "The record has been updated successfully.";
        //string strMsgDelete = "The record has been deleted successfully.";
        //public string[] ctrls = { "CenterCode*", "CenterName*" };

        //int iCode = 0;
        //bool IsEdit = true;

        public frmCenters()
        {
            InitializeComponent();
        }

        private void frmCenters_Load(object sender, EventArgs e)
        {
            //pro_LoadGrid();
            //pro_LoadFormControls();
        }

        //private void pro_LoadGrid()
        //{
        //    DataTable dt = DBAccess.GetDataTable("SELECT * FROM " + strTableName);
        //    dgvGrid.DataSource = dt;
        //    dgvGrid.Columns[0].Visible = false;
        //    dgvGrid.DoubleClick += dgvGrid_DoubleClick;
        //    dgvGrid.KeyDown += dgvGrid_KeyDown;
        //}
        //private void pro_LoadFormControls()
        //{

        //    int intRow = 1;
        //    int intCol = 1;
        //    int intTabValue = 0;

        //    foreach (string ctrl in ctrls)
        //    {
        //        Label lbl = (Label)this.Controls.Find("lbl" + ctrl.Replace("*", ""), true)[0];
        //        TextBox tbx = (TextBox)this.Controls.Find("tbx" + ctrl.Replace("*", ""), true)[0];

        //        if (intCol == 1)
        //        {
        //            if (ctrl.Contains("*"))
        //            {
        //                Label lblStar = new Label();
        //                lblStar.Name = "lblStar" + ctrl.Replace("*", "");
        //                lblStar.Left = PDST - 10;
        //                lblStar.Top = RowSize * intRow; ;
        //                lblStar.Width = 10;
        //                lblStar.Text = "*";
        //                lblStar.ForeColor = Color.Red;
        //                lblStar.Visible = true;
        //                grbFormView.Controls.Add(lblStar);
        //            }
        //            lbl.Left = PDST;
        //            lbl.Top = RowSize * intRow;
        //            lbl.Width = CL1;

        //            tbx.Left = PDST + CL1;
        //            tbx.Top = RowSize * intRow;
        //            tbx.Width = CT1;
        //            tbx.TabIndex = intTabValue;
        //        }
        //        else if (intCol == 2)
        //        {
        //            if (ctrl.Contains("*"))
        //            {
        //                Label lblStar = new Label();
        //                lblStar.Name = "lblStar" + ctrl.Replace("*", "");
        //                lblStar.Left = PDST + CL1 + CT1 + PDMD - 10;
        //                lblStar.Top = RowSize * intRow; ;
        //                lblStar.Width = 10;
        //                lblStar.Text = "*";
        //                lblStar.ForeColor = Color.Red;
        //                lblStar.Visible = true;
        //                grbFormView.Controls.Add(lblStar);
        //            }
        //            lbl.Left = PDST + CL1 + CT1 + PDMD;
        //            lbl.Top = RowSize * intRow;
        //            lbl.Width = CL2;

        //            tbx.Left = PDST + CL1 + CT1 + PDMD + CL2;
        //            tbx.Top = RowSize * intRow;
        //            tbx.Width = CT2;
        //            tbx.TabIndex = intTabValue;
        //        }
        //        intTabValue++;
        //        intCol++;
        //        if (intCol > 2) { intCol = 1; intRow++; }
        //    }


        //}
        //private void clearControl()
        //{
        //    if (iCode == 0)
        //    {
        //        foreach (Control ctrl in grbFormView.Controls)
        //        {
        //            if (ctrl.Name.StartsWith("tbx"))
        //            {
        //                ctrl.Text = "";
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (Control ctrl in grbFormView.Controls)
        //        {
        //            if (ctrl.Name.StartsWith("tbx"))
        //            {
        //                ctrl.Text = dgvGrid.SelectedRows[0].Cells[ctrl.Name.Replace("tbx", "")].Value.ToString();
        //            }
        //        }
        //    }
        //}

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            //if (tabControl.SelectedIndex == 0) { iCode = 0; }
            //clearControl();
            //if (iCode > 0)
            //{ btnSave.Text = "Update"; btnSave.Enabled = true; }
            //else { btnSave.Text = "Save"; btnSave.Enabled = false; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (dgvGrid.SelectedRows.Count > 0)
            //{
            //    IsEdit = true;
            //    iCode = Convert.ToInt32(dgvGrid.SelectedRows[0].Cells["Code"].Value);

            //    foreach (Control ctrl in grbFormView.Controls)
            //    {
            //        if (ctrl.Name.StartsWith("tbx"))
            //        {
            //            ctrl.Text = dgvGrid.SelectedRows[0].Cells[ctrl.Name.Replace("tbx", "")].Value.ToString();
            //        }
            //    }

            //    tabControl.SelectTab(1);
            //    tbxCenterCode.Focus();
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //if (btnSave.Text == "Update")
            //{
            //    string strQry = "UPDATE " + strTableName + " SET ";

            //    if (iCode <= 0)
            //    {
            //        MessageBox.Show("Please select record for edit", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    foreach (Control ctrl in grbFormView.Controls)
            //    {
            //        if (ctrl.Visible)
            //        {
            //            if (ctrl.Name.StartsWith("tbx"))
            //            {
            //                string s = ctrl.Name.Replace("tbx", "") + " = '" + ctrl.Text + "'";
            //                strQry += s + ", ";
            //            }
            //        }
            //    }
            //    strQry = strQry.Substring(0, strQry.Length - 2);
            //    strQry += " WHERE Code = " + iCode.ToString();
            //    try
            //    {
            //        DBAccess.ExecuteQuery(strQry);
            //        MessageBox.Show("The record has been updated successfully.", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        pro_LoadGrid();
            //        dgvGrid.Focus();
            //        tabControl.SelectTab(0);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error found:" + ex.ToString(), Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //clearControl();
        }
        private void dgvGrid_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) { btnEdit_Click(sender, e); }
        }
        private void dgvGrid_DoubleClick(object sender, EventArgs e)
        {
            //btnEdit_Click(sender, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmCenters_KeyDown(object sender, KeyEventArgs e)
        {
            //if (tabControl.SelectedIndex == 0)
            //{
            //    if (e.Control & e.KeyCode == Keys.E)
            //    {
            //        btnEdit_Click(sender, e);
            //    }
            //    else if (e.Alt & e.KeyCode == Keys.F)
            //    {
            //        btnSearch_Click(sender, e);
            //    }
            //}
            //else if (tabControl.SelectedIndex == 1)
            //{
            //    if (e.Control & e.KeyCode == Keys.S)
            //    {
            //        btnSave_Click(sender, e);
            //    }
            //    else if (e.Control & e.KeyCode == Keys.U)
            //    {
            //        btnSave_Click(sender, e);
            //    }
            //    else if (e.Alt & e.KeyCode == Keys.C)
            //    {
            //        btnCancel_Click(sender, e);
            //    }
            //}

            //if (e.Control & e.KeyCode == Keys.L)
            //{
            //    tabControl.SelectedIndex = 0;
            //}
            //else if (e.Control & e.KeyCode == Keys.N)
            //{
            //    tabControl.SelectedIndex = 1;
            //}


        }

        
    }//Class
}//Namespace

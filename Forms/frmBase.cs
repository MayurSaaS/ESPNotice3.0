using ESPNotice3._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPNotice3._0.Forms
{
    public partial class frmBase : Form
    {
        #region Declaration of Design Parameters
        public static int PDSize = 200;
        public static int RowSize = 50;
        public int PDST = PDSize;
        public int CL1 = 0;
        public int CL2 = 0;
        public int PDMD = PDSize * 2;
        public int CT1 = 0;
        public int CT2 = 0;
        public int PDLT = PDSize;

        #endregion

        #region Declaration of MessageBox's messages

        string sMsgCloseFormConfirmation = "Are you sure you want to close this form?";
        string strMsgSave = "The record has been saved successfully.";
        string strMsgUpdate = "The record has been updated successfully.";
        string strMsgDelete = "The record has been deleted successfully.";

        #endregion

        #region Declaration of Form's Parameters

        int iCode = 0;
        bool IsEdit = false;

        string strTableName = "";
        public string strCSVFileDate = "";
        public string strFromCSVFileDate = "";
        public string strToCSVFileDate = "";

        public string[] ctrls = { };
        public string[] Profile_ctrls = { "CompanyName*", "ContactName", "PhoneNumber", "FaxNumber", "EmailAddress", "Website", "Address", "Pincode" };
        public string[] Centers_ctrls = { "CenterCode*", "CenterName*" };
        public string[] InvalidRegnNo_ctrls = { "REGN_NO" };
        public string[] Limits_ctrls = { "Wheels*", "Fuel*", "Compliance", "Model", "minCO", "minHC", "minSmoke" };
        public string[] NoticeFormat_ctrls = { "FormatName*", "LHeader", "CHeader", "RHeader", "Title", "InspectionCenter", "Notice" };
        public string[] Users_ctrls = { "Name*", "UserType", "LoginID", "Password" };
        public string[] VehicleClasses_ctrls = { "CLASS_CD*", "CL_DESC", "CLASS_TYPE", "TRANSPORT_CATG", "Wheels" };
        public string[] VIDData_ctrls = { "REGN_NO*", "REGN_DT", "O_NAME", "F_NAME", "MANU_YR", "ADD1", "ADD2", "CITY", "PINCODE", "PADD1", "PADD2", "PCITY", "PPINCODE", "MAKER_MODEL", "VEHCLASS", "FUELNAME", "MNAME", "NORMSNAME", "REGN_DATE", "VEH_CATG", "MOBILE_NO" };
        //public string[] ImportTagEditData_ctrls = { "Id*", "ProcessDateTime*", "date*", "CenterName*", "CenterCode*", "TotalRecord*", "ValidGas*", "IsValidForReport*", "Notices*" };
        //public string[] ImportTagEditData_ctrls = { "CSVFileDate*", "CenterName*", "CenterCode*", "Delimeter*", "CSVFilePath*", "IsValidForReport*", "Notices*" };
        public string[] HistoryTagEditData_ctrls = { "Id*", "ProcessDateTime*", "date*", "CenterName*", "CenterCode*", "TotalRecord*", "ValidGas*", "IsValidForReport*", "Notices*" };
        public string[] ViewTagEditData_ctrls = { "ID*", "Code*", "CenterCode*", "CenterName*", "vdfRecordNumber*", "vdfUnit*", "vdfDateTime*", "vdfTime*", "vdfRecordStatus*", "vdfValid*", "samSpeed*", "samAccel*", "samFlag*", "perCO*", "perCO2*", "ppmHC*", "ppmNO*", "uvSmoke*", "COCO2*", "HCCO2*", "NOCO2*", "maxCO2*", "avgCO2*", "samples*", "vdfTempAlarms*", "vdfAmbientAlarms*", "vdfMiscAlarms*", "pcVersion*", "sdmVersion*", "calfactorCO*", "calfactorCO2*", "calfactorHC*", "calfactorNO*", "calDate*", "calTime*", "V_PLATE*", "V_PLATE_1*", "V_STATE_1*", "temp*", "baro*" };




        #endregion 

        public frmBase()
        {
            InitializeComponent();
            if (Program.IsBindEvent)
                pro_BindEvents();
        }

        #region Form's Events

        private void frmBase_Load(object sender, EventArgs e)
        {
            if (this.Name == "frmCenters")
            {
                strTableName = "CenterMaster";
                ctrls = Centers_ctrls;
            }
            else if (this.Name == "frmInvalidRegnNo")
            {
                strTableName = "Invalid_PlateNo";
                ctrls = InvalidRegnNo_ctrls;
            }
            else if (this.Name == "frmLimits")
            {
                strTableName = "Limits";
                ctrls = Limits_ctrls;
            }
            else if (this.Name == "frmNoticeFormat")
            {
                strTableName = "NoticeFormat";
                ctrls = NoticeFormat_ctrls;
            }
            else if (this.Name == "frmProfile")
            {
                strTableName = "BusinessProfile";
                ctrls = Profile_ctrls;
            }
            else if (this.Name == "frmUsers")
            {
                strTableName = "Users";
                ctrls = Users_ctrls;
            }
            else if (this.Name == "frmVehicleClasses")
            {
                strTableName = "VHCLASS";
                ctrls = VehicleClasses_ctrls;
            }
            else if (this.Name == "frmVIDData")
            {
                strTableName = "VID";
                ctrls = VIDData_ctrls;
            }
            else if (this.Name == "frmImportTagEdit")
            {
                strTableName = "TotalVGasMaster";
                ctrls = null;// ImportTagEditData_ctrls;
            }
            else if (this.Name == "frmHistoryTagEditData")
            {
                strTableName = "TotalVGasMaster";
                ctrls = HistoryTagEditData_ctrls;
                if (string.IsNullOrEmpty(strFromCSVFileDate))
                    strFromCSVFileDate = DateTime.Now.ToString("dd-MMM-yyyy");
                if (string.IsNullOrEmpty(strToCSVFileDate))
                    strToCSVFileDate = DateTime.Now.ToString("dd-MMM-yyyy");
            }
            else if (this.Name == "frmViewTagEditData")
            {
                strTableName = "CSV";
                ctrls = ViewTagEditData_ctrls;
                if (string.IsNullOrEmpty(strCSVFileDate))
                    strCSVFileDate = DateTime.Now.ToString("dd-MMM-yyyy");
            }
            else if (this.Name == "frmNoticeGeneration")
            {
                strTableName = "NoticeData";
                ctrls = VIDData_ctrls;
            }

            pro_LoadGrid();
            pro_LoadFormControls();
        }
        private void frmBase_Resize(object sender, EventArgs e)
        {
            pro_LoadDesign();
        }
        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(sender, e);
            }
        }

        #endregion

        #region Button's Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            IsEdit = false;
            tabControl.SelectTab(1);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Save")
            {
                string strQry = string.Empty;
                string strCols = string.Empty;
                string strColValues = string.Empty;
                try
                {
                    foreach (Control ctrl in grbFormView.Controls)
                    {
                        if (ctrl.Visible)
                        {
                            if (ctrl.Name.StartsWith("tbx"))
                            {
                                string s = ctrl.Name.Replace("tbx", "");
                                strCols += s + ", ";
                            }
                            if (ctrl.Name.StartsWith("tbx"))
                            {
                                string s = "'" + ctrl.Text + "'";
                                strColValues += s + ", ";
                            }
                        }
                    }
                    strCols = strCols.Substring(0, strCols.Length - 2);
                    strColValues = strColValues.Substring(0, strColValues.Length - 2);
                    strQry = "INSERT INTO " + strTableName + "(" + strCols + ")" + " VALUES " + "(" + strColValues + ")";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error-Query:" + ex.ToString(), Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    DBAccess.ExecuteQuery(strQry);
                    MessageBox.Show(strMsgSave, Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //tbxCompanyName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error-Execution:" + ex.ToString(), Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (btnSave.Text == "&Update")
            {
                string strQry = string.Empty;
                try
                {
                    strQry = "UPDATE " + strTableName + " SET ";

                    if (iCode <= 0)
                    {
                        MessageBox.Show("Please select record for edit", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    foreach (Control ctrl in grbFormView.Controls)
                    {
                        if (ctrl.Visible)
                        {
                            if (ctrl.Name.StartsWith("tbx"))
                            {
                                string s = ctrl.Name.Replace("tbx", "") + " = '" + ctrl.Text + "'";
                                strQry += s + ", ";
                            }
                        }
                    }
                    strQry = strQry.Substring(0, strQry.Length - 2);
                    strQry += " WHERE Code = " + iCode.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error-Query:" + ex.ToString(), Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    DBAccess.ExecuteQuery(strQry);
                    MessageBox.Show(strMsgUpdate, Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pro_LoadGrid();
                    dgvGrid.Focus();
                    tabControl.SelectTab(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error-Execution:" + ex.ToString(), Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGrid.SelectedRows.Count > 0)
            {
                IsEdit = true;

                if(dgvGrid.Columns["Code"] != null)
                    iCode = Convert.ToInt32(dgvGrid.SelectedRows[0].Cells["Code"].Value);
                else if (dgvGrid.Columns["ID"] != null)
                    iCode = Convert.ToInt32(dgvGrid.SelectedRows[0].Cells["ID"].Value);


                foreach (Control ctrl in grbFormView.Controls)
                {
                    if (ctrl.Name.StartsWith("tbx"))
                    {
                        ctrl.Text = dgvGrid.SelectedRows[0].Cells[ctrl.Name.Replace("tbx", "")].Value.ToString();
                        if (this.Controls.Find("lblStar" + ctrl.Name.Replace("tbx", ""), true).Length > 0)
                        {
                            if (this.Controls.Find("lblStar" + ctrl.Name.Replace("tbx", ""), true)[0].Text == "*")
                                ctrl.Enabled = false;
                            else
                                ctrl.Enabled = true;
                        }
                    }
                }

                tabControl.SelectTab(1);
                //tbxCompanyName.Focus();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pro_ClearControl();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(sMsgCloseFormConfirmation, Program.sMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pro_LoadGrid();
        }

        #endregion

        #region TabControl's Event
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedIndex == 0) { iCode = 0; }
            pro_ClearControl();
            if (iCode > 0)
            { btnSave.Text = "&Update"; btnSave.Enabled = true; }
            else { btnSave.Text = "&Save"; btnSave.Enabled = false; }
        }

        #endregion

        #region Grid's Events
        private void dgvGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnEdit_Click(sender, e); }
        }
        private void dgvGrid_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        #endregion

        #region Procedures
        private void pro_BindEvents()
        {
            tabControl.Selected += tabControl_Selected;
            btnNew.Click += btnNew_Click;
            btnEdit.Click += btnEdit_Click;
            dgvGrid.DoubleClick += dgvGrid_DoubleClick;
            dgvGrid.KeyDown += dgvGrid_KeyDown;
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
            btnClose.Click += btnClose_Click;
            Load += frmBase_Load;
            KeyDown += frmBase_KeyDown;
            Resize += frmBase_Resize;
        }
        private void pro_ClearControl()
        {
            if (iCode == 0)
            {
                foreach (Control ctrl in grbFormView.Controls)
                {
                    if (ctrl.Name.StartsWith("tbx"))
                    {
                        ctrl.Text = "";
                    }
                }
            }
            else
            {
                foreach (Control ctrl in grbFormView.Controls)
                {
                    if (ctrl.Name.StartsWith("tbx"))
                    {
                        ctrl.Text = dgvGrid.SelectedRows[0].Cells[ctrl.Name.Replace("tbx", "")].Value.ToString();
                    }
                }
            }
        }
        private void pro_LoadGrid()
        {
            string sQry = string.Empty;
            if (this.Name == "frmVIDData" || this.Name == "frmImportTagEdit" || this.Name == "frmNoticeGeneration")
                sQry = "SELECT TOP 20 * FROM " + strTableName;
            else if (this.Name == "frmHistoryTagEditData")
            {
                if(!string.IsNullOrWhiteSpace(tbxSearch.Text))
                {
                    sQry = "SELECT * FROM " + strTableName + " WHERE date BETWEEN '" + strFromCSVFileDate + "' AND '" + strToCSVFileDate + "'" + " AND (CenterName = '" + tbxSearch.Text + "' OR CenterCode = '" + tbxSearch.Text + "')";
                }
                else
                {
                    sQry = "SELECT * FROM " + strTableName + " WHERE date BETWEEN '" + strFromCSVFileDate + "' AND '" + strToCSVFileDate + "'";
                }
            }
                
            else if (this.Name == "frmViewTagEditData")
                sQry = "SELECT * FROM " + strTableName + " WHERE vdfDateTime = '" + strCSVFileDate + "'";
            else
                sQry = "SELECT * FROM " + strTableName;

            DataTable dt = DBAccess.GetDataTable(sQry);
            if (this.Controls.Find("dgvGrid", true).Length != 0 && this.Controls.Find("dgvGrid", true)[0].Visible)
            {
                dgvGrid.DataSource = dt;
                if (dgvGrid.Columns.Count > 0)
                    dgvGrid.Columns[0].Visible = false;
            }

        }
        public void pro_LoadDesign()
        {
            if (this.ParentForm == null) return;
            //this.Size = this.ParentForm.ClientSize;
            this.Width = this.ParentForm.Width - 5;
            this.Height = this.ParentForm.Height - 165;

            this.Location = new Point(0, 0);

            lblFormTitle.Text = this.Text;

            tabControl.Width = this.Size.Width - 12;
            tabControl.Height = this.Size.Height - (pnlHeader.Height + 12);
            tabControl.Left = 6;
            tabControl.Top = pnlHeader.Height + 6;
            pnlHeader.Width = tabControl.Width;

            btnClose.Left = pnlHeader.Width - btnClose.Width;

            grbGridView.Width = tabControl.Width - 18;
            grbGridView.Height = tabControl.Height - 50;
            grbGridView.Left = 6;
            grbGridView.Top = 0;



            pnlSearch.Width = tabControl.Width - 60;
            pnlSearch.Left = 30;
            pnlSearch.Top = 25;

            btnSearch.Left = pnlSearch.Width - (btnSearch.Width);

            dgvGrid.Width = pnlSearch.Width;
            dgvGrid.Height = grbGridView.Height - (pnlSearch.Top + pnlSearch.Height + pnlGrid.Height + 12);
            dgvGrid.Left = pnlSearch.Left;
            dgvGrid.Top = pnlSearch.Top + pnlSearch.Height + 6;

            pnlGrid.Width = pnlSearch.Width;
            pnlGrid.Left = pnlSearch.Left;
            pnlGrid.Top = dgvGrid.Top + dgvGrid.Height;// + 6;

            btnEdit.Left = pnlGrid.Width - (btnEdit.Width);
            btnNew.Left = pnlGrid.Width - (btnNew.Width + btnEdit.Width + btnEdit.Top);


            grbFormView.Width = tabControl.Width - 28;

            grbFormView.Height = tabControl.Height - (pnlSave.Height + 70);
            grbFormView.Left = 10;
            grbFormView.Top = 4;

            pnlSave.Width = grbFormView.Width;
            pnlSave.Left = grbFormView.Left;
            pnlSave.Top = grbFormView.Top + grbFormView.Height + 10;

            btnSave.Left = grbFormView.Width - (btnSave.Width);
            btnCancel.Left = grbFormView.Width - (btnCancel.Width + btnSave.Width + btnSave.Top);

            int ColSize = (grbFormView.Width - (PDSize * 4)) / 2;
            int CLSize = Convert.ToInt32(ColSize * 0.4);
            int CTSize = ColSize - CLSize;

            CL1 = CLSize;
            CL2 = CLSize;
            CT1 = CTSize;
            CT2 = CTSize;

        }
        private void pro_LoadFormControls()
        {
            if (ctrls == null) return;
            int intRow = 1;
            int intCol = 1;
            int intTabValue = 0;

            foreach (string ctrl in ctrls)
            {
                if (this.Controls.Find("lbl" + ctrl.Replace("*", ""), true).Length > 0)
                {
                    Label lbl = (Label)this.Controls.Find("lbl" + ctrl.Replace("*", ""), true)[0];
                    TextBox tbx = (TextBox)this.Controls.Find("tbx" + ctrl.Replace("*", ""), true)[0];
                    if (tbx.Name.Contains("Password"))
                        tbx.PasswordChar = '*';

                    if (intCol == 1)
                    {
                        if (ctrl.Contains("*"))
                        {
                            Label lblStar = new Label();
                            lblStar.Name = "lblStar" + ctrl.Replace("*", "");
                            lblStar.Left = PDST - 10;
                            lblStar.Top = RowSize * intRow; ;
                            lblStar.Width = 10;
                            lblStar.Text = "*";
                            lblStar.ForeColor = Color.Red;
                            lblStar.Visible = true;
                            grbFormView.Controls.Add(lblStar);
                        }
                        lbl.Left = PDST;
                        lbl.Top = RowSize * intRow;
                        lbl.Width = CL1;

                        tbx.Left = PDST + CL1;
                        tbx.Top = RowSize * intRow;
                        tbx.Width = CT1;
                        tbx.TabIndex = intTabValue;
                    }
                    else if (intCol == 2)
                    {
                        if (ctrl.Contains("*"))
                        {
                            Label lblStar = new Label();
                            lblStar.Name = "lblStar" + ctrl.Replace("*", "");
                            lblStar.Left = PDST + CL1 + CT1 + PDMD - 10;
                            lblStar.Top = RowSize * intRow; ;
                            lblStar.Width = 10;
                            lblStar.Text = "*";
                            lblStar.ForeColor = Color.Red;
                            lblStar.Visible = true;
                            grbFormView.Controls.Add(lblStar);
                        }
                        lbl.Left = PDST + CL1 + CT1 + PDMD;
                        lbl.Top = RowSize * intRow;
                        lbl.Width = CL2;

                        tbx.Left = PDST + CL1 + CT1 + PDMD + CL2;
                        tbx.Top = RowSize * intRow;
                        tbx.Width = CT2;
                        tbx.TabIndex = intTabValue;
                    }
                    intTabValue++;
                    intCol++;
                    if (intCol > 2) { intCol = 1; intRow++; }
                }
            }


        }

        #endregion



        
    }//Class
}//Namespace

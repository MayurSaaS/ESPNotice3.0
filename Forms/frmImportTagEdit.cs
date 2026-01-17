using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESPNotice3._0.Classes;

namespace ESPNotice3._0.Forms
{
    public partial class frmImportTagEdit : frmBase
    {
        public frmImportTagEdit()
        {
            InitializeComponent();
            this.tabControl.Visible = false;
        }

        private void frmImportTagEdit_Load(object sender, EventArgs e)
        {
            this.lblFormTitle.Text = this.Text;

            pnlMain.Size = tabControl.Size;
            pnlMain.Location = tabControl.Location;

            pro_LoadCSVControls();

            tbxCSVFilePath.Text = Application.StartupPath + "\\";
            dtpCSVFile.Value = DateTime.Now;
            cbxDelimeter.SelectedIndex = 0;

            DBAccess.FillDropDownList("CenterMaster", "Code", "CenterName + '  -  (' + Centercode +')'", cbxCenterName, "");
        }

        private void pro_LoadCSVControls()
        {
            dgvCSV.Width = pnlMain.Width - 40;
            dgvCSV.Height = pnlMain.Height - 140;

            dgvCSV.Left = 20;
            dgvCSV.Top = 120;

            btnImportCSVFile.Left = pnlMain.Width - btnImportCSVFile.Width - 20;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath + "\\CSV Files";
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = ".csv";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            this.tbxCSVFilePath.Text = fileName;
            this.lblDeviceID.Text = "";
            
            if (!(fileName == ""))
            {
                ReadVdfUnitFromCsv(fileName);
                return;
            }
                
            MessageBox.Show("Please select CSV File.", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            
        }

        private void btnImportCSVFile_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnImportCSVFile.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                string str1 = "";
                if (this.cbxCenterName.SelectedValue == DBNull.Value)
                {
                    int num3 = (int)MessageBox.Show(AppConstant.strBlankValidation + "Center Name", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.cbxCenterName.Focus();
                }
                else if (Convert.ToInt32(this.cbxCenterName.SelectedValue) <= 0)
                {
                    int num3 = (int)MessageBox.Show(AppConstant.strBlankValidation + "Center Name", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.cbxCenterName.Focus();
                }
                else if (this.lblCenterCode.Text.Trim() == "")
                {
                    int num3 = (int)MessageBox.Show(AppConstant.strBlankValidation + "Center Code\r\nPlease re-select Center Name", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.cbxCenterName.SelectedIndex = 0;
                    this.lblCenterCode.Focus();
                }
                else if (this.tbxCSVFilePath.Text.Trim() == "")
                {
                    int num3 = (int)MessageBox.Show(AppConstant.strBlankValidation + "CSV File Path", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.tbxCSVFilePath.Focus();
                }
                else
                {
                    string sQuery = "select Count(ID) from csv where CenterCode = '" + this.lblCenterCode.Text.Trim() + "' and Convert(varchar(15),vdfDateTime,106) = '" + this.dtpCSVFile.Value.ToString("dd MMM yyyy") + "'";
                    DataTable selectByQuery1 = DBAccess.GetSelectByQuery(sQuery);
                    if (selectByQuery1 != null && selectByQuery1.Rows.Count > 0 && Convert.ToInt32(selectByQuery1.Rows[0][0].ToString()) > 0 && MessageBox.Show("Record(s) found for the " + this.dtpCSVFile.Value.ToString("dd-MMM-yyyy") + "\r\nDo you want to continue?", Program.sMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                    {
                        this.dtpCSVFile.Focus();
                    }
                    else
                    {
                        //this.proNotice.Visible = true;
                        //this.proNotice.Maximum = 100;
                        //int num3 = 0;
                        //string str2 = "";
                        //string str3 = "";
                        //try
                        //{
                        //    num3 = Convert.ToInt32(this.cbxCenterName.SelectedValue);
                        //}
                        //catch
                        //{
                        //}
                        //try
                        //{
                        //    str3 = this.cbxCenterName.Text;
                        //}
                        //catch
                        //{
                        //}
                        //try
                        //{
                        //    str2 = this.lblCenterCode.Text;
                        //}
                        //catch
                        //{
                        //}
                        string path = this.tbxCSVFilePath.Text.Trim();
                        string inputDeli = ",";
                        if (this.cbxDelimeter.Text.Trim() != "")
                            inputDeli = this.cbxDelimeter.Text.Trim();
                        DataTable csvFileVbs = ParseCSVFile_VBS(path, inputDeli);
                        DataRow[] dataRowArray = csvFileVbs.Select("vdfValid = 'V'");
                        //num2 = csvFileVbs.Rows.Count;
                        //this.proNotice.Maximum = dataRowArray.Length + 5;
                        //this.proNotice.Value = 5;
                        int columnIndex1 = 0;
                        string strDeviceID = string.Empty;
                        string str4 = "";
                        for (int index = 0; index < csvFileVbs.Columns.Count; ++index)
                        {
                            if (csvFileVbs.Columns[index].ColumnName == "vdfValid")
                                columnIndex1 = index;
                            str4 = !(str4.Trim() == "") ? str4 + ", [" + csvFileVbs.Columns[index].ColumnName + "]" : "[" + csvFileVbs.Columns[index].ColumnName + "]";
                        }
                        string str5 = path.Replace(".csv", "_log.txt");
                        StreamWriter streamWriter = new StreamWriter(str5, false);
                        streamWriter.WriteLine("Following records are not inserted in CSV Data");
                        //num1 = 0;
                        for (int index = 0; index < csvFileVbs.Rows.Count; ++index)
                        {
                            if (csvFileVbs.Rows[index][columnIndex1].ToString().ToUpper() == "V")
                            {
                                /*++num1;
                                ++this.proNotice.Value;*/
                                string str6 = "";
                                strDeviceID = csvFileVbs.Rows[index]["vdfUnit"].ToString();
                                for (int columnIndex2 = 0; columnIndex2 < csvFileVbs.Columns.Count; ++columnIndex2)
                                    str6 = !(str6.Trim() == "") ? str6 + ", '" + csvFileVbs.Rows[index][columnIndex2].ToString() + "'" : "'" + csvFileVbs.Rows[index][columnIndex2].ToString() + "'";
                                str1 = "";
                                string strQuery = "set dateformat 'ymd' Insert into CSV (Code, CenterCode, CenterName, DeviceID, " + str4 + ") Values('" + Convert.ToInt32(this.cbxCenterName.SelectedValue) + "', '" + lblCenterCode.Text + "', '" + cbxCenterName.Text + "', '" + lblDeviceID.Text + "', " + str6 + ")";
                                try
                                {
                                    DBAccess.GetSelectByQuery(strQuery);
                                }
                                catch (Exception ex)
                                {
                                    streamWriter.WriteLine(str6);
                                }
                            }
                            //this.lblNoofRecords.Text = num1.ToString() + " Out Of " + num2.ToString();
                            Application.DoEvents();
                        }
                        string str7 = "";
                        DataTable selectByQuery2 = DBAccess.GetSelectByQuery("SELECT CenterName from CenterMaster where CenterCode='" + this.lblCenterCode.Text.Trim() + "'");
                        if (selectByQuery2.Rows.Count > 0)
                            str7 = selectByQuery2.Rows[0]["CenterName"].ToString();
                        try
                        {
                            DataRow dr = DBAccess.GetSelectByQuery("SELECT [ProcessDateTime], [date], [DeviceID], [CenterName], [CenterCode], [TotalRecord], [ValidGas], IsValidForReport, Notices FROM [dbo].[TotalVGasMaster] where 1=2").NewRow();
                            dr["ProcessDateTime"] = (object)DateTime.Now;
                            dr["date"] = (object)this.dtpCSVFile.Value.Date;
                            dr["DeviceID"] = strDeviceID;
                            dr["CenterName"] = (object)str7;
                            dr["CenterCode"] = (object)this.lblCenterCode.Text.Trim();
                            dr["TotalRecord"] = (object)csvFileVbs.Rows.Count;
                            dr["ValidGas"] = (object)dataRowArray.Length;
                            dr["IsValidForReport"] = (object)true;
                            dr["Notices"] = dataRowArray.Length;
                            string sQry = "INSERT INTO TotalVGasMaster Values(" + "'" + Convert.ToDateTime(dr["ProcessDateTime"]).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Convert.ToDateTime(dr["date"]).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + dr["DeviceID"] + "', '" + dr["CenterName"] + "', '" + dr["CenterCode"] + "', '" + dr["TotalRecord"] + "', '" + dr["ValidGas"] + "', '" + dr["IsValidForReport"] + "', '" + dr["Notices"] + "')";
                            DBAccess.ExecuteQuery(sQry);
                        }
                        catch (Exception ex)
                        {
                            streamWriter.WriteLine(ex.ToString());
                        }
                        streamWriter.Close();
                        /*this.lblNoofRecords.Text = num1.ToString() + " Out Of " + num2.ToString();
                        this.proNotice.Visible = false;
                        this.proNotice.Value = 0;
                        this.proNotice.Maximum = 100;*/
                        dgvCSV.DataSource = (object)csvFileVbs;
                        if (MessageBox.Show("The CSV file has been imported successfully.", Program.sMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            Process.Start("notepad.exe", str5);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                this.btnImportCSVFile.Enabled = true;
                this.Cursor = Cursors.Default;
                /*this.lblNoofRecords.Text = num1.ToString() + " Out Of " + num2.ToString();
                this.proNotice.Visible = false;
                this.proNotice.Value = 0;
                this.proNotice.Maximum = 100;*/
            }
        }
        public DataTable ParseCSVFile_VBS(string path, string inputDeli)
        {
            string inputString = "";
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                inputString = streamReader.ReadToEnd();
                streamReader.Close();
            }
            return this.ParseCSV_VBS(inputString, inputDeli);
        }
        public DataTable ParseCSV_VBS(string inputString, string inputDeli)
        {
            DataTable dataTable = new DataTable();
            string[] separator1 = new string[3];
            string[] separator2 = new string[1];
            separator1[0] = "\r\n";
            separator1[1] = "\n";
            separator1[2] = "\r";
            separator2[0] = inputDeli;
            string[] strArray1 = inputString.Split(separator1, StringSplitOptions.RemoveEmptyEntries);
            DataRow row = dataTable.NewRow();
            for (int index = 0; index < strArray1.Length; ++index)
            {
                string[] strArray2 = strArray1[index].Split(separator2, StringSplitOptions.None);
                for (int columnIndex = 0; columnIndex < strArray2.Length; ++columnIndex)
                {
                    if (index == 0)
                    {
                        string columnName = strArray2[columnIndex];
                        dataTable.Columns.Add(columnName);
                    }
                    else
                    {
                        if (columnIndex == 0)
                            row = dataTable.NewRow();
                        if (columnIndex < dataTable.Columns.Count)
                            row[columnIndex] = (object)strArray2[columnIndex];
                    }
                    if (columnIndex == strArray2.Length - 1 && index != 0)
                        dataTable.Rows.Add(row);
                }
            }
            if (dataTable.Columns.Count == 0)
                dataTable.Columns.Add("NoData");
            return dataTable;
        }
        private void cbxCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(this.cbxCenterName.Text.Trim() != ""))
                    return;
                if (this.cbxCenterName.Text.Trim() == "--Select--")
                {
                    this.lblCenterCode.Text = "";
                }
                else
                {
                    this.lblCenterCode.Text = "";
                    DataTable dataTable = DBAccess.SelectTable("Code= " + this.cbxCenterName.SelectedValue, "Code, CenterCode, CenterName", "CenterMaster", "Code");
                    if (dataTable != null && dataTable.Rows.Count > 0)
                        this.lblCenterCode.Text = dataTable.Rows[0]["CenterCode"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ReadVdfUnitFromCsv(string filePath)
        {
            string delimiter = ",";   
            using (var reader = new StreamReader(filePath))
            {
                // Header read
                string headerLine = reader.ReadLine();
                if (string.IsNullOrEmpty(headerLine))
                    return;

                string[] headers = headerLine.Split(delimiter.ToCharArray());
                
                int vdfUnitIndex = Array.FindIndex(headers,
                    h => h.Trim().Equals("vdfUnit", StringComparison.OrdinalIgnoreCase));

                if (vdfUnitIndex == -1)
                {
                    MessageBox.Show("vdfUnit column not found in CSV");
                    return;
                }
                
                string dataLine = reader.ReadLine();
                if (string.IsNullOrEmpty(dataLine))
                    return;

                string[] data = dataLine.Split(delimiter.ToCharArray());

                if (data.Length > vdfUnitIndex)
                {
                    string vdfUnitValue = data[vdfUnitIndex];

                    lblDeviceID.Text = $"{vdfUnitValue}";
                    lblDeviceID.Visible = true;
                }
            }
        }


    }//Class
}//Namespace
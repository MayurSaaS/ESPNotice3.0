using ESPNotice3._0.Classes;
using ESPNotice3._0.DataSet;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ESPNotice3._0.Forms
{
    public partial class frmNoticeGeneration : frmBase
    {
        private string GetInputFilePath()
        {
            string sInputFilesPath = Properties.Settings.Default.InputFilesPath.ToUpper();
            if (!sInputFilesPath.EndsWith("\\")) { sInputFilesPath = sInputFilesPath + "\\"; }

            sInputFilesPath = sInputFilesPath.Replace("{STATE}", Program.sStateCode);
            sInputFilesPath = sInputFilesPath.Replace("{YEAR}", dtpCSVDate.Value.Year.ToString());
            sInputFilesPath = sInputFilesPath.Replace("{MONTH}", dtpCSVDate.Value.Month.ToString().PadLeft(2, '0'));
            sInputFilesPath = sInputFilesPath.Replace("{DATE}", dtpCSVDate.Value.ToString("yyyy-MM-dd"));
            sInputFilesPath = sInputFilesPath.Replace("{CSVORPICS}", "Pics");

            return sInputFilesPath;
        }

        private string GetOutputFilePath()
        {
            string sOutputFilesPath = Properties.Settings.Default.OutputFilesPath.ToUpper();
            if (!sOutputFilesPath.EndsWith("\\")) { sOutputFilesPath = sOutputFilesPath + "\\"; }

            sOutputFilesPath = sOutputFilesPath.Replace("{STATE}", Program.sStateCode);
            sOutputFilesPath = sOutputFilesPath.Replace("{YEAR}", dtpCSVDate.Value.Year.ToString());
            sOutputFilesPath = sOutputFilesPath.Replace("{MONTH}", dtpCSVDate.Value.Month.ToString().PadLeft(2, '0'));

            return sOutputFilesPath;
        }
        protected override string SelectedCenterName
        {
            get
            {
                return cbxListCenter.SelectedIndex > -1 ? Convert.ToString(cbxListCenter.SelectedValue) : string.Empty;
            }
        }
        public frmNoticeGeneration()
        {
            InitializeComponent();
           
            
        }

        private void frmNoticeGeneration_Load(object sender, EventArgs e)
        {
            string InputFilesPath = GetInputFilePath();

            string OutputFilesPath = Properties.Settings.Default.OutputFilesPath;
            if (!OutputFilesPath.EndsWith("\\")) { OutputFilesPath = OutputFilesPath + "\\"; }

            this.lblFormTitle.Text = this.Text;
            tbxInputFilePath.Text = InputFilesPath;
            tabControl.SelectedIndex = 1;
            grbNoticeView.Width = grbGridView.Width;
            grbNoticeView.Height = grbGridView.Height;
            reportViewer1.Width = grbGridView.Width - (reportViewer1.Left*2);
            reportViewer1.Height = grbGridView.Height - (reportViewer1.Top+10 );
            LoadCenterDropdown();
            LoadCenterRptParaDropdown();
            //DBAccess.FillDropDownList("CenterMaster", "Code", "CenterName + '  -  (' + Centercode +')'", cbxCenterName, "");
            string fromDate = dtpCSVDate.Value.ToString("yyyy-MM-dd"); 
            string strQry = "SELECT CM.CenterCode AS Code,  CM.CenterName + '  -  (' + CM.Centercode +')' + ' - (' + CONVERT(VARCHAR(10),COUNT(CSV.CenterCode)) + ')' AS CenterName FROM CenterMaster CM\r\nLEFT OUTER JOIN CSV ON CSV.CenterCode = CM.CenterCode\r\nWHERE CSV.vdfDateTime = '" + fromDate + "'\r\nGROUP BY CM.CenterCode, CM.CenterName";
            DBAccess.FillDropDownList(strQry, "Code", "CenterName", cbxCenterName);
            
        }
        private void dtpCSVDate_ValueChanged(object sender, EventArgs e)
        {
            string InputFilesPath = GetInputFilePath();
            string fromDate = dtpCSVDate.Value.ToString("yyyy-MM-dd");

            //string query = $"SELECT DISTINCT Code, CenterCode, CenterName FROM CSV WHERE vdfDateTime >= '{fromDate}' and vdfDateTime <= '{fromDate}'";
            //DataTable dt = DBAccess.GetSelectByQuery(query);

            //cbxCenterName.DataSource = dt;
            //cbxCenterName.DisplayMember = "CenterName";
            //cbxCenterName.ValueMember = "CenterCode";
            cbxCenterName.DataSource = null;
            string strQry = "SELECT CM.CenterCode AS Code,  CM.CenterName + '  -  (' + CM.Centercode +')' + ' - (' + CONVERT(VARCHAR(10),COUNT(CSV.CenterCode)) + ')' AS CenterName FROM CenterMaster CM\r\nLEFT OUTER JOIN CSV ON CSV.CenterCode = CM.CenterCode\r\nWHERE CSV.vdfDateTime = '" + fromDate + "'\r\nGROUP BY CM.CenterCode, CM.CenterName";
            DBAccess.FillDropDownList(strQry, "Code", "CenterName", cbxCenterName);
            tbxInputFilePath.Text = InputFilesPath;
        }
        private void cbxCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCenterName.SelectedValue !=null)
            tbxCenterCode.Text = cbxCenterName.SelectedValue.ToString();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string InputFilesPath = GetInputFilePath();
            folderBrowserDialog1.InitialDirectory = InputFilesPath;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                tbxInputFilePath.Text = "";
                tbxInputFilePath.Text = folderBrowserDialog1.SelectedPath.ToString();
                // count = GetFileCount(tbxInputFilePath.Text);
                //Program.InputFilePath = tbxInputFilePath.Text;
                //if(!Directory.Exists(Application.StartupPath + "\\Logs"))
                //    Directory.CreateDirectory(Application.StartupPath + "\\Logs");

                //string sCenterCode = tbxCenterCode.Text;
                //string sDevice = tbxCenterCode.Text;
                //string sDate = dtpCSVDate.Value.ToString("yyyy-MM-dd");
                //string sFilename = "Logs_" + sDate + sCenterCode + sDevice + ".txt";
                //StreamWriter sw = File.CreateText(Application.StartupPath + "\\Logs\\"+ sFilename);
                //sw.WriteLine(tbxInputFilePath.Text);
                //sw.Flush();
                //sw.Close();
                //sw.Dispose();
            }

        }
        
        private void cbxListCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListCenter.SelectedIndex == -1) return;
            string centerName = cbxListCenter.Text.ToString();
        }

        private void btnProcessNotices_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxCenterName.Text)) { MessageBox.Show("Please select center", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrEmpty(tbxCenterCode.Text)) { MessageBox.Show("Please select center code", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!Directory.Exists(tbxInputFilePath.Text))
            {
                MessageBox.Show("Please select valid path", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Notice Generation code
            if (DBAccess.ExecuteQuery("EXEC GetNoticeGenerate '" + dtpCSVDate.Value.ToString("yyyy-MM-dd") + "', '" + Program.sStateCode + "', '" + tbxCenterCode.Text + "'"))
            {
                string fromDate = dtpCSVDate.Value.ToString("yyyy-MM-dd");
                string toDate = fromDate;
                string centerName = GetCenterCodeName(Convert.ToString(cbxCenterName.SelectedValue));
                btnProcessNotices.Enabled = false;
                GenerateNotices(fromDate, toDate, centerName);
                btnProcessNotices.Enabled = true;
                MessageBox.Show("Notices has been generated successfully!", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Notices generation has been failed!", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //if (cbxPDFFiles.Items.Count > 0)
            //{
            //    cbxPDFFiles.Enabled = true;
            //    btnOpenPDF.Enabled = true;
            //}
            //else
            //{
            //    cbxPDFFiles.Enabled = false;
            //    btnOpenPDF.Enabled = false;
            //}
        }


        private void GenerateNotices(string fromDate, string toDate, string centerName)
        {
            string sOutputFilePath = GetOutputFilePath();
            string RTOCode = string.Empty;
            string RTOName = string.Empty;

            //Month wise Notices
            DateTime lastDateOfMonth = new DateTime(dtpCSVDate.Value.Year, dtpCSVDate.Value.Month, DateTime.DaysInMonth(dtpCSVDate.Value.Year, dtpCSVDate.Value.Month));
            string fromDateMonthly = dtpCSVDate.Value.ToString("yyyy-MM-01");
            string toDateMonthly = dtpCSVDate.Value.ToString("yyyy-MM-"+lastDateOfMonth.ToString("dd"));

            //MONTH
            dsNotice dsMonthly = GetDataRTOWise(fromDateMonthly, toDateMonthly, centerName, RTOCode, null, false, false, false);
            if (dsMonthly != null && dsMonthly.Tables.Count > 0)
            {
                string sfileName = Convert.ToDateTime(fromDate).Year.ToString().Substring(2, 2) + Convert.ToDateTime(fromDate).Month.ToString().PadLeft(2, '0') + "_Notices";
                string sfilePath = sOutputFilePath;
                ExportPDF_CSV(dsMonthly, sfilePath, sfileName);
            }

            //DUPLICATE
            dsNotice dsMonthlyDuplicate = GetDataRTOWise(fromDateMonthly, toDateMonthly, centerName, RTOCode, null, false, true, false);
            if (dsMonthlyDuplicate != null && dsMonthlyDuplicate.Tables.Count > 0)
            {
                string sfileName = Convert.ToDateTime(fromDate).Year.ToString().Substring(2, 2) + Convert.ToDateTime(fromDate).Month.ToString().PadLeft(2, '0') + "_Notices";
                string sfilePath = sOutputFilePath + "\\Duplicate\\" ;
                ExportPDF_CSV(dsMonthlyDuplicate, sfilePath, sfileName);
            }

            //OTHER
            dsNotice dsOther = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, null, false, false, true);
            if (dsOther != null && dsOther.Tables.Count > 0)
            {
                string sfileNameDailyOthers = dtpFromDate.Value.ToString("yyMMdd") + "_Notices";
                string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\Others\\" ;
                ExportPDF_CSV(dsOther, sfilePath, sfileNameDailyOthers);
            }

            //Day wise
            dsNotice dsDaily = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, null, false, false, false);
            if (dsDaily != null && dsDaily.Tables.Count > 0)
            {
                string sfileNameDaily = dtpFromDate.Value.ToString("yyMMdd") + "_Notices";
                string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\" ;
                ExportPDF_CSV(dsDaily, sfilePath, sfileNameDaily);
            }

            //Day wise - RTO WISE, COMM, NON-COMM

            DataTable dt = DBAccess.GetDataTable("SELECT * FROM RTOGroups");
            for (int i=0; i<dt.Rows.Count; i++)
            {
                RTOCode = Convert.ToString(dt.Rows[i]["Code"]);
                RTOName = Convert.ToString(dt.Rows[i]["Name"]);

                //RTO WISE
                dsNotice dsDailyRTO = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, null, false, false, false);
                if (dsDailyRTO != null && dsDailyRTO.Tables.Count > 0)
                {
                    string sfileNameDailyRTO = "RTOWise_" + RTOName + "_" + dtpFromDate.Value.ToString("yyMMdd");
                    string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\RTOWise\\" + RTOName + "\\";
                    ExportPDF_CSV(dsDailyRTO, sfilePath, sfileNameDailyRTO);
                }

                ////COMM WISE
                //dsNotice dsDailyRTOComm = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, true, false, false, false);
                //if (dsDailyRTOComm != null && dsDailyRTOComm.Tables.Count > 0)
                //{
                //    string sfileName = "RTOWise_" + RTOName + "_COMM_" + dtpFromDate.Value.ToString("yyMMdd");
                //    string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\RTOWise\\" + RTOName + "\\" ;
                //    ExportPDF_CSV(dsDailyRTOComm, sfilePath, sfileName);
                //}

                ////NON-COMM WISE
                //dsNotice dsDailyRTONonComm = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, false, false, false, false);
                //if (dsDailyRTONonComm != null && dsDailyRTONonComm.Tables.Count > 0)
                //{
                //    string sfileName = "RTOWise_" + RTOName + "_NONCOMM_" + dtpFromDate.Value.ToString("yyMMdd");
                //    string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\RTOWise\\" + RTOName + "\\" ;
                //    ExportPDF_CSV(dsDailyRTONonComm, sfilePath, sfileName);
                //}

                //LESS THAN ONE YEAR - RTO WISE
                dsNotice dsDailyLessThanOneYearRTO = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, null, true, false, false);
                if (dsDailyLessThanOneYearRTO != null && dsDailyLessThanOneYearRTO.Tables.Count > 0)
                {
                    string sfileNameDailyRTO = "RTOWise_" + RTOName + "_LTOY_" + dtpFromDate.Value.ToString("yyMMdd");
                    string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\LessThanOneYear\\RTOWise\\" + RTOName + "\\" ;
                    ExportPDF_CSV(dsDailyLessThanOneYearRTO, sfilePath, sfileNameDailyRTO);
                }

                ////LESS THAN ONE YEAR - COMM WISE
                //dsNotice dsLessThanOneYearRTOComm = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, true, false, false, false);
                //if (dsLessThanOneYearRTOComm != null && dsLessThanOneYearRTOComm.Tables.Count > 0)
                //{
                //    string sfileName = "RTOWise_" + RTOName + "_LTOY_COMM_" + dtpFromDate.Value.ToString("yyMMdd");
                //    string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\LessThanOneYear\\RTOWise\\" + RTOName + "\\" ;
                //    ExportPDF_CSV(dsLessThanOneYearRTOComm, sfilePath, sfileName);
                //}

                ////LESS THAN ONE YEAR - NON-COMM WISE
                //dsNotice dsLessThanOneYearRTONonComm = GetDataRTOWise(fromDate, toDate, centerName, RTOCode, false, false, false, false);
                //if (dsLessThanOneYearRTONonComm != null && dsLessThanOneYearRTONonComm.Tables.Count > 0)
                //{
                //    string sfileName = "RTOWise_" + RTOName + "_LTOY_NONCOMM_" + dtpFromDate.Value.ToString("yyMMdd");
                //    string sfilePath = sOutputFilePath + "\\" + Convert.ToDateTime(fromDate).ToString("dd") + "\\LessThanOneYear\\RTOWise\\" + RTOName + "\\" ;
                //    ExportPDF_CSV(dsLessThanOneYearRTONonComm, sfilePath, sfileName);
                //}
                //DUPLICATE
                dsNotice dsMonthlyDuplicateRTO = GetDataRTOWise(fromDateMonthly, toDateMonthly, centerName, RTOCode, null, false, true, false);
                if (dsMonthlyDuplicateRTO != null && dsMonthlyDuplicateRTO.Tables.Count > 0)
                {
                    string sfileName = Convert.ToDateTime(fromDate).Year.ToString().Substring(2, 2) + Convert.ToDateTime(fromDate).Month.ToString().PadLeft(2, '0') + "_Notices";
                    string sfilePath = sOutputFilePath + "\\Duplicate\\RTOWise\\" + RTOName + "\\";
                    ExportPDF_CSV(dsMonthlyDuplicateRTO, sfilePath, sfileName);
                }

            }

        }//GenerateNotices

        private void ExportPDF_CSV(dsNotice dtSource, string sFilePath, string sfileName)
        {
            DataTable dtExportPDF = dtSource.Tables["Table"];
            DataTable dtExportCSV = dtSource.Tables["Table1"];
            ExportPDF(dtExportPDF, sFilePath + "PDF\\" + sfileName + ".pdf");
            ExportCSV(dtExportCSV, sFilePath + "CSV\\" + sfileName + ".csv");
        }
        private void ExportPDF(DataTable dtSource, string strFilePath)
        {
            if (dtSource == null && dtSource.Rows.Count<=0) { return; }

            LocalReport report = new LocalReport();
            report.ReportPath = Application.StartupPath.Split("bin")[0] + "RDLC\\rptNotices.rdlc";
            report.EnableExternalImages = true;

            ReportDataSource datasource = new ReportDataSource("dt", dtSource);
            report.DataSources.Clear();
            report.DataSources.Add(datasource);
            // Render report to PDF
            byte[] pdfBytes = report.Render(
                "PDF",
                null,
                out string mimeType,
                out string encoding,
                out string fileNameExtension,
                out string[] streams,
                out Warning[] warnings
            );
            string directoryPath = Path.GetDirectoryName(strFilePath);
            Directory.CreateDirectory(directoryPath);

            if (File.Exists(strFilePath))
                File.Delete(strFilePath);
            File.WriteAllBytes(strFilePath, pdfBytes);

        }
        private void ExportCSV(DataTable dtSource, string strFilePath)
        {
            string directoryPath = Path.GetDirectoryName(strFilePath);
            Directory.CreateDirectory(directoryPath);

            if (File.Exists(strFilePath))
                File.Delete(strFilePath);

            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtSource.Columns.Count; i++)
            {
                sw.Write(dtSource.Columns[i]);
                if (i < dtSource.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtSource.Rows)
            {
                for (int i = 0; i < dtSource.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = string.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtSource.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void btnNoticeView_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = Application.StartupPath.Split("bin")[0] + "RDLC\\rptNotices.rdlc";

            string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
            string toDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
            string centerName = cbxCenterNameRptPara.Text;

            dsNotice ds = GetDataRTOWise(fromDate, toDate, centerName, string.Empty, null, false, false, false);
            ReportDataSource datasource = new ReportDataSource("dt", ds.Tables["Table"]);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            // 🔥 FORCE PRINT LAYOUT MODE
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            // 🔥 ZOOM FOR PRINT VIEW
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Show();
            this.reportViewer1.RefreshReport();
            
        }

        private dsNotice GetData(string fromDate, string toDate, string centerName)
        {
            string constr = DBAccess.ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("EXEC GetNoticeReportData '" + fromDate + "', '" + toDate + "', '" + centerName + "', '" + Program.sStateCode + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (dsNotice ds = new dsNotice())
                        {   
                            sda.Fill(ds, "dtoNotice");
                            return ds;
                        }
                    }
                }
            }
        }

        private dsNotice GetDataRTOWise(string fromDate, string toDate, string centerName, string rtoCode, bool? IsComm=null, bool LessThanOneYear=false, bool IsDuplicate=false, bool IsOther = false)
        {
            string constr = DBAccess.ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("GetNoticeReportData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);
                    cmd.Parameters.AddWithValue("@CenterName", centerName);
                    cmd.Parameters.AddWithValue("@StateCode", Program.sStateCode);
                    cmd.Parameters.AddWithValue("@RtoCode", rtoCode);

                    cmd.Parameters.AddWithValue("@IsComm", (object)IsComm ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LessThanOneYear", LessThanOneYear);
                    cmd.Parameters.AddWithValue("@IsDuplicate", IsDuplicate);
                    cmd.Parameters.AddWithValue("@IsOther", IsOther);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsNotice ds = new dsNotice();
                    conn.Open();
                    da.Fill(ds);
                    return ds;
                }
            }

            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string sQry = "EXEC GetNoticeReportData '" + fromDate + "', '" + toDate + "', '" + centerName + "', '" + Program.sStateCode + "', '" + rtoCode + "', " + IsComm + ", " + LessThanOneYear + ", " + IsDuplicate + ", " + IsOther + "";
            //    using (SqlCommand cmd = new SqlCommand(sQry))
            //    {
            //        using (SqlDataAdapter sda = new SqlDataAdapter())
            //        {
            //            cmd.Connection = con;
            //            sda.SelectCommand = cmd;
            //            using (dsNotice ds = new dsNotice())
            //            {
            //                sda.Fill(ds, "dtoNotice");
            //                return ds;
            //            }
            //        }
            //    }
            //}
        }
        private void LoadCenterDropdown()
        {
            string sql = "SELECT CM.CenterCode,  CM.CenterName + '  -  (' + CM.Centercode +')'  AS CenterName FROM CenterMaster CM\r\nLEFT OUTER JOIN CSV ON CSV.CenterCode = CM.CenterCode\r\nGROUP BY CM.CenterCode, CM.CenterName";

            //string sql = $"SELECT DISTINCT CenterCode,CenterName FROM CSV WHERE StateCode = '{Program.sStateCode}' ";
            DataTable dt = DBAccess.GetSelectByQuery(sql);

            cbxListCenter.DataSource = dt;
            cbxListCenter.DisplayMember = "CenterName";
            cbxListCenter.ValueMember = "CenterCode";
            cbxListCenter.SelectedIndex = -1;
        }

        private void LoadCenterRptParaDropdown()
        {
            string sql = "SELECT CM.CenterCode,  CM.CenterName + '  -  (' + CM.Centercode +')'  AS CenterName FROM CenterMaster CM\r\nLEFT OUTER JOIN CSV ON CSV.CenterCode = CM.CenterCode\r\nGROUP BY CM.CenterCode, CM.CenterName";

            //string sql = $"SELECT DISTINCT CenterCode,CenterName FROM CSV WHERE StateCode = '{Program.sStateCode}' ";
            DataTable dt = DBAccess.GetSelectByQuery(sql);

            cbxCenterNameRptPara.DataSource = dt;
            cbxCenterNameRptPara.DisplayMember = "CenterName";
            cbxCenterNameRptPara.ValueMember = "CenterCode";
            cbxCenterNameRptPara.SelectedIndex = -1;
        }

        private string  GetCenterCodeName(string centerCode)
        {
            string centerName = string.Empty;
            string sql = "SELECT CenterCode,  CenterName + '  -  (' + Centercode +')'  AS CenterName FROM CenterMaster WHERE CenterCode = '"+ centerCode + "'";
            DataTable dtCenterMaster = DBAccess.GetSelectByQuery(sql);
            if (dtCenterMaster?.Rows.Count > 0)
            {
                centerName = dtCenterMaster.Rows[0]["CenterName"]?.ToString();
            }

            return centerName;
        }


    }//Class
}//Namespace
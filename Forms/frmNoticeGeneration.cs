using ESPNotice3._0.Classes;
using ESPNotice3._0.DataSet;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
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
    public partial class frmNoticeGeneration : frmBase
    {
        string srcPath = "D:\\ESP Notice 1.0 Before OCT 2020\\ESP Notice Utility\\Pics\\";
        public frmNoticeGeneration()
        {
            InitializeComponent();
           
            
        }

        private void frmNoticeGeneration_Load(object sender, EventArgs e)
        {
            this.lblFormTitle.Text = this.Text;
            tbxInputFilePath.Text = srcPath + dtpCSVDate.Value.ToString("dd-MM-yyyy") + "\\Pics\\";
            tabControl.SelectedIndex = 2;
            grbNoticeView.Width = grbGridView.Width;
            reportViewer1.Width = grbGridView.Width - (reportViewer1.Left*2);
        }
        private void dtpCSVDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = DBAccess.GetSelectByQuery("SELECT DISTINCT Code, CenterCode, CenterName from CSV Where vdfDateTime = '" + dtpCSVDate.Text + "'");

            cbxCenterName.DisplayMember = "CenterName";
            cbxCenterName.ValueMember = "CenterCode";
            cbxCenterName.DataSource = dt;
            tbxInputFilePath.Text = srcPath + dtpCSVDate.Value.ToString("dd-MM-yyyy") + "\\Pics\\";
        }
        private void cbxCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxCenterCode.Text = cbxCenterName.SelectedValue.ToString();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
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
                StreamWriter sw = File.CreateText(Application.StartupPath + "\\InputFilePath.txt");
                sw.WriteLine(tbxInputFilePath.Text);
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }

        }

        private void btnProcessNotices_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxCenterName.Text)) { MessageBox.Show("Please select center", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (String.IsNullOrEmpty(tbxCenterCode.Text)) { MessageBox.Show("Please select center code", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!Directory.Exists(tbxInputFilePath.Text))
            {
                MessageBox.Show("Please select valid path", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Notice Generation code
            DataTable dt = DBAccess.GetSelectByQuery("EXEC GetNoticeGenerate " + Convert.ToDateTime(dtpCSVDate.Value).ToString("yyyy-MM-dd"));

            MessageBox.Show("Notices has been generated successfully!", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cbxPDFFiles.Items.Count > 0)
            {
                cbxPDFFiles.Enabled = true;
                btnOpenPDF.Enabled = true;
            }
            else
            {
                cbxPDFFiles.Enabled = false;
                btnOpenPDF.Enabled = false;
            }
        }

        private void btnNoticeView_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "C:\\Work\\NitinM\\ESPNotice3.0\\RDLC\\rptNotices.rdlc";
            
            dsNotice ds = GetData();
            ReportDataSource datasource = new ReportDataSource("dt", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Show();
            this.reportViewer1.RefreshReport();
        }

        private dsNotice GetData()
        {
            string constr = DBAccess.ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("EXEC GetNoticeReportData"))
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


    }//Class
}//Namespace
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
    public partial class frmDashboard : frmBase
    {
        public Color BGPurple = Color.FromArgb(155, 89, 182);
        public Color BGGreen= Color.FromArgb(75, 192, 18);
        public Color BGOrange= Color.FromArgb(255, 178, 41);
        public Color BGBlue = Color.FromArgb(58, 83, 155);

        public Color HGPurple = Color.FromArgb(125, 60, 155);
        public Color HGGreen = Color.FromArgb(65, 160, 10);
        public Color HGOrange = Color.FromArgb(246, 145, 16);
        public Color HGBlue = Color.FromArgb(68, 108, 179);

        string[] BoxTables = { "CenterMaster", "Invalid_PlateNo", "RTOGroups", "VHCLASS", "CSV", "NoticeData" };
        string[] Boxs = { "Centers", "Invalid Vehicles", "RTOs", "Vehicle Classes", "CSVs", "Notices" };
        //string[] BoxValues = { "15", "25", "12", "0", "4082560", "158756" };

        public frmDashboard()
        {
            InitializeComponent();
            this.tabControl.Visible = false;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.lblFormTitle.Text = this.Text;
            
            pnlDashboard.Size = tabControl.Size;
            pnlDashboard.Location = tabControl.Location;
            //pnlDashboard.BackColor = BGPurple;

            //lblCSVsCount.Text = Convert.ToInt64(lblCSVsCount.Text).ToString("N").Replace(".00", "");
            //lblNoticesCount.Text = Convert.ToInt64(lblNoticesCount.Text).ToString("N").Replace(".00","");

            pnlDashboard.Controls.Clear();
            for (int i = 0; i < Boxs.Length; i++)
            {
                AddPanel(i);
            }

        }

        private void AddPanel(int i)
        { 
            Panel panel = new Panel();
            panel.Size = new Size(300, 150);
            panel.Location = new Point(10 + (i * (300+10)), 10);
            panel.BackColor = GetPanelColor(i + 1);
            panel.BorderStyle = BorderStyle.None;

            Label lbl = new Label();
            lbl.Text = string.Empty;
            lbl.Location = new Point(0,0);
            lbl.Size = new Size(300, 40);
            lbl.BackColor = GetLabelColor(i + 1);
            lbl.BorderStyle = BorderStyle.None;
            lbl.Dock = DockStyle.Top;
            lbl.AutoSize = false;
            lbl.Text= Boxs[i];
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.White;

            Label lblValue = new Label();
            lblValue.Text = string.Empty;
            lblValue.Location = new Point(0, 0);
            lblValue.Size = new Size(300, 40);
            //lblValue.BackColor = GetLabelColor(i+1);
            lblValue.BorderStyle = BorderStyle.None;
            lblValue.Dock = DockStyle.Fill;
            lblValue.AutoSize = false;
            lblValue.Text = GetData(i);
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            lblValue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValue.ForeColor = Color.White;

            panel.Controls.Add(lbl);
            panel.Controls.Add(lblValue);

            pnlDashboard.Controls.Add(panel);
        }

        private Color GetPanelColor(int i) 
        {
            if (i / 4 > 1)
                i = i - (4 * Convert.ToInt16((i / 4)));
            if (i == 0)
                i = 1;
            else if (i > 4 )
                i = i - 4;
            Color color = new Color();
            if (i == 1)
                color = BGPurple;
            else if (i == 2)
                color = BGGreen;
            else if (i == 3)
                color = BGOrange;
            else if (i == 4)
                color = BGBlue;

            return color;
        }
        private Color GetLabelColor(int i)
        {
            if (i / 4 > 1)
                i = i - (4 * Convert.ToInt16((i / 4)));
            if (i == 0)
                i = 1;
            else if (i > 4)
                i = i - 4;
            Color color = new Color();
            if (i == 1)
                color = HGPurple;
            else if (i == 2)
                color = HGGreen;
            else if (i == 3)
                color = HGOrange;
            else if (i == 4)
                color = HGBlue;

            return color;
        }

        private string GetData(int i)
        {
            string sResult = string.Empty;

            string strQry = "Select Count(1) From " + BoxTables[i].ToString().Trim();
            DataTable dt = DBAccess.GetDataTable(strQry);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0] != DBNull.Value)
                        sResult = dt.Rows[0][0] != DBNull.Value ? Convert.ToInt64(dt.Rows[0][0]).ToString("N").Replace(".00", "") : "0";
                }
            }

            return sResult;
        }

    }//Class
}//Namespace
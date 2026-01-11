namespace ESPNotice3._0.Forms
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private static frmDashboard sForm = null;
        public static frmDashboard Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmDashboard(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDashboard = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblCenterCount = new Label();
            lblInvalidVehCount = new Label();
            lblCSVsCount = new Label();
            lblNoticesCount = new Label();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlDashboard.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = SystemColors.Control;
            pnlDashboard.Controls.Add(panel3);
            pnlDashboard.Controls.Add(panel4);
            pnlDashboard.Controls.Add(panel2);
            pnlDashboard.Controls.Add(panel1);
            pnlDashboard.Location = new Point(6, 76);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1320, 662);
            pnlDashboard.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 83, 155);
            panel3.Controls.Add(lblNoticesCount);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(996, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(68, 108, 179);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(300, 40);
            label3.TabIndex = 2;
            label3.Text = "Notices";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 178, 41);
            panel4.Controls.Add(lblCSVsCount);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(669, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(246, 145, 16);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(300, 40);
            label4.TabIndex = 2;
            label4.Text = "CSVs";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 192, 18);
            panel2.Controls.Add(lblInvalidVehCount);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(347, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(65, 160, 10);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 40);
            label2.TabIndex = 2;
            label2.Text = "Invalid Vehicles";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 89, 182);
            panel1.Controls.Add(lblCenterCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(125, 60, 155);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 2;
            label1.Text = "Centers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCenterCount
            // 
            lblCenterCount.Dock = DockStyle.Fill;
            lblCenterCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCenterCount.ForeColor = Color.White;
            lblCenterCount.Location = new Point(0, 40);
            lblCenterCount.Name = "lblCenterCount";
            lblCenterCount.Size = new Size(300, 110);
            lblCenterCount.TabIndex = 3;
            lblCenterCount.Text = "15";
            lblCenterCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInvalidVehCount
            // 
            lblInvalidVehCount.Dock = DockStyle.Fill;
            lblInvalidVehCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvalidVehCount.ForeColor = Color.White;
            lblInvalidVehCount.Location = new Point(0, 40);
            lblInvalidVehCount.Name = "lblInvalidVehCount";
            lblInvalidVehCount.Size = new Size(300, 110);
            lblInvalidVehCount.TabIndex = 4;
            lblInvalidVehCount.Text = "25";
            lblInvalidVehCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCSVsCount
            // 
            lblCSVsCount.Dock = DockStyle.Fill;
            lblCSVsCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCSVsCount.ForeColor = Color.White;
            lblCSVsCount.Location = new Point(0, 40);
            lblCSVsCount.Name = "lblCSVsCount";
            lblCSVsCount.Size = new Size(300, 110);
            lblCSVsCount.TabIndex = 4;
            lblCSVsCount.Text = "4082560";
            lblCSVsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNoticesCount
            // 
            lblNoticesCount.Dock = DockStyle.Fill;
            lblNoticesCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoticesCount.ForeColor = Color.White;
            lblNoticesCount.Location = new Point(0, 40);
            lblNoticesCount.Name = "lblNoticesCount";
            lblNoticesCount.Size = new Size(300, 110);
            lblNoticesCount.TabIndex = 4;
            lblNoticesCount.Text = "158756";
            lblNoticesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Controls.Add(pnlDashboard);
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            Controls.SetChildIndex(tabControl, 0);
            Controls.SetChildIndex(pnlDashboard, 0);
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDashboard;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label lblNoticesCount;
        private Label lblCSVsCount;
        private Label lblInvalidVehCount;
        private Label lblCenterCount;
    }
}
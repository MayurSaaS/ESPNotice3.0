namespace ESPNotice3._0.Forms
{
    partial class frmVehicleClasses
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
        private static frmVehicleClasses sForm = null;
        public static frmVehicleClasses Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmVehicleClasses(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxWheels = new TextBox();
            lblWheels = new Label();
            tbxTRANSPORT_CATG = new TextBox();
            lblTRANSPORT_CATG = new Label();
            tbxCLASS_TYPE = new TextBox();
            lblCLASS_TYPE = new Label();
            tbxCL_DESC = new TextBox();
            lblCL_DESC = new Label();
            tbxCLASS_CD = new TextBox();
            lblCLASS_CD = new Label();
            grbFormView.SuspendLayout();
            tabControl.SuspendLayout();
            grbGridView.SuspendLayout();
            tabGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            // 
            // grbFormView
            // 
            grbFormView.Controls.Add(tbxWheels);
            grbFormView.Controls.Add(lblWheels);
            grbFormView.Controls.Add(tbxTRANSPORT_CATG);
            grbFormView.Controls.Add(lblTRANSPORT_CATG);
            grbFormView.Controls.Add(tbxCLASS_TYPE);
            grbFormView.Controls.Add(lblCLASS_TYPE);
            grbFormView.Controls.Add(tbxCL_DESC);
            grbFormView.Controls.Add(lblCL_DESC);
            grbFormView.Controls.Add(tbxCLASS_CD);
            grbFormView.Controls.Add(lblCLASS_CD);
            grbFormView.Controls.SetChildIndex(lblCLASS_CD, 0);
            grbFormView.Controls.SetChildIndex(tbxCLASS_CD, 0);
            grbFormView.Controls.SetChildIndex(lblCL_DESC, 0);
            grbFormView.Controls.SetChildIndex(tbxCL_DESC, 0);
            grbFormView.Controls.SetChildIndex(lblCLASS_TYPE, 0);
            grbFormView.Controls.SetChildIndex(tbxCLASS_TYPE, 0);
            grbFormView.Controls.SetChildIndex(lblTRANSPORT_CATG, 0);
            grbFormView.Controls.SetChildIndex(tbxTRANSPORT_CATG, 0);
            grbFormView.Controls.SetChildIndex(lblWheels, 0);
            grbFormView.Controls.SetChildIndex(tbxWheels, 0);
            // 
            // tbxWheels
            // 
            tbxWheels.BorderStyle = BorderStyle.FixedSingle;
            tbxWheels.Location = new Point(253, 304);
            tbxWheels.Name = "tbxWheels";
            tbxWheels.Size = new Size(300, 27);
            tbxWheels.TabIndex = 22;
            // 
            // lblWheels
            // 
            lblWheels.Location = new Point(78, 304);
            lblWheels.Name = "lblWheels";
            lblWheels.Size = new Size(175, 27);
            lblWheels.TabIndex = 21;
            lblWheels.Text = "Wheels";
            lblWheels.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxTRANSPORT_CATG
            // 
            tbxTRANSPORT_CATG.BorderStyle = BorderStyle.FixedSingle;
            tbxTRANSPORT_CATG.Location = new Point(912, 246);
            tbxTRANSPORT_CATG.Name = "tbxTRANSPORT_CATG";
            tbxTRANSPORT_CATG.Size = new Size(300, 27);
            tbxTRANSPORT_CATG.TabIndex = 20;
            // 
            // lblTRANSPORT_CATG
            // 
            lblTRANSPORT_CATG.Location = new Point(737, 246);
            lblTRANSPORT_CATG.Name = "lblTRANSPORT_CATG";
            lblTRANSPORT_CATG.Size = new Size(175, 27);
            lblTRANSPORT_CATG.TabIndex = 19;
            lblTRANSPORT_CATG.Text = "TRANSPORT_CATG";
            lblTRANSPORT_CATG.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCLASS_TYPE
            // 
            tbxCLASS_TYPE.BorderStyle = BorderStyle.FixedSingle;
            tbxCLASS_TYPE.Location = new Point(253, 246);
            tbxCLASS_TYPE.Name = "tbxCLASS_TYPE";
            tbxCLASS_TYPE.Size = new Size(300, 27);
            tbxCLASS_TYPE.TabIndex = 18;
            // 
            // lblCLASS_TYPE
            // 
            lblCLASS_TYPE.Location = new Point(78, 246);
            lblCLASS_TYPE.Name = "lblCLASS_TYPE";
            lblCLASS_TYPE.Size = new Size(175, 27);
            lblCLASS_TYPE.TabIndex = 17;
            lblCLASS_TYPE.Text = "CLASS_TYPE";
            lblCLASS_TYPE.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCL_DESC
            // 
            tbxCL_DESC.BorderStyle = BorderStyle.FixedSingle;
            tbxCL_DESC.Location = new Point(912, 193);
            tbxCL_DESC.Name = "tbxCL_DESC";
            tbxCL_DESC.Size = new Size(300, 27);
            tbxCL_DESC.TabIndex = 16;
            // 
            // lblCL_DESC
            // 
            lblCL_DESC.Location = new Point(737, 193);
            lblCL_DESC.Name = "lblCL_DESC";
            lblCL_DESC.Size = new Size(175, 27);
            lblCL_DESC.TabIndex = 15;
            lblCL_DESC.Text = "CL_DESC";
            lblCL_DESC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCLASS_CD
            // 
            tbxCLASS_CD.BorderStyle = BorderStyle.FixedSingle;
            tbxCLASS_CD.Location = new Point(253, 193);
            tbxCLASS_CD.Name = "tbxCLASS_CD";
            tbxCLASS_CD.Size = new Size(300, 27);
            tbxCLASS_CD.TabIndex = 14;
            // 
            // lblCLASS_CD
            // 
            lblCLASS_CD.Location = new Point(78, 193);
            lblCLASS_CD.Name = "lblCLASS_CD";
            lblCLASS_CD.Size = new Size(175, 27);
            lblCLASS_CD.TabIndex = 13;
            lblCLASS_CD.Text = "CLASS_CD";
            lblCLASS_CD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmVehicleClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmVehicleClasses";
            Text = "Vehicle Classes";
            Load += frmVehicleClasses_Load;
            grbFormView.ResumeLayout(false);
            grbFormView.PerformLayout();
            tabControl.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbxWheels;
        private Label lblWheels;
        private TextBox tbxTRANSPORT_CATG;
        private Label lblTRANSPORT_CATG;
        private TextBox tbxCLASS_TYPE;
        private Label lblCLASS_TYPE;
        private TextBox tbxCL_DESC;
        private Label lblCL_DESC;
        private TextBox tbxCLASS_CD;
        private Label lblCLASS_CD;
    }
}
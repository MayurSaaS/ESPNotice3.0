namespace ESPNotice3._0.Forms
{
    partial class frmLimits
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
        private static frmLimits sForm = null;
        public static frmLimits Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmLimits(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxminSmoke = new TextBox();
            lblminSmoke = new Label();
            tbxminHC = new TextBox();
            lblminHC = new Label();
            tbxminCO = new TextBox();
            lblminCO = new Label();
            tbxModel = new TextBox();
            lblModel = new Label();
            tbxCompliance = new TextBox();
            lblCompliance = new Label();
            tbxFuel = new TextBox();
            lblFuel = new Label();
            tbxWheels = new TextBox();
            lblWheels = new Label();
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
            grbFormView.Controls.Add(tbxminSmoke);
            grbFormView.Controls.Add(lblminSmoke);
            grbFormView.Controls.Add(tbxminHC);
            grbFormView.Controls.Add(lblminHC);
            grbFormView.Controls.Add(tbxminCO);
            grbFormView.Controls.Add(lblminCO);
            grbFormView.Controls.Add(tbxModel);
            grbFormView.Controls.Add(lblModel);
            grbFormView.Controls.Add(tbxCompliance);
            grbFormView.Controls.Add(lblCompliance);
            grbFormView.Controls.Add(tbxFuel);
            grbFormView.Controls.Add(lblFuel);
            grbFormView.Controls.Add(tbxWheels);
            grbFormView.Controls.Add(lblWheels);
            grbFormView.Controls.SetChildIndex(lblWheels, 0);
            grbFormView.Controls.SetChildIndex(tbxWheels, 0);
            grbFormView.Controls.SetChildIndex(lblFuel, 0);
            grbFormView.Controls.SetChildIndex(tbxFuel, 0);
            grbFormView.Controls.SetChildIndex(lblCompliance, 0);
            grbFormView.Controls.SetChildIndex(tbxCompliance, 0);
            grbFormView.Controls.SetChildIndex(lblModel, 0);
            grbFormView.Controls.SetChildIndex(tbxModel, 0);
            grbFormView.Controls.SetChildIndex(lblminCO, 0);
            grbFormView.Controls.SetChildIndex(tbxminCO, 0);
            grbFormView.Controls.SetChildIndex(lblminHC, 0);
            grbFormView.Controls.SetChildIndex(tbxminHC, 0);
            grbFormView.Controls.SetChildIndex(lblminSmoke, 0);
            grbFormView.Controls.SetChildIndex(tbxminSmoke, 0);
            // 
            // tbxminSmoke
            // 
            tbxminSmoke.BorderStyle = BorderStyle.FixedSingle;
            tbxminSmoke.Location = new Point(253, 331);
            tbxminSmoke.Name = "tbxminSmoke";
            tbxminSmoke.Size = new Size(300, 27);
            tbxminSmoke.TabIndex = 30;
            // 
            // lblminSmoke
            // 
            lblminSmoke.Location = new Point(78, 331);
            lblminSmoke.Name = "lblminSmoke";
            lblminSmoke.Size = new Size(175, 27);
            lblminSmoke.TabIndex = 29;
            lblminSmoke.Text = "minSmoke";
            lblminSmoke.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxminHC
            // 
            tbxminHC.BorderStyle = BorderStyle.FixedSingle;
            tbxminHC.Location = new Point(912, 277);
            tbxminHC.Name = "tbxminHC";
            tbxminHC.Size = new Size(300, 27);
            tbxminHC.TabIndex = 28;
            // 
            // lblminHC
            // 
            lblminHC.Location = new Point(737, 277);
            lblminHC.Name = "lblminHC";
            lblminHC.Size = new Size(175, 27);
            lblminHC.TabIndex = 27;
            lblminHC.Text = "minHC";
            lblminHC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxminCO
            // 
            tbxminCO.BorderStyle = BorderStyle.FixedSingle;
            tbxminCO.Location = new Point(253, 277);
            tbxminCO.Name = "tbxminCO";
            tbxminCO.Size = new Size(300, 27);
            tbxminCO.TabIndex = 26;
            // 
            // lblminCO
            // 
            lblminCO.Location = new Point(78, 277);
            lblminCO.Name = "lblminCO";
            lblminCO.Size = new Size(175, 27);
            lblminCO.TabIndex = 25;
            lblminCO.Text = "minCO";
            lblminCO.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxModel
            // 
            tbxModel.BorderStyle = BorderStyle.FixedSingle;
            tbxModel.Location = new Point(912, 219);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(300, 27);
            tbxModel.TabIndex = 24;
            // 
            // lblModel
            // 
            lblModel.Location = new Point(737, 219);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(175, 27);
            lblModel.TabIndex = 23;
            lblModel.Text = "Model";
            lblModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCompliance
            // 
            tbxCompliance.BorderStyle = BorderStyle.FixedSingle;
            tbxCompliance.Location = new Point(253, 219);
            tbxCompliance.Name = "tbxCompliance";
            tbxCompliance.Size = new Size(300, 27);
            tbxCompliance.TabIndex = 22;
            // 
            // lblCompliance
            // 
            lblCompliance.Location = new Point(78, 219);
            lblCompliance.Name = "lblCompliance";
            lblCompliance.Size = new Size(175, 27);
            lblCompliance.TabIndex = 21;
            lblCompliance.Text = "Compliance";
            lblCompliance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxFuel
            // 
            tbxFuel.BorderStyle = BorderStyle.FixedSingle;
            tbxFuel.Location = new Point(912, 166);
            tbxFuel.Name = "tbxFuel";
            tbxFuel.Size = new Size(300, 27);
            tbxFuel.TabIndex = 20;
            // 
            // lblFuel
            // 
            lblFuel.Location = new Point(737, 166);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(175, 27);
            lblFuel.TabIndex = 19;
            lblFuel.Text = "Fuel";
            lblFuel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxWheels
            // 
            tbxWheels.BorderStyle = BorderStyle.FixedSingle;
            tbxWheels.Location = new Point(253, 166);
            tbxWheels.Name = "tbxWheels";
            tbxWheels.Size = new Size(300, 27);
            tbxWheels.TabIndex = 18;
            // 
            // lblWheels
            // 
            lblWheels.Location = new Point(78, 166);
            lblWheels.Name = "lblWheels";
            lblWheels.Size = new Size(175, 27);
            lblWheels.TabIndex = 17;
            lblWheels.Text = "Wheels";
            lblWheels.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmLimits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmLimits";
            Text = "Limits";
            Load += frmLimits_Load;
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

        private TextBox tbxminSmoke;
        private Label lblminSmoke;
        private TextBox tbxminHC;
        private Label lblminHC;
        private TextBox tbxminCO;
        private Label lblminCO;
        private TextBox tbxModel;
        private Label lblModel;
        private TextBox tbxCompliance;
        private Label lblCompliance;
        private TextBox tbxFuel;
        private Label lblFuel;
        private TextBox tbxWheels;
        private Label lblWheels;
    }
}
namespace ESPNotice3._0.Forms
{
    partial class frmInvalidRegnNo
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
        private static frmInvalidRegnNo sForm = null;
        public static frmInvalidRegnNo Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmInvalidRegnNo(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxREGN_NO = new TextBox();
            lblREGN_NO = new Label();
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
            grbFormView.Controls.Add(tbxREGN_NO);
            grbFormView.Controls.Add(lblREGN_NO);
            grbFormView.Controls.SetChildIndex(lblREGN_NO, 0);
            grbFormView.Controls.SetChildIndex(tbxREGN_NO, 0);
            // 
            // tbxREGN_NO
            // 
            tbxREGN_NO.BorderStyle = BorderStyle.FixedSingle;
            tbxREGN_NO.Location = new Point(612, 233);
            tbxREGN_NO.Name = "tbxREGN_NO";
            tbxREGN_NO.Size = new Size(300, 27);
            tbxREGN_NO.TabIndex = 8;
            // 
            // lblREGN_NO
            // 
            lblREGN_NO.Location = new Point(437, 233);
            lblREGN_NO.Name = "lblREGN_NO";
            lblREGN_NO.Size = new Size(175, 27);
            lblREGN_NO.TabIndex = 7;
            lblREGN_NO.Text = "Regstration No";
            lblREGN_NO.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmInvalidRegnNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmInvalidRegnNo";
            Text = "Invalid Regn. No";
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

        private TextBox tbxREGN_NO;
        private Label lblREGN_NO;
    }
}
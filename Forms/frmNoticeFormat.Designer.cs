namespace ESPNotice3._0.Forms
{
    partial class frmNoticeFormat
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
        private static frmNoticeFormat sForm = null;
        public static frmNoticeFormat Instance()
        {
            if (sForm == null || sForm.IsDisposed) { sForm = new frmNoticeFormat(); }
            return sForm;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxNotice = new TextBox();
            lblNotice = new Label();
            tbxInspectionCenter = new TextBox();
            lblInspectionCenter = new Label();
            tbxTitle = new TextBox();
            lblTitle = new Label();
            tbxRHeader = new TextBox();
            lblRHeader = new Label();
            tbxCHeader = new TextBox();
            lblCHeader = new Label();
            tbxLHeader = new TextBox();
            lblLHeader = new Label();
            tbxFormatName = new TextBox();
            lblFormatName = new Label();
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
            grbFormView.Controls.Add(tbxNotice);
            grbFormView.Controls.Add(lblNotice);
            grbFormView.Controls.Add(tbxInspectionCenter);
            grbFormView.Controls.Add(lblInspectionCenter);
            grbFormView.Controls.Add(tbxTitle);
            grbFormView.Controls.Add(lblTitle);
            grbFormView.Controls.Add(tbxRHeader);
            grbFormView.Controls.Add(lblRHeader);
            grbFormView.Controls.Add(tbxCHeader);
            grbFormView.Controls.Add(lblCHeader);
            grbFormView.Controls.Add(tbxLHeader);
            grbFormView.Controls.Add(lblLHeader);
            grbFormView.Controls.Add(tbxFormatName);
            grbFormView.Controls.Add(lblFormatName);
            grbFormView.Controls.SetChildIndex(lblFormatName, 0);
            grbFormView.Controls.SetChildIndex(tbxFormatName, 0);
            grbFormView.Controls.SetChildIndex(lblLHeader, 0);
            grbFormView.Controls.SetChildIndex(tbxLHeader, 0);
            grbFormView.Controls.SetChildIndex(lblCHeader, 0);
            grbFormView.Controls.SetChildIndex(tbxCHeader, 0);
            grbFormView.Controls.SetChildIndex(lblRHeader, 0);
            grbFormView.Controls.SetChildIndex(tbxRHeader, 0);
            grbFormView.Controls.SetChildIndex(lblTitle, 0);
            grbFormView.Controls.SetChildIndex(tbxTitle, 0);
            grbFormView.Controls.SetChildIndex(lblInspectionCenter, 0);
            grbFormView.Controls.SetChildIndex(tbxInspectionCenter, 0);
            grbFormView.Controls.SetChildIndex(lblNotice, 0);
            grbFormView.Controls.SetChildIndex(tbxNotice, 0);
            // 
            // tbxNotice
            // 
            tbxNotice.BorderStyle = BorderStyle.FixedSingle;
            tbxNotice.Location = new Point(253, 331);
            tbxNotice.Name = "tbxNotice";
            tbxNotice.Size = new Size(300, 27);
            tbxNotice.TabIndex = 44;
            // 
            // lblNotice
            // 
            lblNotice.Location = new Point(78, 331);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(175, 27);
            lblNotice.TabIndex = 43;
            lblNotice.Text = "Notice";
            lblNotice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxInspectionCenter
            // 
            tbxInspectionCenter.BorderStyle = BorderStyle.FixedSingle;
            tbxInspectionCenter.Location = new Point(912, 277);
            tbxInspectionCenter.Name = "tbxInspectionCenter";
            tbxInspectionCenter.Size = new Size(300, 27);
            tbxInspectionCenter.TabIndex = 42;
            // 
            // lblInspectionCenter
            // 
            lblInspectionCenter.Location = new Point(737, 277);
            lblInspectionCenter.Name = "lblInspectionCenter";
            lblInspectionCenter.Size = new Size(175, 27);
            lblInspectionCenter.TabIndex = 41;
            lblInspectionCenter.Text = "InspectionCenter";
            lblInspectionCenter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxTitle
            // 
            tbxTitle.BorderStyle = BorderStyle.FixedSingle;
            tbxTitle.Location = new Point(253, 277);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(300, 27);
            tbxTitle.TabIndex = 40;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(78, 277);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(175, 27);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxRHeader
            // 
            tbxRHeader.BorderStyle = BorderStyle.FixedSingle;
            tbxRHeader.Location = new Point(912, 219);
            tbxRHeader.Name = "tbxRHeader";
            tbxRHeader.Size = new Size(300, 27);
            tbxRHeader.TabIndex = 38;
            // 
            // lblRHeader
            // 
            lblRHeader.Location = new Point(737, 219);
            lblRHeader.Name = "lblRHeader";
            lblRHeader.Size = new Size(175, 27);
            lblRHeader.TabIndex = 37;
            lblRHeader.Text = "RHeader";
            lblRHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxCHeader
            // 
            tbxCHeader.BorderStyle = BorderStyle.FixedSingle;
            tbxCHeader.Location = new Point(253, 219);
            tbxCHeader.Name = "tbxCHeader";
            tbxCHeader.Size = new Size(300, 27);
            tbxCHeader.TabIndex = 36;
            // 
            // lblCHeader
            // 
            lblCHeader.Location = new Point(78, 219);
            lblCHeader.Name = "lblCHeader";
            lblCHeader.Size = new Size(175, 27);
            lblCHeader.TabIndex = 35;
            lblCHeader.Text = "CHeader";
            lblCHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxLHeader
            // 
            tbxLHeader.BorderStyle = BorderStyle.FixedSingle;
            tbxLHeader.Location = new Point(912, 166);
            tbxLHeader.Name = "tbxLHeader";
            tbxLHeader.Size = new Size(300, 27);
            tbxLHeader.TabIndex = 34;
            // 
            // lblLHeader
            // 
            lblLHeader.Location = new Point(737, 166);
            lblLHeader.Name = "lblLHeader";
            lblLHeader.Size = new Size(175, 27);
            lblLHeader.TabIndex = 33;
            lblLHeader.Text = "LHeader";
            lblLHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxFormatName
            // 
            tbxFormatName.BorderStyle = BorderStyle.FixedSingle;
            tbxFormatName.Location = new Point(253, 166);
            tbxFormatName.Name = "tbxFormatName";
            tbxFormatName.Size = new Size(300, 27);
            tbxFormatName.TabIndex = 32;
            // 
            // lblFormatName
            // 
            lblFormatName.Location = new Point(78, 166);
            lblFormatName.Name = "lblFormatName";
            lblFormatName.Size = new Size(175, 27);
            lblFormatName.TabIndex = 31;
            lblFormatName.Text = "FormatName";
            lblFormatName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmNoticeFormat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 750);
            Name = "frmNoticeFormat";
            Text = "Notice Format";
            Load += frmNoticeFormat_Load;
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

        private TextBox tbxNotice;
        private Label lblNotice;
        private TextBox tbxInspectionCenter;
        private Label lblInspectionCenter;
        private TextBox tbxTitle;
        private Label lblTitle;
        private TextBox tbxRHeader;
        private Label lblRHeader;
        private TextBox tbxCHeader;
        private Label lblCHeader;
        private TextBox tbxLHeader;
        private Label lblLHeader;
        private TextBox tbxFormatName;
        private Label lblFormatName;
    }
}

namespace ESPNotice3._0.Forms
{
    partial class frmBase
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabGridView = new TabPage();
            grbGridView = new GroupBox();
            pnlSearch = new Panel();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            pnlGrid = new Panel();
            btnNew = new Button();
            btnEdit = new Button();
            dgvGrid = new DataGridView();
            tabFormView = new TabPage();
            pnlSave = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            grbFormView = new GroupBox();
            lblInfoMsg = new Label();
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            btnClose = new Button();
            pbxLogo = new PictureBox();
            tabControl.SuspendLayout();
            tabGridView.SuspendLayout();
            grbGridView.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrid).BeginInit();
            tabFormView.SuspendLayout();
            pnlSave.SuspendLayout();
            grbFormView.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabGridView);
            tabControl.Controls.Add(tabFormView);
            tabControl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.ItemSize = new Size(150, 40);
            tabControl.Location = new Point(6, 76);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1320, 662);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabGridView
            // 
            tabGridView.BackColor = Color.White;
            tabGridView.Controls.Add(grbGridView);
            tabGridView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabGridView.ForeColor = SystemColors.ControlText;
            tabGridView.Location = new Point(4, 44);
            tabGridView.Name = "tabGridView";
            tabGridView.Padding = new Padding(3);
            tabGridView.Size = new Size(1312, 614);
            tabGridView.TabIndex = 1;
            tabGridView.Text = "List View";
            // 
            // grbGridView
            // 
            grbGridView.Controls.Add(pnlSearch);
            grbGridView.Controls.Add(pnlGrid);
            grbGridView.Controls.Add(dgvGrid);
            grbGridView.Location = new Point(10, 0);
            grbGridView.Name = "grbGridView";
            grbGridView.Size = new Size(1312, 608);
            grbGridView.TabIndex = 2;
            grbGridView.TabStop = false;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(tbxSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Location = new Point(30, 25);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1269, 70);
            pnlSearch.TabIndex = 3;
            // 
            // tbxSearch
            // 
            tbxSearch.BorderStyle = BorderStyle.FixedSingle;
            tbxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(0, 20);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Please enter text for search";
            tbxSearch.Size = new Size(400, 30);
            tbxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1102, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(btnNew);
            pnlGrid.Controls.Add(btnEdit);
            pnlGrid.Location = new Point(30, 539);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(1269, 70);
            pnlGrid.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(41, 128, 185);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(936, 17);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(150, 40);
            btnNew.TabIndex = 1;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1102, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 40);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // dgvGrid
            // 
            dgvGrid.AllowUserToAddRows = false;
            dgvGrid.AllowUserToDeleteRows = false;
            dgvGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvGrid.Location = new Point(30, 102);
            dgvGrid.Name = "dgvGrid";
            dgvGrid.RowHeadersWidth = 51;
            dgvGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrid.Size = new Size(1269, 431);
            dgvGrid.TabIndex = 0;
            // 
            // tabFormView
            // 
            tabFormView.BackColor = Color.White;
            tabFormView.Controls.Add(pnlSave);
            tabFormView.Controls.Add(grbFormView);
            tabFormView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabFormView.Location = new Point(4, 44);
            tabFormView.Name = "tabFormView";
            tabFormView.Padding = new Padding(3);
            tabFormView.Size = new Size(1312, 614);
            tabFormView.TabIndex = 0;
            tabFormView.Text = "Form View";
            // 
            // pnlSave
            // 
            pnlSave.Controls.Add(btnCancel);
            pnlSave.Controls.Add(btnSave);
            pnlSave.Location = new Point(10, 538);
            pnlSave.Name = "pnlSave";
            pnlSave.Size = new Size(1290, 70);
            pnlSave.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(41, 128, 185);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(977, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1133, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // grbFormView
            // 
            grbFormView.Controls.Add(lblInfoMsg);
            grbFormView.Location = new Point(10, 4);
            grbFormView.Name = "grbFormView";
            grbFormView.Size = new Size(1290, 524);
            grbFormView.TabIndex = 3;
            grbFormView.TabStop = false;
            // 
            // lblInfoMsg
            // 
            lblInfoMsg.Dock = DockStyle.Bottom;
            lblInfoMsg.ForeColor = Color.Red;
            lblInfoMsg.Location = new Point(3, 501);
            lblInfoMsg.Name = "lblInfoMsg";
            lblInfoMsg.Size = new Size(1284, 20);
            lblInfoMsg.TabIndex = 0;
            lblInfoMsg.Text = "all fields with an asterisk (*) are mandatory";
            lblInfoMsg.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(pbxLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1338, 71);
            pnlHeader.TabIndex = 8;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblFormTitle.Location = new Point(96, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(591, 40);
            lblFormTitle.TabIndex = 12;
            lblFormTitle.Text = "Base Form";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.exit;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(1286, 12);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(2, 0, 0, 0);
            btnClose.Size = new Size(48, 48);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pbxLogo
            // 
            pbxLogo.BackgroundImage = Properties.Resources.show;
            pbxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbxLogo.Location = new Point(0, 0);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(81, 71);
            pbxLogo.TabIndex = 9;
            pbxLogo.TabStop = false;
            // 
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 128, 185);
            ClientSize = new Size(1338, 750);
            ControlBox = false;
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "frmBase";
            Text = "Base Form";
            tabControl.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            grbGridView.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrid).EndInit();
            tabFormView.ResumeLayout(false);
            pnlSave.ResumeLayout(false);
            grbFormView.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabFormView;
        private Panel pnlHeader;
        private PictureBox pbxLogo;
        private Panel pnlGrid;
        public Label lblFormTitle;
        private Panel pnlSave;
        public DataGridView dgvGrid;
        public TextBox tbxSearch;
        public Button btnSearch;
        public Button btnEdit;
        public Button btnCancel;
        public Button btnSave;
        public Button btnClose;
        private Label lblInfoMsg;
        public GroupBox grbFormView;
        public TabControl tabControl;
        public GroupBox grbGridView;
        public TabPage tabGridView;
        public Panel pnlSearch;
        public Button btnNew;
    }
}
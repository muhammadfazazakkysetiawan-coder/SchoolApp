namespace SchoolApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Palet: hitam, putih, pink
        private static readonly Color Black = Color.FromArgb(18, 18, 20);
        private static readonly Color Pink = Color.FromArgb(255, 79, 154);
        private static readonly Color SoftPink = Color.FromArgb(255, 228, 240);
        private static readonly Color Ink = Color.FromArgb(30, 30, 34);

        private static Label MakeLabel(string text, int x, int y)
        {
            return new Label
            {
                AutoSize = true,
                Text = text,
                Location = new Point(x, y),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Pink
            };
        }

        private static void StyleBox(TextBox t, string name, string placeholder, int x, int y, int w, int tab)
        {
            t.Name = name;
            t.PlaceholderText = placeholder;
            t.Location = new Point(x, y);
            t.Size = new Size(w, 27);
            t.TabIndex = tab;
            t.BorderStyle = BorderStyle.FixedSingle;
            t.BackColor = Color.White;
            t.ForeColor = Ink;
            t.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private static void StyleButton(Button b, string name, string text, Color back, Color fore, int x, int y, int tab)
        {
            b.Name = name;
            b.Text = text;
            b.Location = new Point(x, y);
            b.Size = new Size(110, 36);
            b.TabIndex = tab;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = back;
            b.ForeColor = fore;
            b.Cursor = Cursors.Hand;
            b.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            b.UseVisualStyleBackColor = false;
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSide = new Panel();
            pnlTop = new Panel();
            pnlForm = new Panel();
            pnlGrid = new Panel();

            lblBrand = new Label();
            lblBrandSub = new Label();
            lblCount = new Label();
            lblCountCaption = new Label();
            btnClear = new Button();

            lblHeading = new Label();
            txtSearch = new TextBox();
            txtName = new TextBox();
            txtNIS = new TextBox();
            txtClass = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pnlSide.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlGrid.SuspendLayout();
            SuspendLayout();
            //
            // pnlSide (sidebar hitam di kiri)
            //
            pnlSide.BackColor = Black;
            pnlSide.Controls.Add(btnClear);
            pnlSide.Controls.Add(lblCountCaption);
            pnlSide.Controls.Add(lblCount);
            pnlSide.Controls.Add(lblBrandSub);
            pnlSide.Controls.Add(lblBrand);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(200, 640);
            pnlSide.TabIndex = 0;
            //
            // lblBrand
            //
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(20, 24);
            lblBrand.Name = "lblBrand";
            lblBrand.Text = "School";
            //
            // lblBrandSub
            //
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrandSub.ForeColor = Pink;
            lblBrandSub.Location = new Point(20, 62);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Text = "App.";
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(16, 170);
            lblCount.Name = "lblCount";
            lblCount.Text = "0";
            //
            // lblCountCaption
            //
            lblCountCaption.AutoSize = true;
            lblCountCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountCaption.ForeColor = Pink;
            lblCountCaption.Location = new Point(22, 235);
            lblCountCaption.Name = "lblCountCaption";
            lblCountCaption.Text = "TOTAL SISWA";
            //
            // btnClear
            //
            StyleButton(btnClear, "btnClear", "Clear Form", Color.White, Black, 20, 300, 0);
            btnClear.Size = new Size(160, 36);
            //
            // pnlTop (judul + pencarian)
            //
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(lblHeading);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 70);
            pnlTop.TabIndex = 2;
            //
            // lblHeading
            //
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = Black;
            lblHeading.Location = new Point(24, 16);
            lblHeading.Name = "lblHeading";
            lblHeading.Text = "Data Siswa";
            //
            // txtSearch
            //
            StyleBox(txtSearch, "txtSearch", "cari nama / NIS / kelas...", 500, 22, 270, 0);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = SoftPink;
            //
            // pnlForm (form input mendatar, 2 baris)
            //
            pnlForm.BackColor = Black;
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnUpdate);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(txtAddress);
            pnlForm.Controls.Add(txtClass);
            pnlForm.Controls.Add(txtNIS);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(MakeLabel("ALAMAT", 24, 86));
            pnlForm.Controls.Add(MakeLabel("KELAS", 400, 16));
            pnlForm.Controls.Add(MakeLabel("NOMOR INDUK SISWA", 24, 16));
            pnlForm.Controls.Add(MakeLabel("NAMA SISWA", 212, 16));
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(800, 160);
            pnlForm.TabIndex = 1;
            //
            // input
            //
            StyleBox(txtNIS, "txtNIS", "masukan nis....", 24, 40, 170, 1);
            StyleBox(txtName, "txtName", "masukan nama....", 212, 40, 170, 2);
            StyleBox(txtClass, "txtClass", "contoh: XII RPL 1", 400, 40, 170, 3);
            StyleBox(txtAddress, "txtAddress", "masukan alamat....", 24, 110, 546, 4);
            //
            // tombol
            //
            StyleButton(btnSave, "btnSave", "Save", Pink, Color.White, 600, 38, 5);
            StyleButton(btnUpdate, "btnUpdate", "Update", Color.White, Black, 600, 78, 6);
            StyleButton(btnDelete, "btnDelete", "Delete", Black, Pink, 600, 118, 7);
            btnDelete.FlatAppearance.BorderSize = 1;
            btnDelete.FlatAppearance.BorderColor = Pink;
            //
            // pnlGrid (tabel)
            //
            pnlGrid.BackColor = Color.FromArgb(250, 245, 248);
            pnlGrid.Controls.Add(dgvData);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(24);
            pnlGrid.TabIndex = 3;
            //
            // dgvData
            //
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BackgroundColor = Color.White;
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvData.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Pink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point),
                SelectionBackColor = Pink,
                SelectionForeColor = Color.White,
                Padding = new Padding(4, 0, 0, 0)
            };
            dgvData.ColumnHeadersHeight = 38;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvData.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Ink,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point),
                SelectionBackColor = Black,
                SelectionForeColor = Color.White,
                Padding = new Padding(4, 0, 0, 0)
            };
            dgvData.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 245, 250)
            };
            dgvData.Dock = DockStyle.Fill;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.GridColor = SoftPink;
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.RowTemplate.Height = 32;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.TabIndex = 0;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 640);
            Controls.Add(pnlGrid);
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            Controls.Add(pnlSide);
            MinimumSize = new Size(900, 560);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School App 3 - Students";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Panel pnlTop;
        private Panel pnlForm;
        private Panel pnlGrid;

        private Label lblBrand;
        private Label lblBrandSub;
        private Label lblCount;
        private Label lblCountCaption;
        private Label lblHeading;
        private Button btnClear;

        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtNIS;
        private TextBox txtClass;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvData;
    }
}

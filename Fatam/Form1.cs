using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolApp3
{
    public partial class Form1 : Form
    {
        private string connectionString =
            "server=localhost;user=root;password=;database=SchoolApp3";

        private int studentId = 0;

        public Form1()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += (s, e) => ClearStudentForm();

            dgvData.CellClick += dgvData_CellClick;
            txtSearch.TextChanged += (s, e) => ShowData(txtSearch.Text.Trim());

            ShowData();
        }

        private void ShowData(string keyword = "")
        {
            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "SELECT id, nis, name, class_name, address " +
                    "FROM students " +
                    "WHERE name LIKE @k OR nis LIKE @k OR class_name LIKE @k " +
                    "ORDER BY name";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@k", "%" + keyword + "%");

                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                dgvData.DataSource = tabel;

                dgvData.Columns["id"].Visible = false;
                dgvData.Columns["nis"].HeaderText = "NIS";
                dgvData.Columns["name"].HeaderText = "Nama";
                dgvData.Columns["class_name"].HeaderText = "Kelas";
                dgvData.Columns["address"].HeaderText = "Alamat";

                lblCount.Text = tabel.Rows.Count.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void ClearStudentForm()
        {
            txtName.Clear();
            txtNIS.Clear();
            txtClass.Clear();
            txtAddress.Clear();
            studentId = 0;
            dgvData.ClearSelection();
        }

        private bool StudentFormValid()
        {
            if (txtName.Text.Trim() == "" ||
                txtNIS.Text.Trim() == "" ||
                txtClass.Text.Trim() == "")
            {
                MessageBox.Show("Nama, NIS, dan Kelas tidak boleh kosong");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!StudentFormValid())
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "INSERT INTO students (name, nis, class_name, address) " +
                    "VALUES (@name, @nis, @class, @address)";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@nis", txtNIS.Text.Trim());
                cmd.Parameters.AddWithValue("@class", txtClass.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data student berhasil disimpan");

                ClearStudentForm();
                ShowData(txtSearch.Text.Trim());
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("NIS sudah terdaftar");
                else
                    MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void dgvData_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];

            studentId = Convert.ToInt32(row.Cells["id"].Value);
            txtNIS.Text = row.Cells["nis"].Value?.ToString() ?? "";
            txtName.Text = row.Cells["name"].Value?.ToString() ?? "";
            txtClass.Text = row.Cells["class_name"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["address"].Value?.ToString() ?? "";
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Pilih student dari tabel terlebih dahulu");
                return;
            }

            if (!StudentFormValid())
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "UPDATE students SET name = @name, nis = @nis, " +
                    "class_name = @class, address = @address WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@nis", txtNIS.Text.Trim());
                cmd.Parameters.AddWithValue("@class", txtClass.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@id", studentId);

                conn.Open();
                int hasil = cmd.ExecuteNonQuery();

                if (hasil > 0)
                    MessageBox.Show("Data student berhasil diupdate");
                else
                    MessageBox.Show("Data student tidak ditemukan");

                ClearStudentForm();
                ShowData(txtSearch.Text.Trim());
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("NIS sudah dipakai siswa lain");
                else
                    MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Pilih student dari tabel terlebih dahulu");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data student ini?",
                "Konfirmasi Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query = "DELETE FROM students WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", studentId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data student berhasil dihapus");

                ClearStudentForm();
                ShowData(txtSearch.Text.Trim());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }
    }
}

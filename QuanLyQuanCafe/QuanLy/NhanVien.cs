using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using QuanLyQuanCafe.Properties;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Settings.Default.connString))
            {
                conn.Open();
                var cmdNhanVien = new SqlCommand("SELECT MSNV, TenNV, SoDienThoai FROM NhanVien", conn);
                var readerNhanVien = cmdNhanVien.ExecuteReader();
                while (readerNhanVien.Read())
                {
                    var cmdTaiKhoan = new SqlCommand($"SELECT PhanQuyen FROM TaiKhoan WHERE MSNV='{readerNhanVien["MSNV"]}'", conn);
                    dataGridView1.Rows.Add(readerNhanVien["MSNV"], readerNhanVien["TenNV"], readerNhanVien["SoDienThoai"], (bool)cmdTaiKhoan.ExecuteScalar() == false ? "Quản lý" : "Thu Ngân");
                }
            }

            dataGridView1.ClearSelection();
        }

        private void raisedButtonAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dataGridView1.ClearSelection();
            flatButtonAddEdit.Text = @"Thêm";

            foreach (Control c in panel1.Controls)
            {
                errorProvider1.SetError(c, string.Empty);
                if (!(c is MaterialSingleLineTextField)) continue;
                var tf = c as MaterialSingleLineTextField;
                tf.Clear();
            }
        }


        private void raisedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                using (var conn = new SqlConnection(Settings.Default.connString))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"DELETE FROM NhanVien WHERE MSNV='{dataGridView1.CurrentRow.Cells[0].Value}'", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void flatButtonAddEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is MaterialSingleLineTextField)
                    errorProvider1.SetError(c, string.IsNullOrWhiteSpace(c.Text) ? "Bạn không được để trống thông tin này" : string.Empty);

                if (c is Panel)
                    errorProvider1.SetError(c, c.Controls.OfType<MaterialRadioButton>().All(chk => chk.Checked == false) ? "Bạn không được để trống thông tin này" : string.Empty);
            }

            //if (flatButtonAddEdit.Text == @"Thêm")
            //{
            //    using (var conn = new SqlConnection(Settings.Default.connString))
            //    {
            //        conn.Open();
            //        var cmd = new SqlCommand($"SELECT TenDangNhap FROM TaiKhoan WHERE TenDangNhap='{textboxUsername.Text}'", conn);
            //        if (cmd.ExecuteScalar() == null) errorProvider1.SetError(textboxUsername, "Tên đăng nhập đã tồn tại");
            //    }
            //}

            //if (panel1.Controls.Cast<Control>().Any(c => errorProvider1.GetError(c) != "")) return;

            if (flatButtonAddEdit.Text == @"Thêm")
            {
                try
                {
                    using (var conn = new SqlConnection(Settings.Default.connString))
                    {
                        conn.Open();
                        var cmd = new SqlCommand("INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, CMND, NgayVaoLam) " +
                            "VALUES(@TenNV, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @CMND, @NgayVaoLam); SELECT SCOPE_IDENTITY()", conn);
                        cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = textBoxFullName.Text.Trim();
                        cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = radioButtonFemale.Checked;
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = timePickerBirthday.Value;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = textBoxAddress.Text.Trim();
                        cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = textBoxPhone.Text.Trim();
                        cmd.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = textBoxCMND.Text.Trim();
                        cmd.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = timePickerWorkSince.Value.ToString("yyyy-MM-dd");
                        var msnv = cmd.ExecuteScalar().ToString();
                        cmd = new SqlCommand($"INSERT INTO TaiKhoan VALUES(@TenDangNhap, '{msnv}', @MatKhau, @PhanQuyen)", conn);
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar).Value = textBoxUsername.Text;
                        cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = textBoxPassword.Text;
                        cmd.Parameters.Add("@PhanQuyen", SqlDbType.Bit).Value = radioButtonEmployee.Checked;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                if (dataGridView1.CurrentRow == null) return;

                using (var conn = new SqlConnection(Settings.Default.connString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("UPDATE NhanVien SET TenNV=@TenNV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DiaChi=@DiaChi, " +
                                             "SoDienThoai=@SoDienThoai, CMND=@CMND, NgayVaoLam=@NgayVaoLam " +
                                             $"WHERE MSNV={dataGridView1.CurrentRow.Cells[0].Value}", conn);
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = textBoxFullName.Text.Trim();
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = radioButtonFemale.Checked;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = timePickerBirthday.Value;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = textBoxAddress.Text.Trim();
                    cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = textBoxPhone.Text.Trim();
                    cmd.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = textBoxCMND.Text.Trim();
                    cmd.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = timePickerWorkSince.Value.ToString("yyyy-MM-dd");
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE TaiKhoan SET TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, PhanQuyen=@PhanQuyen " +
                        $"WHERE MSNV={dataGridView1.CurrentRow.Cells[0].Value}", conn);
                    cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar).Value = textBoxUsername.Text;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = textBoxPassword.Text;
                    cmd.Parameters.Add("@PhanQuyen", SqlDbType.Bit).Value = radioButtonEmployee.Checked;
                    cmd.ExecuteNonQuery();
                }
            }


        }

        private void flatButtonCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void textboxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textboxIDCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textFieldSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (var conn = new SqlConnection(Settings.Default.connString))
            {
                conn.Open();
                var cmdNhanVien = new SqlCommand("SELECT NhanVien.MSNV, TaiKhoan.MSNV, TenNV, SoDienThoai FROM NhanVien, TaiKhoan " +
                                                 $"WHERE NhanVien.MSNV = TaiKhoan.MSNV AND (NhanVien.MSNV LIKE '%{textFieldSearch.Text}%' OR TenNV LIKE '%{textFieldSearch.Text}%' OR SoDienThoai LIKE '%{textFieldSearch.Text}%')", conn);
                var readerNhanVien = cmdNhanVien.ExecuteReader();
                while (readerNhanVien.Read())
                {
                    var cmdTaiKhoan = new SqlCommand($"SELECT PhanQuyen FROM TaiKhoan WHERE MSNV='{readerNhanVien["MSNV"]}'", conn);
                    dataGridView1.Rows.Add(readerNhanVien["MSNV"], readerNhanVien["TenNV"], readerNhanVien["SoDienThoai"], (bool)cmdTaiKhoan.ExecuteScalar() == false ? "Quản lý" : "Thu Ngân");
                }
            }

            flatButtonCancel_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            foreach (Control c in panel1.Controls)
                errorProvider1.SetError(c, string.Empty);

            panel1.Visible = true;
            flatButtonAddEdit.Text = @"Sửa";

            using (var conn = new SqlConnection(Settings.Default.connString))
            {
                conn.Open();
                var cmd = new SqlCommand($"SELECT * FROM NhanVien, TaiKhoan WHERE NhanVien.MSNV = TaiKhoan.MSNV AND TaiKhoan.MSNV = '{dataGridView1.CurrentRow.Cells[0].Value}'", conn);
                var reader = cmd.ExecuteReader();
                reader.Read();
                textBoxUsername.Text = reader["TenDangNhap"].ToString();
                textBoxPassword.Text = reader["MatKhau"].ToString();
                textBoxFullName.Text = reader["TenNV"].ToString();
                if ((bool)reader["GioiTinh"]) radioButtonFemale.Checked = true;
                else radioButtonMale.Checked = true;
                timePickerBirthday.Value = reader.GetDateTime(3);
                textBoxCMND.Text = reader["CMND"].ToString();
                textBoxAddress.Text = reader["DiaChi"].ToString();
                textBoxPhone.Text = reader["SoDienThoai"].ToString();
                timePickerWorkSince.Value = reader.GetDateTime(7);
                if ((bool)reader["PhanQuyen"]) radioButtonEmployee.Checked = true;
                else radioButtonAdmin.Checked = true;
            }


        }


    }
}

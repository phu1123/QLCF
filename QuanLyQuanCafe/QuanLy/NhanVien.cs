using System;
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
                var cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    var per = new SqlCommand($"SELECT PhanQuyen FROM TaiKhoan WHERE MSNV='{r["MSNV"]}'", conn);
                    dataGridView1.Rows.Add(r["MSNV"], r["TenNV"], r["SoDienThoai"], (bool)per.ExecuteScalar() == false ? "Quản lý" : "Thu Ngân");
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

            using (var conn = new SqlConnection(Settings.Default.connString))
            {
                conn.Open();
                var cmd = new SqlCommand($"DELETE FROM NhanVien WHERE MSNV='{dataGridView1.CurrentRow.Cells[0].Value}'", conn);
                cmd.ExecuteNonQuery();
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
                using (var conn = new SqlConnection(Settings.Default.connString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, CMND, NgayVaoLam)" +
                                             $"VALUES('{textboxFullName.Text}', '{radioButtonFemale.Checked}', '{timePickerBirthday.Value.ToString("yyyy-MM-dd")}', '{textboxAddress}', '{textboxPhone}', '{textboxCMND}', '{timePickerFirstDayWorking.Value.ToString("yyyy-MM-dd")}'", conn);
                    cmd.ExecuteNonQuery();
                    //cmd = new SqlCommand($"INSERT INTO TaiKhoan VALUES({textboxUsername.Text}, SELECT SCOPE_IDENTITY(), {textboxPassword.Text}, {radioButtonEmployee.Checked})");
                    //cmd.ExecuteNonQuery();

                }
            }
            else
            {
                
            }


        }

        private void flatButtonCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
                var cmd = new SqlCommand($"SELECT * FROM NhanVien WHERE MSNV LIKE '%{textFieldSearch.Text}%' OR TenNV LIKE '%{textFieldSearch.Text}%'", conn);
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    var per = new SqlCommand($"SELECT PhanQuyen FROM TaiKhoan WHERE MSNV='{r["MSNV"]}'", conn);
                    dataGridView1.Rows.Add(r["MSNV"], r["TenNV"], r["SoDienThoai"], (bool)per.ExecuteScalar() == false ? "Quản lý" : "Thu Ngân");
                }
            }
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
                var cmd = new SqlCommand($"SELECT * FROM NhanVien, TaiKhoan WHERE NhanVien.MSNV = TaiKhoan.MSNV AND NhanVien.MSNV = '{dataGridView1.CurrentRow.Cells[0].Value}'", conn);
                var r = cmd.ExecuteReader();
                r.Read();
                textboxUsername.Text = r["TenDangNhap"].ToString();
                textboxPassword.Text = r["MatKhau"].ToString();
                textboxFullName.Text = r["TenNV"].ToString();
                if ((bool) r["GioiTinh"]) radioButtonFemale.Checked = true;
                else radioButtonMale.Checked = true;
                timePickerBirthday.Value = r.GetDateTime(3);
                textboxCMND.Text = r["CMND"].ToString();
                textboxAddress.Text  = r["DiaChi"].ToString();
                textboxPhone.Text = r["SoDienThoai"].ToString();
                timePickerFirstDayWorking.Value = r.GetDateTime(7);
                if ((bool)r["PhanQuyen"]) radioButtonEmployee.Checked = true;
                else radioButtonAdmin.Checked = true;
            }
        }    
    }
}

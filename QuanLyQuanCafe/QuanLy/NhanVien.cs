using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using APP;
using MaterialSkin.Controls;
using BUS;
using DTO;
using QuanLyQuanCafe.Dialog;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
            RefreshNhanVien();
        }

        private void RefreshNhanVien()
        {
            using (NhanVienBUS bus = new NhanVienBUS())
                dataGridView1.DataSource = bus.ListNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            panel1.Visible = true;
            btnYes.Text = @"Thêm";

            foreach (Control c in panel1.Controls)
            {
                errorProvider1.SetError(c, string.Empty);
                if (!(c is MaterialSingleLineTextField)) continue;
                var tf = c as MaterialSingleLineTextField;
                tf.Clear();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            using (NhanVienBUS bus = new NhanVienBUS())
            {
                if (new XacNhan { Text = @"Bạn có chắc chắn muốn xóa nhân viên " + dataGridView1.CurrentRow.Cells[1].Value }.ShowDialog() == DialogResult.Yes)
                {
                    string msnv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    bus.DeleteNhanVien(msnv);
                }
            }

            RefreshNhanVien();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is MaterialSingleLineTextField)
                    errorProvider1.SetError(c, string.IsNullOrWhiteSpace(c.Text) ? "Bạn không được để trống thông tin này" : string.Empty);

                if (c is Panel)
                    errorProvider1.SetError(c, c.Controls.OfType<MaterialRadioButton>().All(chk => chk.Checked == false) ? "Bạn không được để trống thông tin này" : string.Empty);
            }

            if (panel1.Controls.Cast<Control>().Any(c => errorProvider1.GetError(c) != string.Empty)) return;

            try
            {
                using (NhanVienBUS bus = new NhanVienBUS())
                {
                    NhanVienDTO info = new NhanVienDTO
                    {
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                        TenNv = txtTenNV.Text,
                        GioiTinh = rbtnNu.Checked,
                        NgaySinh = dtpNgaySinh.Value,
                        Cmnd = txtCmnd.Text,
                        DiaChi = txtDiaChi.Text,
                        SoDienThoai = txtSoDienThoai.Text,
                        NgayLamViec = dtpNgayVaoLam.Value,
                        PhanQuyen = rbtnThuNgan.Checked
                    };

                    if (dataGridView1.SelectedRows.Count == 0)
                        bus.InsertNhanVien(info);
                    else
                    {
                        string msnv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        bus.EditNhanVien(info, msnv);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == DbConnection.MssqlEng002627)
                    errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập đã tồn tại");
                else throw;
            }

            RefreshNhanVien();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"TenNV LIKE '%{txtTimKiem.Text}%' OR MSNV + '' LIKE '%{txtTimKiem.Text}%' OR SoDienThoai LIKE '%{txtTimKiem.Text}%'";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText != @"Chức vụ") return;
            e.Value = (bool)e.Value ? "Thu ngân" : "Quản lý";
            e.FormattingApplied = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!dataGridView1.Focused)
            {
                dataGridView1.ClearSelection();
                panel1.Visible = false;
                return;
            }

            foreach (Control c in panel1.Controls)
                errorProvider1.SetError(c, string.Empty);

            panel1.Visible = true;
            btnYes.Text = @"Sửa";

            using (NhanVienBUS bus = new NhanVienBUS())
            {
                if (dataGridView1.CurrentRow == null) return;

                string msnv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NhanVienDTO info = bus.LoadNhanVien(msnv);
                txtTenDangNhap.Text = info.TenDangNhap;
                txtMatKhau.Text = info.MatKhau;
                txtTenNV.Text = info.TenNv;
                if (info.GioiTinh) rbtnNu.Checked = true;
                else rbtnNam.Checked = true;
                dtpNgaySinh.Value = info.NgaySinh;
                txtCmnd.Text = info.Cmnd;
                txtDiaChi.Text = info.DiaChi;
                txtSoDienThoai.Text = info.SoDienThoai;
                dtpNgayVaoLam.Value = Convert.ToDateTime(info.NgayLamViec);
                if (info.PhanQuyen) rbtnThuNgan.Checked = true;
                else rbtnQuanLy.Checked = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            panel1.Visible = false;  
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

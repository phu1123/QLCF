using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using APP;
using BUS;
using DTO;
using MaterialSkin.Controls;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class HangHoa : UserControl
    {      
        public HangHoa()
        {
            InitializeComponent();
            RefreshHangHoa();
            dataGridView2.DataSource = dtChiTiet;
        }

        private void RefreshHangHoa()
        {
            using (HangHoaBUS bus = new HangHoaBUS())
                dataGridView1.DataSource = bus.ListHangHoa();
        }

        private void UpdateTongTien()
        {
            int exclTax = dtChiTiet.Rows.Cast<DataRow>().Sum(row => Convert.ToInt32(row.Field<string>("ThanhTien")));
            lblTongTien.Text = (exclTax + (exclTax * nudThue.Value*0.01m)).ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"TenHangHoa LIKE '%{txtTimKiem.Text}%'";
        }

        private void btnThemMenu_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            tabNoHeader1.SelectedIndex = 0;
            tabNoHeader1.Visible = true;
            btnThem.Text = @"Thêm";

            foreach (MaterialSingleLineTextField c in tabThem.Controls.OfType<MaterialSingleLineTextField>())
            {
                errorProvider1.SetError(c, string.Empty);
                c.Clear();
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tabNoHeader1.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (var c in from MaterialSingleLineTextField c in tabThem.Controls.OfType<MaterialSingleLineTextField>() where c != txtGhiChu select c)
                errorProvider1.SetError(c, string.IsNullOrWhiteSpace(c.Text) ? "Bạn không được để trống thông tin này" : string.Empty);          

            if (tabThem.Controls.OfType<MaterialSingleLineTextField>().Any(c => errorProvider1.GetError(c) != string.Empty)) return;

            try
            {
                using (HangHoaBUS bus = new HangHoaBUS())
                {
                    HangHoaDTO info = new HangHoaDTO
                    {
                        TenHangHoa = txtTenHangHoa.Text,
                        GiaBan = Convert.ToInt32(txtGiaBan.Text),
                        DonViTinh = txtDonViTinh.Text,
                        SoLuongTon = Convert.ToInt32(txtSoLuongTon.Text),
                        GhiChu = txtGhiChu.Text
                    };

                    if (dataGridView1.SelectedRows.Count == 0)
                        bus.InsertHangHoa(info);
                    else
                    {
                        string tenhanghoa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        bus.EditHangHoa(info, tenhanghoa);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == DbConnection.MssqlEng002627)
                    errorProvider1.SetError(txtTenHangHoa, "Hàng hóa đã tồn tại");
                else throw;
            }
            RefreshHangHoa();
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            using (HangHoaBUS bus = new HangHoaBUS())
            {
                string tenhanghoa = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bus.DeleteHangHoa(tenhanghoa);
            }

            RefreshHangHoa();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!dataGridView1.Focused)
            {
                dataGridView1.ClearSelection();
                tabNoHeader1.Visible = false;
                return;
            }

            if (tabNoHeader1.Visible && tabNoHeader1.SelectedIndex == 1) return;

            foreach (Control c in tabThem.Controls)
                errorProvider1.SetError(c, string.Empty);

            tabNoHeader1.SelectedIndex = 0;
            tabNoHeader1.Visible = true;
            btnThem.Text = @"Sửa";

            using (HangHoaBUS bus = new HangHoaBUS())
            {
                string tennhanghoa = dataGridView1.CurrentRow?.Cells[0].Value.ToString();
                HangHoaDTO info = bus.LoadHangHoa(tennhanghoa);
                txtTenHangHoa.Text = info.TenHangHoa;
                txtGiaBan.Text = info.GiaBan.ToString();
                txtDonViTinh.Text = info.DonViTinh;
                txtSoLuongTon.Text = info.SoLuongTon.ToString();
                txtGhiChu.Text = info.GhiChu;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dtChiTiet.Rows.Clear();
            UpdateTongTien();
            tabNoHeader1.SelectedIndex = 1;
            tabNoHeader1.Visible = true;

            foreach (var c in tabNhapHang.Controls.OfType<MaterialSingleLineTextField>())
            {
                errorProvider1.SetError(c, string.Empty);
                c.Clear();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            dtChiTiet.Rows.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += dataGridView2_KeyPress;
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtChiTiet.Rows.Count == 0) return;

            dtChiTiet.Rows[e.RowIndex].SetField("ThanhTien",
                Convert.ToInt32(dtChiTiet.Rows[e.RowIndex].Field<string>("GiaMua"))*
                Convert.ToInt32(dtChiTiet.Rows[e.RowIndex].Field<string>("SoLuong")));

            UpdateTongTien();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells[1].ErrorText = row.Cells[1].Value == DBNull.Value ? "Nhập thông tin" : string.Empty;
                row.Cells[2].ErrorText = row.Cells[2].Value == DBNull.Value ? "Nhập thông tin" : string.Empty;
            }

            foreach (var c in from MaterialSingleLineTextField c in tabNhapHang.Controls.OfType<MaterialSingleLineTextField>() where c != txtGhiChuHoaDon select c)
                errorProvider1.SetError(c, string.IsNullOrWhiteSpace(c.Text) ? "Bạn không được để trống thông tin này" : string.Empty);

            if (dataGridView2.Rows.Count == 0 || tabNhapHang.Controls.OfType<MaterialSingleLineTextField>().Any(c => errorProvider1.GetError(c) != string.Empty) || dataGridView2.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[1].ErrorText != string.Empty || row.Cells[2].ErrorText != string.Empty)) return;

            try
            {                
                NhapHangDTO info = new NhapHangDTO
                {
                    SoHoaDon = txtSoHoaDon.Text,
                    Msnv = QuanLy.MsnvLogin,
                    NgayNhap = dtpNgayNhap.Value,
                    NhaCungCap = txtNhaCungCap.Text,
                    DiaChi = txtDiaChi.Text,
                    ChiTiet = dtChiTiet,
                    Thue = nudThue.Value,
                    TongTien = int.Parse(lblTongTien.Text, NumberStyles.AllowThousands, CultureInfo.CreateSpecificCulture("vi-VN")),
                    GhiChu = txtGhiChuHoaDon.Text
                };

                using (NhapHangBUS nhaphangBUS = new NhapHangBUS())
                    nhaphangBUS.NhapHang(info);
            }
            catch (SqlException ex)
            {
                if (ex.Number == DbConnection.MssqlEng002627)
                    errorProvider1.SetError(txtSoHoaDon, "Số hóa đơn đã tồn tại trong CSDL");
                else throw;
            }

            RefreshHangHoa();
        }

        private void nudThue_ValueChanged(object sender, EventArgs e)
        {
            UpdateTongTien();
        }
    }

}

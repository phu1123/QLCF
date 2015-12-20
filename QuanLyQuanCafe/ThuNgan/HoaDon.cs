using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;
using QuanLyQuanCafe.Dialog;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void txtTimBanHang_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"SoHoaDon + '' LIKE '%{txtTimBanHang.Text}%'";
        }

        private void txtTimNhapHang_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = $"SoHoaDon + '' LIKE '%{txtTimNhapHang.Text}%' OR NhaCungCap LIKE '%{txtTimNhapHang.Text}%'";
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            using (HoaDonBUS bus = new HoaDonBUS())
            {
                dataGridView1.DataSource = bus.ListBanHang();
                dataGridView2.DataSource = bus.ListNhapHang();
            }
        }

        private void btnLocBanHang_Click(object sender, EventArgs e)
        {
            using (HoaDonBUS bus = new HoaDonBUS())
                dataGridView1.DataSource = bus.FilterBanHang(dtpTuNgayBanHang.Value, dtpDenNgayBanHang.Value);
        }

        private void btnLocNhapHang_Click(object sender, EventArgs e)
        {
            using (HoaDonBUS bus = new HoaDonBUS())
                dataGridView2.DataSource = bus.FilterNhapHang(dtpTuNgayNhapHang.Value, dtpDenNgayNhapHang.Value);
        }

        private void txtChiTietBanHang_Click(object sender, EventArgs e)
        {
            using (HoaDonBUS bus = new HoaDonBUS())
            {
                DataTable hoadon = bus.HoaDonBanHang(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

                BanHangDTO info = new BanHangDTO
                {
                    MaSoBan = hoadon.Rows[0].Field<int>("MaSoBan"),
                    SoHoaDon = hoadon.Rows[0].Field<int>("SoHoaDon"),
                    GioRa = hoadon.Rows[0].Field<DateTime>("GioRa"),
                    KhuyenMai = hoadon.Rows[0].Field<decimal>("KhuyenMai"),
                    TongTien = hoadon.Rows[0].Field<int>("TongTien"),
                    ChiTiet = bus.ChiTietBanHang(hoadon.Rows[0].Field<int>("SoHoaDon"))
                };

                new BanHangReport(info).ShowDialog();
            }
        }

        private void txtChiTietMuaHang_Click(object sender, EventArgs e)
        {

        }
    }
}

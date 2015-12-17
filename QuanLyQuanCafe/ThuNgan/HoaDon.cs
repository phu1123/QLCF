using System.Data;
using System.Windows.Forms;
using BUS;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void txtTimBanHang_TextChanged(object sender, System.EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"SoHoaDon + '' LIKE '%{txtTimBanHang.Text}%'";
        }

        private void txtTimNhapHang_TextChanged(object sender, System.EventArgs e)
        {
            ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = $"SoHoaDon + '' LIKE '%{txtTimNhapHang.Text}%' OR NhaCungCap LIKE '%{txtTimNhapHang.Text}%'";
        }

        private void HoaDon_Load(object sender, System.EventArgs e)
        {

            using (HoaDonBUS bus = new HoaDonBUS())
            {
                dataGridView1.DataSource = bus.ListBanHang();
                dataGridView2.DataSource = bus.ListNhapHang();
            }
        }

        private void btnLocBanHang_Click(object sender, System.EventArgs e)
        {
            using (HoaDonBUS bus = new HoaDonBUS())
                dataGridView1.DataSource = bus.FilterBanHang(dtpTuNgayBanHang.Value, dtpDenNgayBanHang.Value);
        }

        private void btnLocNhapHang_Click(object sender, System.EventArgs e)
        {
            using (HoaDonBUS bus = new HoaDonBUS())
                dataGridView2.DataSource = bus.FilterNhapHang(dtpTuNgayNhapHang.Value, dtpDenNgayNhapHang.Value);
        }
    }
}

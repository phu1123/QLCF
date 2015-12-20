using System;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;
using MaterialSkin.Controls;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class ThongTinCaNhan : UserControl
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            using (NhanVienBUS bus = new NhanVienBUS())
            {
                NhanVienDTO info = bus.LoadNhanVien(ThuNgan.MsnvLogin.ToString());
                errorProvider1.SetError(txtMatKhauCu, info.MatKhau != txtMatKhauCu.Text ? "Mật khẩu cũ không chính xác" : string.Empty);
                errorProvider1.SetError(txtXacNhan, txtMatKhauMoi.Text != txtXacNhan.Text ? "Xác nhận mật khẩu không chính xác" : string.Empty);
                if (Controls.OfType<MaterialSingleLineTextField>().Any(c => errorProvider1.GetError(c) != string.Empty)) return;

                bus.DoiMatKhau(ThuNgan.MsnvLogin, txtMatKhauMoi.Text);
                foreach (var c in Controls.OfType<MaterialSingleLineTextField>())
                    c.Clear();
            }
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            using (NhanVienBUS bus = new NhanVienBUS())
            {
                NhanVienDTO info = bus.LoadNhanVien(ThuNgan.MsnvLogin.ToString());
                lblMaSo.Text += ThuNgan.MsnvLogin.ToString();
                lblHoTen.Text += info.TenNv;
                lblGioiTinh.Text += info.GioiTinh == false ? "Nam" : "Nữ";
                lblNgaySinh.Text += info.NgaySinh.ToString("dd/MM/yyyy");
                lblCMND.Text += info.Cmnd;
                lblDiaChi.Text += info.DiaChi;
                lblSoDienThoai.Text += info.SoDienThoai;
                lblNgayVaoLam.Text += info.NgayLamViec.ToString("dd/MM/yyyy");
            }
        }
    }
}

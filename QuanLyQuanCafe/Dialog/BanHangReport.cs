using System.Data;
using System.Globalization;
using System.Threading;
using BUS;
using CrystalDecisions.CrystalReports.Engine;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using QuanLyQuanCafe.Reports;
// ReSharper disable PossibleNullReferenceException

namespace QuanLyQuanCafe.Dialog
{
    public partial class BanHangReport : MaterialForm
    {
        public BanHangReport(BanHangDTO info)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal500,
                Accent.Red700, TextShade.WHITE);

            using (KhuVucBUS bus = new KhuVucBUS())
            {
                HoaDonBanHang hdbh = new HoaDonBanHang();
                var lblSoPhieu = hdbh.ReportDefinition.ReportObjects["lblSoPhieu"] as TextObject;
                lblSoPhieu.Text = "Số phiếu: " + info.SoHoaDon;
                var lblKhu = hdbh.ReportDefinition.ReportObjects["lblKhu"] as TextObject;
                lblKhu.Text = "Khu: " + bus.GetChiTiet(info.MaSoBan).Rows[0].Field<string>("TenKhuVuc");
                var lblBan = hdbh.ReportDefinition.ReportObjects["lblBan"] as TextObject;
                lblBan.Text = "Bàn: " + bus.GetChiTiet(info.MaSoBan).Rows[0].Field<string>("TenBan");
                var lblGioRa = hdbh.ReportDefinition.ReportObjects["lblGioRa"] as TextObject;
                lblGioRa.Text = "Giờ ra: " + info.GioRa.ToString("dd/MM/yyyy H:mm");

                var lblTongCong = hdbh.ReportDefinition.ReportObjects["lblTongCong"] as TextObject;
                lblTongCong.Text = info.ChuaThue.ToString("N0");
                var lblKhuyenMai = hdbh.ReportDefinition.ReportObjects["lblKhuyenMai"] as TextObject;
                lblKhuyenMai.Text = info.KhuyenMai + " %";
                var lblThanhToan = hdbh.ReportDefinition.ReportObjects["lblThanhToan"] as TextObject;
                lblThanhToan.Text = info.TongTien.ToString("N0");

                hdbh.SetDataSource(info.ChiTiet);
                crystalReportViewer1.ReportSource = hdbh;
                crystalReportViewer1.Refresh();
            }
        }
    }
}

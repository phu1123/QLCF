using System;
using System.Data;
using APP;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        private readonly DbConnection _dbconnection = new DbConnection();

        public HoaDonDAO()
        {
            _dbconnection.OpenConnection();
        }

        public void CloseConnection()
        {
            _dbconnection.CloseConnection();
        }

        public DataTable ListNhapHang()
        {
            const string sql = "SELECT SoHoaDon, NhaCungCap, NgayNhap, TongTien FROM HoaDonNhapHang";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable ListBanHang()
        {
            const string sql = "SELECT SoHoaDon, GioRa, TongTien FROM HoaDonBanHang";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable FilterBanHang(DateTime tungay, DateTime denngay)
        {
            string sql = $"SELECT SoHoaDon, GioRa, TongTien FROM HoaDonBanHang WHERE GioRa BETWEEN '{tungay.Date}' AND '{denngay.Date}'";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable FilterNhapHang(DateTime tungay, DateTime denngay)
        {
            string sql = $"SELECT SoHoaDon, NhaCungCap, NgayNhap, TongTien FROM HoaDonNhapHang WHERE NgayNhap BETWEEN '{tungay.Date}' AND '{denngay.Date}'";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable HoaDonBanHang(int sohoadon)
        {
            string sql = $"SELECT SoHoaDon, MaSoBan, GioRa, GhiChu, KhuyenMai, TongTien FROM HoaDonBanHang WHERE SoHoaDon=N'{sohoadon}'";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable ChiTietBanHang(int sohoadon)
        {
            string sql = $"SELECT TenHangHoa, DonGia, SoLuong, ThanhTien FROM ChiTietDonBanHang WHERE SoHoaDon=N'{sohoadon}'";
            return _dbconnection.ExcuteReader(sql);
        }
    }
}

using System;
using System.Data;
using APP;
using DTO;

namespace DAO
{
    public class QuanLyBanDAO
    {
        private readonly DbConnection _dbconnection = new DbConnection();

        public QuanLyBanDAO()
        {
            _dbconnection.OpenConnection();
        }

        public void CloseConnection()
        {
            _dbconnection.CloseConnection();
        }

        public DataTable LoadHangHoa(int masoban)
        {
            string sql = $"SELECT TenHangHoa, DonGia, SoLuong, ThanhTien FROM BanDangDung WHERE MaSoBan=N'{masoban}'";
            return _dbconnection.ExcuteReader(sql);
        }

        public int ExclTax(int masoban)
        {
            string sql = $"SELECT SUM(ThanhTien) FROM BanDangDung WHERE MaSoBan=N'{masoban}'";
            object exclTax = _dbconnection.ExecuteScalar(sql);
            return (int) (exclTax == DBNull.Value ? 0 : exclTax);
        }

        public void InsertHangHoa(string hanghoa, int masoban, string dongia)
        {
            string sql = $"INSERT INTO BanDangDung(TenHangHoa, MaSoBan, DonGia) VALUES(N'{hanghoa}', N'{masoban}', N'{dongia}')";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void UpdateSoLuong(int masoban, string tenhanghoa, string soluong)
        {
            string sql = $"UPDATE BanDangDung SET SoLuong=N'{soluong}' WHERE MaSoBan=N'{masoban}' AND TenHangHoa=N'{tenhanghoa}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void DeleteHangHoa(int masoban, string tenhanghoa)
        {
            string sql = $"DELETE FROM BanDangDung WHERE TenHangHoa=N'{tenhanghoa}' AND MaSoBan=N'{masoban}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void ClearHangHoa(int masoban)
        {
            string sql = $"DELETE FROM BanDangDung WHERE MaSoBan=N'{masoban}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public int GetSoHoaDon()
        {
            const string sql = "SELECT MAX(SoHoaDon) FROM HoaDonBanHang";
            object sohoadon = _dbconnection.ExecuteScalar(sql);
            return sohoadon == DBNull.Value ? 1 : (int) sohoadon + 1;
        }

        public void BanHang(BanHangDTO info)
        {
            string sql = $"INSERT INTO HoaDonBanHang VALUES(N'{info.SoHoaDon}', N'{info.Msnv}', N'{info.MaSoBan}', N'{info.GioRa}', N'{info.GhiChu}', N'{info.KhuyenMai}', N'{info.TongTien}')";
            _dbconnection.ExcuteNonQuery(sql);

            foreach (DataRow row in info.ChiTiet.Rows)
            {
                _dbconnection.ExcuteNonQuery($"INSERT INTO ChiTietDonBanHang VALUES(N'{info.SoHoaDon}', N'{row.Field<string>("TenHangHoa")}', N'{row.Field<int>("DonGia")}', N'{row.Field<int>("SoLuong")}', N'{row.Field<int>("ThanhTien")}')");
                _dbconnection.ExcuteNonQuery($"UPDATE HangHoa SET SoLuongTon=SoLuongTon - {row.Field<int>("SoLuong")} WHERE TenHangHoa=N'{row.Field<string>("TenHangHoa")}'");
            }
        }
    }
}

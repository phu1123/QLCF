using System;
using System.Data;
using APP;

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

        public DataTable LoadHangHoa(string masoban)
        {
            string sql = $"SELECT TenHangHoa, DonGia, SoLuong, ThanhTien FROM BanDangDung WHERE MaSoBan=N'{masoban}'";
            return _dbconnection.ExcuteReader(sql);
        }

        public int ExclTax(string masoban)
        {
            string sql = $"SELECT SUM(ThanhTien) FROM BanDangDung WHERE MaSoBan=N'{masoban}'";
            object exclTax = _dbconnection.ExecuteScalar(sql);
            return (int) (exclTax == DBNull.Value ? 0 : exclTax);
        }

        public void InsertHangHoa(string hanghoa, string masoban, string dongia)
        {
            string sql = $"INSERT INTO BanDangDung(TenHangHoa, MaSoBan, DonGia) VALUES(N'{hanghoa}', N'{masoban}', N'{dongia}')";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void UpdateSoLuong(string masoban, string tenhanghoa, string soluong)
        {
            string sql = $"UPDATE BanDangDung SET SoLuong=N'{soluong}' WHERE MaSoBan=N'{masoban}' AND TenHangHoa=N'{tenhanghoa}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void DeleteHangHoa(string masoban, string tenhanghoa)
        {
            string sql = $"DELETE FROM BanDangDung WHERE TenHangHoa=N'{tenhanghoa}' AND MaSoBan=N'{masoban}'";
            _dbconnection.ExcuteNonQuery(sql);
        }


    }
}

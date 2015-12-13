using System;
using System.Data;
using APP;
using DTO;

namespace DAO
{
    public class HangHoaDAO
    {
        private readonly DbConnection _dbconnection = new DbConnection();

        public HangHoaDAO()
        {
            _dbconnection.OpenConnection();
        }

        public void CloseConnection()
        {
            _dbconnection.CloseConnection();
        }

        public DataTable ListHangHoa()
        {
            const string sql = "SELECT TenHangHoa, GiaBan, DonViTinh, SoLuongTon FROM HangHoa";        
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable ListHangHoa2()
        {
            const string sql = "SELECT TenHangHoa, GiaBan, SoLuongTon FROM HangHoa";
            return _dbconnection.ExcuteReader(sql);
        }

        public void DeleteHangHoa(string tenhanghoa)
        {
            string sql = $"DELETE FROM HangHoa WHERE TenHangHoa=N'{tenhanghoa}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void InsertHangHoa(HangHoaDTO info)
        {
            string sql = $"INSERT INTO HangHoa VALUES(N'{info.TenHangHoa}', N'{info.GiaBan}', N'{info.DonViTinh}', N'{info.SoLuongTon}', N'{info.GhiChu}')";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void EditHangHoa(HangHoaDTO info, string tenhanghoa)
        {
            string sql = $"UPDATE HangHoa SET TenHangHoa=N'{info.TenHangHoa}', GiaBan=N'{info.GiaBan}', DonViTinh=N'{info.DonViTinh}', SoLuongTon=N'{info.SoLuongTon}', GhiChu=N'{info.GhiChu}' WHERE TenHangHoa=N'{tenhanghoa}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public HangHoaDTO LoadHangHoa(string tenhanghoa)
        {
            string sql = $"SELECT * FROM HangHoa WHERE TenHangHoa = N'{tenhanghoa}'";
            DataTable infoTable = _dbconnection.ExcuteReader(sql);

            return new HangHoaDTO
            {
                TenHangHoa = infoTable.Rows[0]["TenHangHoa"].ToString(),
                GiaBan = Convert.ToInt32(infoTable.Rows[0]["GiaBan"]),
                DonViTinh = infoTable.Rows[0]["DonViTinh"].ToString(),
                SoLuongTon = Convert.ToInt32(infoTable.Rows[0]["SoLuongTon"]),
                GhiChu = infoTable.Rows[0]["GhiChu"].ToString()
            };
        }

    }
}

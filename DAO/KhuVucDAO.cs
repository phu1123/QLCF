using System.Data;
using APP;

namespace DAO
{
    public class KhuVucDAO
    {
        private readonly DbConnection _dbconnection = new DbConnection();

        public KhuVucDAO()
        {
            _dbconnection.OpenConnection();
        }

        public void CloseConnection()
        {
            _dbconnection.CloseConnection();
        }

        public DataTable ListKhuVuc()
        {
            const string sql = "SELECT TenKhuVuc FROM KhuVuc";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable ListBan(string khuvuc)
        {
            string sql = $"SELECT MaSoBan, TenBan FROM Ban WHERE TenKhuVuc=N'{khuvuc}'";
            return _dbconnection.ExcuteReader(sql);
        }

        public void DeleteKhuVuc(string khuvuc)
        {
            string sql = $"DELETE FROM KhuVuc WHERE TenKhuVuc=N'{khuvuc}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void InsertKhuVuc(string khuvuc)
        {
            string sql = $"INSERT INTO KhuVuc VALUES(N'{khuvuc}')";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void DeleteBan(string masoban)
        {
            string sql = $"DELETE FROM Ban WHERE MaSoBan = N'{masoban}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void InsertBan(string khuvuc, string tenban)
        {
            string sql = $"INSERT INTO Ban(TenBan, TenKhuVuc) VALUES(N'{tenban}', N'{khuvuc}')";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public bool IsAvailable(string masoban)
        {
            string sql = $"SELECT COUNT(*) FROM BanDangDung WHERE MaSoBan=N'{masoban}'";
            return (int)_dbconnection.ExecuteScalar(sql) == 0;
        }

        public DataTable GetChiTiet(int masoban)
        {
            string sql = $"SELECT TenBan, TenKhuVuc FROM Ban WHERE MaSoBan=N'{masoban}'";
            return _dbconnection.ExcuteReader(sql);
        }
    }
}

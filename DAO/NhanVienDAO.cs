using System;
using System.Data;
using APP;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        readonly DbConnection _dbconnection = new DbConnection();

        public NhanVienDAO()
        {
            _dbconnection.OpenConnection();
        }

        public void CloseConnection()
        {
            _dbconnection.CloseConnection();
        }

        public DataTable ListNhanVien()
        {
            const string sql = "SELECT NhanVien.MSNV, TenNV, SoDienThoai, TaiKhoan.PhanQuyen FROM NhanVien " +
                               "INNER JOIN TaiKhoan ON NhanVien.MSNV = TaiKhoan.MSNV";
            return _dbconnection.ExcuteReader(sql);
        }

        public DataTable LoginCredentials()
        {
            const string sql = "SELECT * FROM TaiKhoan";
            return _dbconnection.ExcuteReader(sql);
        }

        public NhanVienDTO LoadNhanVien(string msnv)
        {
            string sql = $"SELECT * FROM NhanVien, TaiKhoan WHERE NhanVien.MSNV = TaiKhoan.MSNV AND TaiKhoan.MSNV = '{msnv}'";
            DataTable infoTable = _dbconnection.ExcuteReader(sql);

            return new NhanVienDTO
            {
                UserName = infoTable.Rows[0]["TenDangNhap"].ToString(),
                Password = infoTable.Rows[0]["MatKhau"].ToString(),
                FullName = infoTable.Rows[0]["TenNV"].ToString(),
                Gender = (bool)infoTable.Rows[0]["GioiTinh"],
                Birthday = Convert.ToDateTime(infoTable.Rows[0]["NgaySinh"]),
                CMND = infoTable.Rows[0]["CMND"].ToString(),
                Address = infoTable.Rows[0]["DiaChi"].ToString(),
                Phone = infoTable.Rows[0]["SoDienThoai"].ToString(),
                WorkSince = Convert.ToDateTime(infoTable.Rows[0]["NgayVaoLam"]),
                Position = (bool)infoTable.Rows[0]["PhanQuyen"]
            };
        }

        public void DeleteNhanVien(string msnv)
        {
            string sql = $"DELETE FROM NhanVien WHERE MSNV='{msnv}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public bool IsUserNameExist(string username)
        {
            string sql = $"SELECT TenDangNhap FROM TaiKhoan WHERE TenDangNhap='{username}'";
            return _dbconnection.ExecuteScalar(sql) != null;
        }

        public void InsertNhanVien(NhanVienDTO info)
        {
            string sql = "INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, CMND, NgayVaoLam) " +
                        $"VALUES(N'{info.FullName}', '{info.Gender}', '{info.Birthday}', N'{info.Address}', '{info.Phone}', '{info.CMND}', '{info.WorkSince}'); SELECT SCOPE_IDENTITY()";
            string msnv = _dbconnection.ExecuteScalar(sql).ToString();
            _dbconnection.ExcuteNonQuery($"INSERT INTO TaiKhoan VALUES('{info.UserName}', '{msnv}', '{info.Password}', '{info.Position}')");
        }

        public void EditNhanVien(NhanVienDTO info, string msnv)
        {
            string sql = $"UPDATE NhanVien SET TenNV=N'{info.FullName}', GioiTinh='{info.Gender}', NgaySinh='{info.Birthday}', DiaChi=N'{info.Address}', SoDienThoai='{info.Phone}', CMND='{info.CMND}', NgayVaoLam='{info.WorkSince}' " +
                         $"WHERE MSNV='{msnv}'";
            _dbconnection.ExcuteNonQuery(sql);
            _dbconnection.ExcuteNonQuery($"UPDATE TaiKhoan SET TenDangNhap='{info.UserName}', MatKhau='{info.Password}', PhanQuyen='{info.Position}' WHERE MSNV='{msnv}'");
        }
    }
}

using System;
using System.Data;
using APP;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        private readonly DbConnection _dbconnection = new DbConnection();

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
            string sql = $"SELECT * FROM NhanVien, TaiKhoan WHERE NhanVien.MSNV = TaiKhoan.MSNV AND TaiKhoan.MSNV = N'{msnv}'";
            DataTable infoTable = _dbconnection.ExcuteReader(sql);

            return new NhanVienDTO
            {
                TenDangNhap = infoTable.Rows[0]["TenDangNhap"].ToString(),
                MatKhau = infoTable.Rows[0]["MatKhau"].ToString(),
                TenNv = infoTable.Rows[0]["TenNV"].ToString(),
                GioiTinh = (bool)infoTable.Rows[0]["GioiTinh"],
                NgaySinh = Convert.ToDateTime(infoTable.Rows[0]["NgaySinh"]),
                Cmnd = infoTable.Rows[0]["CMND"].ToString(),
                DiaChi = infoTable.Rows[0]["DiaChi"].ToString(),
                SoDienThoai = infoTable.Rows[0]["SoDienThoai"].ToString(),
                NgayLamViec = Convert.ToDateTime(infoTable.Rows[0]["NgayVaoLam"]),
                PhanQuyen = (bool)infoTable.Rows[0]["PhanQuyen"]
            };
        }

        public void DeleteNhanVien(string msnv)
        {
            string sql = $"DELETE FROM NhanVien WHERE MSNV=N'{msnv}'";
            _dbconnection.ExcuteNonQuery(sql);
        }

        public void InsertNhanVien(NhanVienDTO info)
        {
            string sql = "INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, CMND, NgayVaoLam) " +
                        $"VALUES(N'{info.TenNv}', N'{info.GioiTinh}', N'{info.NgaySinh}', N'{info.DiaChi}', N'{info.SoDienThoai}', N'{info.Cmnd}', N'{info.NgayLamViec}'); SELECT SCOPE_IDENTITY()";
            string msnv = _dbconnection.ExecuteScalar(sql).ToString();
            _dbconnection.ExcuteNonQuery($"INSERT INTO TaiKhoan VALUES(N'{info.TenDangNhap}', N'{msnv}', N'{info.MatKhau}', N'{info.PhanQuyen}')");
        }

        public void EditNhanVien(NhanVienDTO info, string msnv)
        {
            string sql = $"UPDATE NhanVien SET TenNV=N'{info.TenNv}', GioiTinh=N'{info.GioiTinh}', NgaySinh=N'{info.NgaySinh}', DiaChi=N'{info.DiaChi}', SoDienThoai=N'{info.SoDienThoai}', CMND=N'{info.Cmnd}', NgayVaoLam=N'{info.NgayLamViec}' " +
                         $"WHERE MSNV=N'{msnv}'";
            _dbconnection.ExcuteNonQuery(sql);
            _dbconnection.ExcuteNonQuery($"UPDATE TaiKhoan SET TenDangNhap=N'{info.TenDangNhap}', MatKhau=N'{info.MatKhau}', PhanQuyen=N'{info.PhanQuyen}' WHERE MSNV=N'{msnv}'");
        }

        public void DoiMatKhau(int msnv, string matkhaumoi)
        {
            string sql = $"UPDATE TaiKhoan SET MatKhau=N'{matkhaumoi}' WHERE MSNV=N'{msnv}'";
            _dbconnection.ExcuteNonQuery(sql);
        }
    }
}

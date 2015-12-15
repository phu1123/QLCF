
using System.Data;
using APP;
using DTO;

namespace DAO
{
    public class NhapHangDAO
    {
        private readonly DbConnection _dbconnection = new DbConnection();

        public NhapHangDAO()
        {
            _dbconnection.OpenConnection();
        }

        public void CloseConnection()
        {
            _dbconnection.CloseConnection();
        }

        public void NhapHang(NhapHangDTO info)
        {
            string sql = $"INSERT INTO HoaDonNhapHang VALUES(N'{info.SoHoaDon}', N'{info.Msnv}', N'{info.NgayNhap}', N'{info.NhaCungCap}', N'{info.DiaChi}', N'{info.Thue}', N'{info.TongTien}', N'{info.GhiChu}')";
            _dbconnection.ExcuteNonQuery(sql);

            foreach (DataRow row in info.ChiTiet.Rows)
            {
                _dbconnection.ExcuteNonQuery($"INSERT INTO ChiTietDonNhapHang VALUES(N'{info.SoHoaDon}', N'{row.Field<string>("TenHangHoa")}', N'{row.Field<string>("GiaMua")}', N'{row.Field<string>("SoLuong")}', N'{row.Field<string>("ThanhTien")}')");
                _dbconnection.ExcuteNonQuery($"UPDATE HangHoa SET SoLuongTon=SoLuongTon + {row.Field<string>("SoLuong")} WHERE TenHangHoa=N'{row.Field<string>("TenHangHoa")}'");
            }


        }
    }
}

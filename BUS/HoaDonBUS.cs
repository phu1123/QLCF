using System;
using System.Data;
using DAO;

namespace BUS
{
    public class HoaDonBUS : IDisposable
    {
        private readonly HoaDonDAO _hoadonDAO = new HoaDonDAO();

        public void Dispose()
        {
            _hoadonDAO.CloseConnection();
        }

        public DataTable ListNhapHang()
        {
            return _hoadonDAO.ListNhapHang();
        }

        public DataTable ListBanHang()
        {
            return _hoadonDAO.ListBanHang();
        }

        public DataTable FilterBanHang(DateTime tungay, DateTime denngay)
        {
            return _hoadonDAO.FilterBanHang(tungay, denngay);
        }

        public DataTable FilterNhapHang(DateTime tungay, DateTime denngay)
        {
            return _hoadonDAO.FilterNhapHang(tungay, denngay);
        }

    }
}

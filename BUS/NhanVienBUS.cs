using System;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVienBUS : IDisposable
    {
        private readonly NhanVienDAO _nhanvienDAO = new NhanVienDAO();

        public void Dispose()
        {
            _nhanvienDAO.CloseConnection();
        }

        public DataTable ListNhanVien()
        {
            return _nhanvienDAO.ListNhanVien();
        }

        public DataTable LoginCredentials()
        {
            return _nhanvienDAO.LoginCredentials();
        }

        public NhanVienDTO LoadNhanVien(string msnv)
        {
            return _nhanvienDAO.LoadNhanVien(msnv);
        }

        public void DeleteNhanVien(string msnv)
        {
            _nhanvienDAO.DeleteNhanVien(msnv);
        }

        public bool IsUserNameExist(string username)
        {
            return _nhanvienDAO.IsUserNameExist(username);
        }

        public void InsertNhanVien(NhanVienDTO info)
        {
            _nhanvienDAO.InsertNhanVien(info);
        }

        public void EditNhanVien(NhanVienDTO info, string msnv)
        {
            _nhanvienDAO.EditNhanVien(info, msnv);
        }
    }
}
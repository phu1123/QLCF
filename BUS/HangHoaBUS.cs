using System;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class HangHoaBUS : IDisposable
    {
        private readonly HangHoaDAO _hanghoaDAO = new HangHoaDAO();

        public void Dispose()
        {
            _hanghoaDAO.CloseConnection();
        }

        public DataTable ListHangHoa()
        {
            return _hanghoaDAO.ListHangHoa();
        }

        public DataTable ListHangHoa2()
        {
            return _hanghoaDAO.ListHangHoa2();
        }

        public void DeleteHangHoa(string tenhanghoa)
        {
            _hanghoaDAO.DeleteHangHoa(tenhanghoa);
        }

        public void InsertHangHoa(HangHoaDTO info)
        {
            _hanghoaDAO.InsertHangHoa(info);
        }

        public void EditHangHoa(HangHoaDTO info, string tenhanghoa)
        {
            _hanghoaDAO.EditHangHoa(info, tenhanghoa);
        }

        public HangHoaDTO LoadHangHoa(string tenhanghoa)
        {
            return _hanghoaDAO.LoadHangHoa(tenhanghoa);
        }

        public void NhapHang(NhapHangDTO info)
        {
            _hanghoaDAO.NhapHang(info);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhapHangBUS : IDisposable
    {
        private readonly NhapHangDAO _nhaphangDAO = new NhapHangDAO();

        public void Dispose()
        {
            _nhaphangDAO.CloseConnection();
        }

        public void NhapHang(NhapHangDTO info)
        {
            _nhaphangDAO.NhapHang(info);
        }
    }
}

﻿using System;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class QuanLyBanBUS : IDisposable
    {
        private readonly QuanLyBanDAO _quanlybanDAO = new QuanLyBanDAO();
        public static int Masoban { get; set; }

        public void Dispose()
        {
            _quanlybanDAO.CloseConnection();
        }

        public DataTable LoadHangHoa()
        {
            return _quanlybanDAO.LoadHangHoa(Masoban);
        }

        public int ExclTax()
        {
            return _quanlybanDAO.ExclTax(Masoban);
        }

        public void InsertHangHoa(string hanghoa, string dongia)
        {
            _quanlybanDAO.InsertHangHoa(hanghoa, Masoban, dongia);
        }

        public void UpdateSoLuong(string tenhanghoa,string soluong)
        {
            _quanlybanDAO.UpdateSoLuong(Masoban, tenhanghoa, soluong);
        }

        public void DeleteHangHoa(string tenhanghoa)
        {
            _quanlybanDAO.DeleteHangHoa(Masoban, tenhanghoa);
        }

        public void ClearHangHoa()
        {
            _quanlybanDAO.ClearHangHoa(Masoban);
        }

        public int GetSoHoaDon()
        {
            return _quanlybanDAO.GetSoHoaDon();
        }

        public void BanHang(BanHangDTO info)
        {
            _quanlybanDAO.BanHang(info);
        }
    }
}

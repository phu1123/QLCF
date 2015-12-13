using System;
using System.Data;

namespace DTO
{
    public class NhapHangDTO
    {
        public string SoHoaDon { get; set; }
        public int Msnv { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public DataTable ChiTiet { get; set; }
        public decimal Thue { get; set; }
        public int TongTien { get; set; }
    }
}

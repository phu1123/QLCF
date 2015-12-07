using System;

namespace DTO
{
    public class NhanVienDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenNv { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Cmnd { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayLamViec { get; set; }
        public bool PhanQuyen { get; set; }
    }
}
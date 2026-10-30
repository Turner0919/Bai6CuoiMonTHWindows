using System;
using System.Collections.Generic;
using System.Text;

namespace HeThongBanHang.BLL
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public string TrangThai { get; set; }
        public decimal TongTien { get; set; }
    }

    public class ChiTietHoaDonDTO
    {
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using HeThongBanHang.DAL;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.BLL
{
    public class HoaDonBLL
    {
        private readonly HoaDonDAL _hdDAL = new HoaDonDAL();

        public bool TaoDonHang(string sdtKH, List<GioHangItem> gioHang, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(sdtKH))
            {
                errorMessage = "Chưa chọn khách hàng!";
                return false;
            }

            if (gioHang == null || gioHang.Count == 0)
            {
                errorMessage = "Giỏ hàng đang trống! Vui lòng thêm sản phẩm.";
                return false;
            }

            HoaDon hd = new HoaDon
            {
                SoDienThoaiKH = sdtKH,
                NgayLap = DateTime.Now,
                TrangThai = "Đang Xử Lý",
                TongTien = 0
            };

            List<ChiTietHoaDon> dsChiTiet = new List<ChiTietHoaDon>();
            foreach (var item in gioHang)
            {
                hd.TongTien += item.ThanhTien;
                dsChiTiet.Add(new ChiTietHoaDon
                {
                    MaSP = item.MaSP,
                    SoLuong = item.SoLuong,
                    DonGia = item.DonGia
                });
            }

            try
            {
                return _hdDAL.TaoHoaDon(hd, dsChiTiet);
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi khi lưu đơn hàng: {ex.Message}";
                return false;
            }
        }

        public List<HoaDonDTO> GetAllOrders()
        {
            var list = _hdDAL.GetAll();
            return list.Select(h => new HoaDonDTO
            {
                MaHD = h.MaHD,
                TenKhachHang = h.KhachHang != null ? h.KhachHang.HoTen : h.SoDienThoaiKH,
                NgayLap = h.NgayLap,
                TrangThai = string.IsNullOrEmpty(h.TrangThai) ? "Đang Xử Lý" : h.TrangThai,
                TongTien = h.TongTien
            }).ToList();
        }

        public List<ChiTietHoaDonDTO> GetOrderDetails(int maHD)
        {
            var list = _hdDAL.GetChiTietByMaHD(maHD);
            return list.Select(c => new ChiTietHoaDonDTO
            {
                TenSP = c.SanPham != null ? c.SanPham.TenSP : c.MaSP,
                SoLuong = c.SoLuong,
                DonGia = c.DonGia
            }).ToList();
        }

        public bool CancelOrder(int maHD, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                if (!_hdDAL.HuyHoaDon(maHD))
                {
                    errorMessage = "Đơn hàng không tồn tại hoặc đã được hủy trước đó!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi khi hủy đơn hàng: {ex.Message}";
                return false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.DAL
{
    public class HoaDonDAL
    {
        public bool TaoHoaDon(HoaDon hd, List<ChiTietHoaDon> dsChiTiet)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (string.IsNullOrEmpty(hd.TrangThai))
                        {
                            hd.TrangThai = "Đang Xử Lý";
                        }

                        db.HoaDons.Add(hd);
                        db.SaveChanges();

                        foreach (var ct in dsChiTiet)
                        {
                            ct.MaHD = hd.MaHD;
                            db.ChiTietHoaDons.Add(ct);

                            var sp = db.SanPhams.Find(ct.MaSP);
                            if (sp != null)
                            {
                                sp.SLTon -= ct.SoLuong; // Trừ kho khi đặt hàng
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<HoaDon> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.HoaDons
                         .Include(h => h.KhachHang)
                         .AsNoTracking()
                         .OrderByDescending(h => h.NgayLap)
                         .ToList();
            }
        }

        public List<ChiTietHoaDon> GetChiTietByMaHD(int maHD)
        {
            using (var db = new AppDbContext())
            {
                return db.ChiTietHoaDons
                         .Include(c => c.SanPham)
                         .Where(c => c.MaHD == maHD)
                         .AsNoTracking()
                         .ToList();
            }
        }

        // HỦY ĐƠN HÀNG: CẬP NHẬT TRẠNG THÁI VÀ CỘNG NGƯỢC TỒN KHO
        public bool HuyHoaDon(int maHD)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var hd = db.HoaDons.FirstOrDefault(h => h.MaHD == maHD);
                        if (hd == null || hd.TrangThai == "Đã Hủy")
                            return false;

                        // 1. Cập nhật trạng thái
                        hd.TrangThai = "Đã Hủy";

                        // 2. Lấy danh sách chi tiết đơn hàng để cộng trả lại kho
                        var dsChiTiet = db.ChiTietHoaDons.Where(c => c.MaHD == maHD).ToList();
                        foreach (var ct in dsChiTiet)
                        {
                            var sp = db.SanPhams.FirstOrDefault(s => s.MaSP == ct.MaSP);
                            if (sp != null)
                            {
                                sp.SLTon += ct.SoLuong; // Cộng trả lại số lượng vào tồn kho
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
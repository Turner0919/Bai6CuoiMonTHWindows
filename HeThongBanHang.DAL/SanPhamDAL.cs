using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.DAL
{
    public class SanPhamDAL
    {
        // Lấy toàn bộ danh sách sản phẩm (không tracking để tối ưu hiệu năng)
        public List<SanPham> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.SanPhams.AsNoTracking().ToList();
            }
        }

        // Lấy thông tin sản phẩm theo Mã SP
        public SanPham GetById(string maSP)
        {
            using (var db = new AppDbContext())
            {
                return db.SanPhams.AsNoTracking().FirstOrDefault(p => p.MaSP == maSP);
            }
        }

        // Thêm mới sản phẩm (Có kiểm tra trùng mã SP)
        public bool Add(SanPham sp)
        {
            using (var db = new AppDbContext())
            {
                // Kiểm tra xem Mã SP đã tồn tại trong DB chưa
                bool isExist = db.SanPhams.Any(p => p.MaSP == sp.MaSP);
                if (isExist)
                {
                    return false; // Trả về false nếu đã tồn tại
                }

                db.SanPhams.Add(sp);
                return db.SaveChanges() > 0;
            }
        }

        // Cập nhật thông tin sản phẩm
        public bool Update(SanPham sp)
        {
            using (var db = new AppDbContext())
            {
                var existingSP = db.SanPhams.FirstOrDefault(p => p.MaSP == sp.MaSP);
                if (existingSP != null)
                {
                    existingSP.TenSP = sp.TenSP;
                    existingSP.DonGia = sp.DonGia;
                    existingSP.SLTon = sp.SLTon;
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }

        // Xóa sản phẩm theo Mã SP
        public bool Delete(string maSP)
        {
            using (var db = new AppDbContext())
            {
                var sp = db.SanPhams.FirstOrDefault(p => p.MaSP == maSP);
                if (sp != null)
                {
                    db.SanPhams.Remove(sp);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
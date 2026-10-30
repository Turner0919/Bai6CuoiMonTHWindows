using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHang> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.KhachHangs.AsNoTracking().ToList();
            }
        }

        public KhachHang GetBySDT(string sdt)
        {
            using (var db = new AppDbContext())
            {
                return db.KhachHangs.AsNoTracking().FirstOrDefault(k => k.SoDienThoai == sdt);
            }
        }

        public bool Add(KhachHang kh)
        {
            using (var db = new AppDbContext())
            {
                if (db.KhachHangs.Any(k => k.SoDienThoai == kh.SoDienThoai))
                    return false; // Số điện thoại đã tồn tại

                db.KhachHangs.Add(kh);
                return db.SaveChanges() > 0;
            }
        }

        public bool Update(KhachHang kh)
        {
            using (var db = new AppDbContext())
            {
                var existing = db.KhachHangs.FirstOrDefault(k => k.SoDienThoai == kh.SoDienThoai);
                if (existing == null)
                    return false;

                existing.HoTen = kh.HoTen;
                return db.SaveChanges() > 0;
            }
        }

        public bool Delete(string sdt)
        {
            using (var db = new AppDbContext())
            {
                var existing = db.KhachHangs.FirstOrDefault(k => k.SoDienThoai == sdt);
                if (existing == null)
                    return false;

                db.KhachHangs.Remove(existing);
                return db.SaveChanges() > 0;
            }
        }
    }
}
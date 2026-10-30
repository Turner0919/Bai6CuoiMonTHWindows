using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.DAL
{
    public class SanPhamDAL
    {
        public List<SanPham> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.SanPhams.ToList();
            }
        }

        public SanPham GetById(string maSP)
        {
            using (var db = new AppDbContext())
            {
                return db.SanPhams.FirstOrDefault(p => p.MaSP == maSP);
            }
        }

        public bool Add(SanPham sp)
        {
            using (var db = new AppDbContext())
            {
                db.SanPhams.Add(sp);
                return db.SaveChanges() > 0;
            }
        }

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

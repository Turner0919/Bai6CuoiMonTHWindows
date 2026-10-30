using HeThongBanHang.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeThongBanHang.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=Lab06_CuoiMon;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<SanPham> SanPhams { get; set; }
    }
}

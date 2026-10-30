using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HeThongBanHang.DAL.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [StringLength(20)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSP { get; set; }

        public decimal DonGia { get; set; }

        public int SLTon { get; set; }
    }
}

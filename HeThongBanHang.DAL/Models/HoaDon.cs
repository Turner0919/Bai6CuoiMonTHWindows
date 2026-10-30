using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeThongBanHang.DAL.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }

        public DateTime NgayLap { get; set; } = DateTime.Now;

        [Required]
        [StringLength(15)]
        public string SoDienThoaiKH { get; set; }

        [ForeignKey("SoDienThoaiKH")]
        public virtual KhachHang KhachHang { get; set; }

        public decimal TongTien { get; set; }
        // BỔ SUNG TRƯỜNG TRẠNG THÁI MẶC ĐỊNH
        [StringLength(50)]
        public string TrangThai { get; set; } = "Đang Xử Lý";

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
    }
}
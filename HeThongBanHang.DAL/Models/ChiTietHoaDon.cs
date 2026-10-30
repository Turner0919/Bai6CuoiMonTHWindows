using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeThongBanHang.DAL.Models
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
        // Bỏ [Key] ở đây
        public int MaHD { get; set; }

        // Bỏ [Key] ở đây
        [StringLength(20)]
        public string MaSP { get; set; }

        [ForeignKey("MaHD")]
        public virtual HoaDon HoaDon { get; set; }

        [ForeignKey("MaSP")]
        public virtual SanPham SanPham { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        [NotMapped] // Không lưu cột tính toán này vào CSDL
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
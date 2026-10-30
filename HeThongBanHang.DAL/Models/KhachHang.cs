using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeThongBanHang.DAL.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }
    }
}
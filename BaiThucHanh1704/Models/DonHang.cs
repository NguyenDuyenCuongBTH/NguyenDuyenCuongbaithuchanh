using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh1704
{
    public class DonHang
    {
        [Key]
        public string MaDonHang { get; set; }
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham? SanPham { get; set; }
    }
}
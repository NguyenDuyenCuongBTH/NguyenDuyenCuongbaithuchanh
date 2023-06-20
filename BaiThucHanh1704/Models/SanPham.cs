using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh1704
{
    public class SanPham
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MauSac { get; set; }
    }
}
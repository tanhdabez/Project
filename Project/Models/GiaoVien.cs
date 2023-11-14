using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class GiaoVien
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? MaGiaoVien { get; set; }
        public string? TenGV { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? IdCCCD { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? TrinhDo { get; set; }
        public int? SoTaiKhoan { get; set; }
        public string? NganHang { get; set; }
        public string? MaSoThue { get; set; }
        public bool? TrangThai { get; set; }
        [NotMapped]
        public string? IdCaHoc { get; set; }
        [NotMapped]
        public List<ListDonGia> ListDonGias { get; set; }



    }
}

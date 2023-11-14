using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class HocVien
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? MaHocVien { get; set; }
        public string? TenHocVien { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? TrangThai { get; set; }
        public string? TenCha { get; set; }
        public string? SDTCha { get; set; }
        public string? EmailCha { get; set; }
        public string? TenMe { get; set; }
        public string? SDTMe { get; set; }
        public string? EmailMe { get; set; }
        [NotMapped]
        public LopHocVien lopHocVien { get; set; }


    }
    public class HocVienViewModels
    {
        public string IdHocVien { get; set; }
        public string? MaHocVien { get; set; }
        public string? TenHocVien { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? TrangThai { get; set; }
        public string IdLopHoc { get; set; }
        public string? MaLopHoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        [MaxLength(36)]
        public string? IdGVien { get; set; }
        [MaxLength(36)]
        public string? IdMonHoc { get; set; }
        [MaxLength(36)]
        public string? IdPhongHoc { get; set; }
        [MaxLength(36)]
        public string? IdCaHoc { get; set; }
    }
}

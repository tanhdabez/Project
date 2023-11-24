using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class TKB
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public DateTime NgayHoc { get; set; }
        public string? IdLop { get; set; }

        public string? IdGVien { get; set; }

        public string? IdCaHoc { get; set; }
        public string? IdPhongHoc { get; set; }
        public string? IdMonHoc { get; set; }
        public double? HocPhi { get; set; }
        public string? TrangThai { get; set; }

        [NotMapped]
        public double NgayHocUnix { get; set; }
        [NotMapped]
        public string MaPhongHoc { get; set; }
        [NotMapped]
        public string TenLop { get; set; }
        [NotMapped]
        public string TenGvien { get; set; }
        [NotMapped]
        public string Thu { get; set; }

    }
    
}

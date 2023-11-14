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
        [MaxLength(36)]
        public string? IdLop { get; set; }

        [MaxLength(36)]
        public string? IdGVien { get; set; }

        [MaxLength(36)]
        public string? IdCaHoc { get; set; }
        [MaxLength(36)]
        public string? IdPhongHoc { get; set; }

        [MaxLength(36)]
        public string? IdMonHoc { get; set; }
        [MaxLength(36)]
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

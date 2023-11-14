using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class CaHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public DateTime? ThuBatDau { get; set; }
        public DateTime? ThuKetThuc { get; set; }
        public DateTime? ThoiGian { get; set; }
        [NotMapped]
        public string? IdGVien { get; set; }
    }
}

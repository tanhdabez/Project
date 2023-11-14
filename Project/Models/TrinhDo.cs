using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class TrinhDo
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? MaTrinhDo { get; set; }
        public string? TenTrinhDo { get; set; }
        [MaxLength(36)]
        public string? IdGiaoVien { get; set; }
    }
}

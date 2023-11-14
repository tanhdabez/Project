using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class MonHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? MaMonHoc { get; set; }
        public string? TenMonHoc { get; set; }

    }
}

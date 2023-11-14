using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class LopHocVien
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        [MaxLength(36)]
        public string? IdLop { get; set; }
        [MaxLength(36)]
        public string? IdHocVien { get; set; }

    }
}

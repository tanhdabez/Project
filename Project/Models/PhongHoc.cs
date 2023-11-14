using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class PhongHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? MaPhongHoc { get; set; }
        public string? TenPhongHoc { get; set; }

        [NotMapped]
        public List<DungCuPhongHoc> DungCuPhongs { get; set; }
    }
}

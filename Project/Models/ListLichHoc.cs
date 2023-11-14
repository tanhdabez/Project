using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ListLichHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        [MaxLength(36)]
        public string? IdLopHoc { get; set; }
        [MaxLength(36)]
        public string? IdGVien { get; set; }
        [MaxLength(36)]
        public string? IdMonHoc { get; set; }
        [MaxLength(36)]
        public string? IdCaHoc { get; set; }
        [MaxLength(36)]
        public string? IdPhongHoc { get; set; }
        public int? Thu { get; set; }
        public double? GioBatDau { get; set; }
        public double? GioKetThuc { get; set; }
    }
}

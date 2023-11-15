using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ListLichHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? IdLopHoc { get; set; }
        public string? IdGVien { get; set; }
        public string? IdMonHoc { get; set; }
        public string? IdCaHoc { get; set; }
        public string? IdPhongHoc { get; set; }
        public int? Thu { get; set; }
        public int? HocPhi { get; set; }
        public double? GioBatDau { get; set; }
        public double? GioKetThuc { get; set; }
    }
}

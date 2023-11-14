using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class LopHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string? MaLopHoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        [MaxLength(36)]
        public string? IdGVien { get; set; }
        [MaxLength(36)]
        public string? IdHocVien { get; set; }
        [MaxLength(36)]
        public string? IdMonHoc { get; set; }
        [MaxLength(36)]
        public string? IdPhongHoc { get; set; }
        [MaxLength(36)]
        public string? IdCaHoc { get; set; }
        [MaxLength(36)]
        public string? TrangThai { get; set; }

        [NotMapped]
        public string? TenGVien { get; set; }
        [NotMapped]
        public string? TenMonHoc { get; set; }
        [NotMapped]
        public string? TenHocVien { get; set; }
        [NotMapped]
        public List<ListLichHoc> ListLichHocs { get; set; }
    }
    public class Lop_SoBuoiConLai
    {
        public int SobuoiDuKien { get; set; }
        public int SoBuoiConLaiKyTruoc { get; set; }
        public int SoBuoiThucTe { get; set; }
        public double TienThuaKyTruoc { get; set; }
        public double ThanhTienThucTe { get; set; }

    }
}

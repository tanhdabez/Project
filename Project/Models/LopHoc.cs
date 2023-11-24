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
        public string? IdGVien { get; set; }
        public string? IdHocVien { get; set; }
        public string? IdMonHoc { get; set; }
        public string? IdPhongHoc { get; set; }
        public string? IdCaHoc { get; set; }
        public double? SoHocVien { get; set; }
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
        public double? HocPhi { get; set; }
        public double? GioBatDau { get; set; }
        public double? GioKetThuc { get; set; }
    }
    public class Lop_SoBuoiConLai
    {
        public int SobuoiDuKien { get; set; }
        public int SoBuoiConLaiKyTruoc { get; set; }
        public int SoBuoiThucTe { get; set; }
        public double TienThuaKyTruoc { get; set; }
        public double ThanhTienThucTe { get; set; }

    }
    public class Lop_Thu
    {
        public string Thu { get; set; }
        public int Lan { get; set; }
    }
}

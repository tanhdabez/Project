using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class HocPhi
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string MaHocVien { get; set; }
        public string TenHocVien { get; set; }
        public string TrangThai { get; set; }
        public string HocPhiCanDong { get; set; }
        public List<BuoiConLai> SoBuoiConLai { get; set; }
    }
    public class HocPhi_HocVien
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string TenHocVien { get; set; }
        public string MaHocVien { get; set; }
        public bool GiaGoc { get; set; } = false;
        public int GioiTinh { get; set; }
        public double NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public string TrangThai { get; set; }

        [NotMapped]
        public List<HocPhi_LopHoc> listLop { get; set; }
    }
    public class HocPhi_LopHoc
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string IdHocVien { get; set; }
        public string IdLopHoc { get; set; }

        public double? HocPhi { get; set; }
        [NotMapped]
        public string LopHoc { get; set; }
        [NotMapped]
        public string TietHoc { get; set; }
        [NotMapped]
        public string MonHoc { get; set; }
        [NotMapped]
        public string GiaoVien { get; set; }


        [NotMapped]
        public List<HocPhi_LopHoc_ChiTiet> listChiTiet { get; set; }
    }
    public class HocPhi_LopHoc_ChiTiet
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        [MaxLength(36)]
        public string? IdHocVien { get; set; }
        [MaxLength(36)]
        public string? IdLop { get; set; }
        [MaxLength(36)]
        public string? IdHocPhi { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public int? SoBuoiDuKien { get; set; }
        public int? SoBuoiConLaiKyTruoc { get; set; }
        public double? ThanhTienDuKien { get; set; }
        public double? ChietKhau { get; set; }
        public double? SoTienDaDong { get; set; }
        public double? TienKhac { get; set; }
        public int? SoBuoiDaDong { get; set; }
        public int? SoBuoiThucTe { get; set; }
        public double? ThanhTienThucTe { get; set; }
        public double? HocPhi { get; set; }
        public double? TienThuaKyTruoc { get; set; }
        public DateTime? NgayDongTien { get; set; }
        public bool DaNop { get; set; } = false;
        public bool DaTinh { get; set; } = false;
        public string? TrangThai { get; set; }
    }

    public class BuoiConLai
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public string IdLopHoc { get; set; }
        public string IdHocVien { get; set; }
        public int SoBuoiConLai { get; set; } = 0;
    }
}

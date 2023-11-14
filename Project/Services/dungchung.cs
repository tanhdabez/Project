using Project.Models;

namespace Project.Services
{
    public class TimKiemThoiKhoaBieu
    {
        public double TuNgay { get; set; }
        public double DenNgay { get; set; }
        public int Thu { get; set; }
        public string IdLop { get; set; }
        public string IdGiaoVien { get; set; }
        public string IdHocVien { get; set; }
    }

    public class TimKiemHocPhi
    {
        public double TuNgay { get; set; }
        public double DenNgay { get; set; }
        public string IdLop { get; set; }
        public int SoBuoiDaDong { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using Project.Models;
using Project.Services;
using static Project.Models.Definedata;

namespace Project.DBConxtext
{
    public class DbSet : DbContext
    {
        public DbSet(DbContextOptions options) : base(options)
        {
        }

        protected DbSet()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CaHoc> CaHoc { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<GiaoVien> GiaoVien { get; set; }
        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<DungCu> DungCu { get; set; }
        public DbSet<DungCuPhongHoc> DungCuPhong { get; set; }
        public DbSet<LopHoc> LopHoc { get; set; }
        public DbSet<LopHocVien> LopHocVien { get; set; }
        public DbSet<PhongHoc> PhongHoc { get; set; }
        public DbSet<TKB> TKB { get; set; }
        public DbSet<TrinhDo> TrinhDo { get; set; }
        public DbSet<ListDonGia> ListDonGia { get; set; }
        public DbSet<ListLichHoc> ListLichHoc { get; set; }
        public DbSet<HocPhi_LopHoc_ChiTiet> HocPhi_LopHoc_ChiTiet { get; set; }
        public DbSet<HocPhi> HocPhi { get; set; }
        public DbSet<HocPhi_HocVien> HocPhi_HocVien { get; set; }
        public DbSet<HocPhi_LopHoc> HocPhi_LopHoc { get; set; }
        public DbSet<BuoiConLai> BuoiConLai { get; set; }
    }
}

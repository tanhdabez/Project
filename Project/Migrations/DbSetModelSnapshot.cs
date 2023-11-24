﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DBConxtext;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(DbSet))]
    partial class DbSetModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project.Models.BuoiConLai", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("HocPhiId")
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdHocVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdLopHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoBuoiConLai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HocPhiId");

                    b.ToTable("BuoiConLai");
                });

            modelBuilder.Entity("Project.Models.CaHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime?>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ThuBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ThuKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CaHoc");
                });

            modelBuilder.Entity("Project.Models.DungCu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaDungCu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDungCu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DungCu");
                });

            modelBuilder.Entity("Project.Models.DungCuPhongHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdDungCu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPhongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DungCuPhong");
                });

            modelBuilder.Entity("Project.Models.GiaoVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaGiaoVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaSoThue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NganHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SoTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("TenGV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("TrinhDo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GiaoVien");
                });

            modelBuilder.Entity("Project.Models.HocPhi", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("HocPhiCanDong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaHocVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHocVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocPhi");
                });

            modelBuilder.Entity("Project.Models.HocPhi_HocVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GiaGoc")
                        .HasColumnType("bit");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("MaHocVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NgaySinh")
                        .HasColumnType("float");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHocVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocPhi_HocVien");
                });

            modelBuilder.Entity("Project.Models.HocPhi_LopHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<double?>("HocPhi")
                        .HasColumnType("float");

                    b.Property<string>("IdHocVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdLopHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocPhi_LopHoc");
                });

            modelBuilder.Entity("Project.Models.HocPhi_LopHoc_ChiTiet", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<double?>("ChietKhau")
                        .HasColumnType("float");

                    b.Property<bool>("DaNop")
                        .HasColumnType("bit");

                    b.Property<bool>("DaTinh")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DenNgay")
                        .HasColumnType("datetime2");

                    b.Property<double?>("HocPhi")
                        .HasColumnType("float");

                    b.Property<string>("IdHocPhi")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdHocVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdLop")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime?>("NgayDongTien")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoBuoiConLaiKyTruoc")
                        .HasColumnType("int");

                    b.Property<int?>("SoBuoiDaDong")
                        .HasColumnType("int");

                    b.Property<int?>("SoBuoiDuKien")
                        .HasColumnType("int");

                    b.Property<int?>("SoBuoiThucTe")
                        .HasColumnType("int");

                    b.Property<double?>("SoTienDaDong")
                        .HasColumnType("float");

                    b.Property<double?>("ThanhTienDuKien")
                        .HasColumnType("float");

                    b.Property<double?>("ThanhTienThucTe")
                        .HasColumnType("float");

                    b.Property<double?>("TienKhac")
                        .HasColumnType("float");

                    b.Property<double?>("TienThuaKyTruoc")
                        .HasColumnType("float");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TuNgay")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HocPhi_LopHoc_ChiTiet");
                });

            modelBuilder.Entity("Project.Models.HocVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaHocVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDTCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDTMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHocVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocVien");
                });

            modelBuilder.Entity("Project.Models.ListDonGia", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<float?>("GiaTN30")
                        .HasColumnType("real");

                    b.Property<float?>("GiaTN45")
                        .HasColumnType("real");

                    b.Property<float?>("GiaTN60")
                        .HasColumnType("real");

                    b.Property<float?>("GiaTT30")
                        .HasColumnType("real");

                    b.Property<float?>("GiaTT45")
                        .HasColumnType("real");

                    b.Property<float?>("GiaTT60")
                        .HasColumnType("real");

                    b.Property<string>("IdCaHoc")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdGVien")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdMonHoc")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.ToTable("ListDonGia");
                });

            modelBuilder.Entity("Project.Models.ListLichHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<double?>("GioBatDau")
                        .HasColumnType("float");

                    b.Property<double?>("GioKetThuc")
                        .HasColumnType("float");

                    b.Property<double?>("HocPhi")
                        .HasColumnType("float");

                    b.Property<string>("IdCaHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdGVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdLopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPhongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Thu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ListLichHoc");
                });

            modelBuilder.Entity("Project.Models.LopHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdCaHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdGVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdHocVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPhongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaLopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<double?>("SoHocVien")
                        .HasColumnType("float");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("Project.Models.LopHocVien", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdHocVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdLop")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.ToTable("LopHocVien");
                });

            modelBuilder.Entity("Project.Models.MonHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("MaMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("Project.Models.PhongHoc", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("MaPhongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhongHoc");
                });

            modelBuilder.Entity("Project.Models.TKB", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<double?>("HocPhi")
                        .HasColumnType("float");

                    b.Property<string>("IdCaHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdGVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdLop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPhongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayHoc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TKB");
                });

            modelBuilder.Entity("Project.Models.TrinhDo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdGiaoVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("MaTrinhDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTrinhDo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrinhDo");
                });

            modelBuilder.Entity("Project.Models.BuoiConLai", b =>
                {
                    b.HasOne("Project.Models.HocPhi", null)
                        .WithMany("SoBuoiConLai")
                        .HasForeignKey("HocPhiId");
                });

            modelBuilder.Entity("Project.Models.HocPhi", b =>
                {
                    b.Navigation("SoBuoiConLai");
                });
#pragma warning restore 612, 618
        }
    }
}

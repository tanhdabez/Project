﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DBConxtext;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(DbSet))]
    [Migration("20231030073340_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<string>("IdCaHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdGVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdLopHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdMonHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdPhongHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

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
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdGVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdHocVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdMonHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdPhongHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("MaLopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

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

            modelBuilder.Entity("Project.Models.ThuHocPhi", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<float?>("BuoiDaDong")
                        .HasColumnType("real");

                    b.Property<int?>("BuoiDuKien")
                        .HasColumnType("int");

                    b.Property<float?>("BuoiThucTe")
                        .HasColumnType("real");

                    b.Property<float?>("ChietKhau")
                        .HasColumnType("real");

                    b.Property<DateTime?>("DenNgay")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdDonGia")
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

                    b.Property<int?>("SoBuoiConLai")
                        .HasColumnType("int");

                    b.Property<float?>("SoTienDaDong")
                        .HasColumnType("real");

                    b.Property<float?>("ThanhTien")
                        .HasColumnType("real");

                    b.Property<float?>("ThanhTienThucTe")
                        .HasColumnType("real");

                    b.Property<float?>("TienDu")
                        .HasColumnType("real");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("TuNgay")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ThuHocPhi");
                });

            modelBuilder.Entity("Project.Models.TKB", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdCaHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdGVien")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdLop")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdMonHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("IdPhongHoc")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("NgayHoc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

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
#pragma warning restore 612, 618
        }
    }
}

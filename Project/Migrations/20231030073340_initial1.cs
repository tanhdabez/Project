using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaHoc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    ThuBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThuKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DungCu",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaDungCu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDungCu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungCu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DungCuPhong",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdPhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDungCu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungCuPhong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaGiaoVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenGV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdCCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    NganHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaSoThue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaHocVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenHocVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDTCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDTMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailMe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListDonGia",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdGVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdMonHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdCaHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    GiaTT30 = table.Column<float>(type: "real", nullable: true),
                    GiaTT45 = table.Column<float>(type: "real", nullable: true),
                    GiaTT60 = table.Column<float>(type: "real", nullable: true),
                    GiaTN30 = table.Column<float>(type: "real", nullable: true),
                    GiaTN45 = table.Column<float>(type: "real", nullable: true),
                    GiaTN60 = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListDonGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListLichHoc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdLopHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdGVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdMonHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdCaHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdPhongHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Thu = table.Column<int>(type: "int", nullable: true),
                    GioBatDau = table.Column<double>(type: "float", nullable: true),
                    GioKetThuc = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListLichHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdGVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdHocVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdMonHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdPhongHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdCaHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LopHocVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdLop = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdHocVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhongHoc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaPhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenPhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThuHocPhi",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdHocVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdLop = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdDonGia = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BuoiDuKien = table.Column<int>(type: "int", nullable: true),
                    SoBuoiConLai = table.Column<int>(type: "int", nullable: true),
                    TienDu = table.Column<float>(type: "real", nullable: true),
                    ChietKhau = table.Column<float>(type: "real", nullable: true),
                    ThanhTien = table.Column<float>(type: "real", nullable: true),
                    SoTienDaDong = table.Column<float>(type: "real", nullable: true),
                    NgayDongTien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BuoiDaDong = table.Column<float>(type: "real", nullable: true),
                    BuoiThucTe = table.Column<float>(type: "real", nullable: true),
                    ThanhTienThucTe = table.Column<float>(type: "real", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuHocPhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TKB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLop = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdGVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdCaHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdPhongHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdMonHoc = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrinhDo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaTrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdGiaoVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrinhDo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaHoc");

            migrationBuilder.DropTable(
                name: "DungCu");

            migrationBuilder.DropTable(
                name: "DungCuPhong");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "ListDonGia");

            migrationBuilder.DropTable(
                name: "ListLichHoc");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "LopHocVien");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "PhongHoc");

            migrationBuilder.DropTable(
                name: "ThuHocPhi");

            migrationBuilder.DropTable(
                name: "TKB");

            migrationBuilder.DropTable(
                name: "TrinhDo");
        }
    }
}

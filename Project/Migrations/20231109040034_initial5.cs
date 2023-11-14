using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThuHocPhi");

            migrationBuilder.CreateTable(
                name: "HocPhi_LopHoc_ChiTiet",
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
                    SoBuoiDaDong = table.Column<int>(type: "int", nullable: true),
                    SoBuoiThucTe = table.Column<int>(type: "int", nullable: true),
                    ThanhTienThucTe = table.Column<float>(type: "real", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi_LopHoc_ChiTiet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.CreateTable(
                name: "ThuHocPhi",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    BuoiDuKien = table.Column<int>(type: "int", nullable: true),
                    ChietKhau = table.Column<float>(type: "real", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdDonGia = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdHocVien = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IdLop = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    NgayDongTien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoBuoiConLai = table.Column<int>(type: "int", nullable: true),
                    SoBuoiDaDong = table.Column<int>(type: "int", nullable: true),
                    SoBuoiThucTe = table.Column<int>(type: "int", nullable: true),
                    SoTienDaDong = table.Column<float>(type: "real", nullable: true),
                    ThanhTien = table.Column<float>(type: "real", nullable: true),
                    ThanhTienThucTe = table.Column<float>(type: "real", nullable: true),
                    TienDu = table.Column<float>(type: "real", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuHocPhi", x => x.Id);
                });
        }
    }
}

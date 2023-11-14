using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocPhi",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MaHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocPhiCanDong = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocPhi_HocVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    TenHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaGoc = table.Column<bool>(type: "bit", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<double>(type: "float", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi_HocVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocPhi_LopHoc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocPhi = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi_LopHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuoiConLai",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IdLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdHocVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoBuoiConLai = table.Column<int>(type: "int", nullable: false),
                    HocPhiId = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuoiConLai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuoiConLai_HocPhi_HocPhiId",
                        column: x => x.HocPhiId,
                        principalTable: "HocPhi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuoiConLai_HocPhiId",
                table: "BuoiConLai",
                column: "HocPhiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuoiConLai");

            migrationBuilder.DropTable(
                name: "HocPhi_HocVien");

            migrationBuilder.DropTable(
                name: "HocPhi_LopHoc");

            migrationBuilder.DropTable(
                name: "HocPhi");
        }
    }
}

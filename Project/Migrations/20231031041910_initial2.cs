using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuoiThucTe",
                table: "ThuHocPhi",
                newName: "SoBuoiThucTe");

            migrationBuilder.RenameColumn(
                name: "BuoiDaDong",
                table: "ThuHocPhi",
                newName: "SoBuoiDaDong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoBuoiThucTe",
                table: "ThuHocPhi",
                newName: "BuoiThucTe");

            migrationBuilder.RenameColumn(
                name: "SoBuoiDaDong",
                table: "ThuHocPhi",
                newName: "BuoiDaDong");
        }
    }
}

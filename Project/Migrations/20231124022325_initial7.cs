using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThanhTien",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.DropColumn(
                name: "TienDu",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.RenameColumn(
                name: "SoBuoiConLai",
                table: "HocPhi_LopHoc_ChiTiet",
                newName: "SoBuoiDuKien");

            migrationBuilder.RenameColumn(
                name: "IdDonGia",
                table: "HocPhi_LopHoc_ChiTiet",
                newName: "IdHocPhi");

            migrationBuilder.RenameColumn(
                name: "BuoiDuKien",
                table: "HocPhi_LopHoc_ChiTiet",
                newName: "SoBuoiConLaiKyTruoc");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdPhongHoc",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdMonHoc",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdHocVien",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdGVien",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCaHoc",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SoHocVien",
                table: "LopHoc",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdPhongHoc",
                table: "ListLichHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdMonHoc",
                table: "ListLichHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdLopHoc",
                table: "ListLichHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdGVien",
                table: "ListLichHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCaHoc",
                table: "ListLichHoc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HocPhi",
                table: "ListLichHoc",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ThanhTienThucTe",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SoTienDaDong",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ChietKhau",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DaNop",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DaTinh",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "HocPhi",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ThanhTienDuKien",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TienKhac",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TienThuaKyTruoc",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoHocVien",
                table: "LopHoc");

            migrationBuilder.DropColumn(
                name: "HocPhi",
                table: "ListLichHoc");

            migrationBuilder.DropColumn(
                name: "DaNop",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.DropColumn(
                name: "DaTinh",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.DropColumn(
                name: "HocPhi",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.DropColumn(
                name: "ThanhTienDuKien",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.DropColumn(
                name: "TienKhac",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.DropColumn(
                name: "TienThuaKyTruoc",
                table: "HocPhi_LopHoc_ChiTiet");

            migrationBuilder.RenameColumn(
                name: "SoBuoiDuKien",
                table: "HocPhi_LopHoc_ChiTiet",
                newName: "SoBuoiConLai");

            migrationBuilder.RenameColumn(
                name: "SoBuoiConLaiKyTruoc",
                table: "HocPhi_LopHoc_ChiTiet",
                newName: "BuoiDuKien");

            migrationBuilder.RenameColumn(
                name: "IdHocPhi",
                table: "HocPhi_LopHoc_ChiTiet",
                newName: "IdDonGia");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "LopHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdPhongHoc",
                table: "LopHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdMonHoc",
                table: "LopHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdHocVien",
                table: "LopHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdGVien",
                table: "LopHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCaHoc",
                table: "LopHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdPhongHoc",
                table: "ListLichHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdMonHoc",
                table: "ListLichHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdLopHoc",
                table: "ListLichHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdGVien",
                table: "ListLichHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCaHoc",
                table: "ListLichHoc",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ThanhTienThucTe",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "SoTienDaDong",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ChietKhau",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ThanhTien",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TienDu",
                table: "HocPhi_LopHoc_ChiTiet",
                type: "real",
                nullable: true);
        }
    }
}

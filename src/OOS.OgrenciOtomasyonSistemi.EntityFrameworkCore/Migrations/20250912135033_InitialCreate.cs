using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOS.OgrenciOtomasyonSistemi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppSubeler",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "Bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppOgrenciler",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "Bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppImages",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "Bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppDonemler",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "Bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppSubeler",
                type: "Bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppOgrenciler",
                type: "Bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppImages",
                type: "Bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "Durum",
                table: "AppDonemler",
                type: "Bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }
    }
}

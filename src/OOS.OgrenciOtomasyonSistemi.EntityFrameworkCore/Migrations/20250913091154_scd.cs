using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOS.OgrenciOtomasyonSistemi.Migrations
{
    /// <inheritdoc />
    public partial class scd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "KanGrubu",
                table: "AppOgrenciler",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TinyInt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "KanGrubu",
                table: "AppOgrenciler",
                type: "TinyInt",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}

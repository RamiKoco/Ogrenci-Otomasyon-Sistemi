using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOS.OgrenciOtomasyonSistemi.Migrations
{
    /// <inheritdoc />
    public partial class OzelKodlar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppOzelKodlar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Kod = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    KodTuru = table.Column<short>(type: "smallint", nullable: false),
                    KartTuru = table.Column<short>(type: "smallint", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar", maxLength: 200, nullable: false),
                    Durum = table.Column<bool>(type: "boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOzelKodlar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppOgrenciler_OzelKod1Id",
                table: "AppOgrenciler",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppOgrenciler_OzelKod2Id",
                table: "AppOgrenciler",
                column: "OzelKod2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppOzelKodlar_Kod",
                table: "AppOzelKodlar",
                column: "Kod");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOgrenciler_AppOzelKodlar_OzelKod1Id",
                table: "AppOgrenciler",
                column: "OzelKod1Id",
                principalTable: "AppOzelKodlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOgrenciler_AppOzelKodlar_OzelKod2Id",
                table: "AppOgrenciler",
                column: "OzelKod2Id",
                principalTable: "AppOzelKodlar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOgrenciler_AppOzelKodlar_OzelKod1Id",
                table: "AppOgrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOgrenciler_AppOzelKodlar_OzelKod2Id",
                table: "AppOgrenciler");

            migrationBuilder.DropTable(
                name: "AppOzelKodlar");

            migrationBuilder.DropIndex(
                name: "IX_AppOgrenciler_OzelKod1Id",
                table: "AppOgrenciler");

            migrationBuilder.DropIndex(
                name: "IX_AppOgrenciler_OzelKod2Id",
                table: "AppOgrenciler");
        }
    }
}

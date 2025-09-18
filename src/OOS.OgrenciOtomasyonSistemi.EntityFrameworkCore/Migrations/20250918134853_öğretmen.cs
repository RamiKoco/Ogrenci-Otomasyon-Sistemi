using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOS.OgrenciOtomasyonSistemi.Migrations
{
    /// <inheritdoc />
    public partial class öğretmen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppOgretmenler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Kod = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "uuid", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "uuid", nullable: true),
                    KanGrubu = table.Column<short>(type: "smallint", nullable: false),
                    Cinsiyet = table.Column<short>(type: "smallint", nullable: false),
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
                    table.PrimaryKey("PK_AppOgretmenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOgretmenler_AppOzelKodlar_OzelKod1Id",
                        column: x => x.OzelKod1Id,
                        principalTable: "AppOzelKodlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppOgretmenler_AppOzelKodlar_OzelKod2Id",
                        column: x => x.OzelKod2Id,
                        principalTable: "AppOzelKodlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppOgretmenler_Kod",
                table: "AppOgretmenler",
                column: "Kod");

            migrationBuilder.CreateIndex(
                name: "IX_AppOgretmenler_OzelKod1Id",
                table: "AppOgretmenler",
                column: "OzelKod1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppOgretmenler_OzelKod2Id",
                table: "AppOgretmenler",
                column: "OzelKod2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppOgretmenler");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOS.OgrenciOtomasyonSistemi.Migrations
{
    /// <inheritdoc />
    public partial class sc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppOgrenciler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Kod = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    AnneAd = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    BabaAd = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    KimlikGT = table.Column<DateTime>(type: "date", nullable: false),
                    SeriNo = table.Column<string>(type: "varchar", maxLength: 9, nullable: false),
                    OzelKod1Id = table.Column<Guid>(type: "uuid", nullable: true),
                    OzelKod2Id = table.Column<Guid>(type: "uuid", nullable: true),
                    TCNo = table.Column<string>(type: "varchar", maxLength: 11, nullable: false),
                    Telefon = table.Column<string>(type: "varchar", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    DogumYeri = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    KanGrubu = table.Column<int>(type: "smallint", nullable: false),
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
                    table.PrimaryKey("PK_AppOgrenciler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppOgrenciler_Kod",
                table: "AppOgrenciler",
                column: "Kod");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppOgrenciler");
        }
    }
}

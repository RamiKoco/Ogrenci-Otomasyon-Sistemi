using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOS.OgrenciOtomasyonSistemi.Migrations
{
    /// <inheritdoc />
    public partial class Parametreler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppFirmaParametreler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    OkulId = table.Column<Guid>(type: "uuid", nullable: false),
                    DonemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFirmaParametreler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFirmaParametreler_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppFirmaParametreler_AppDonemler_DonemId",
                        column: x => x.DonemId,
                        principalTable: "AppDonemler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppFirmaParametreler_AppOkullar_OkulId",
                        column: x => x.OkulId,
                        principalTable: "AppOkullar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppFirmaParametreler_DonemId",
                table: "AppFirmaParametreler",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_AppFirmaParametreler_OkulId",
                table: "AppFirmaParametreler",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_AppFirmaParametreler_UserId",
                table: "AppFirmaParametreler",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppFirmaParametreler");
        }
    }
}

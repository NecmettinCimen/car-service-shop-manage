using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class MusteriTablosuEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    SirketAd = table.Column<string>(maxLength: 100, nullable: true),
                    SirketTelefon = table.Column<string>(maxLength: 15, nullable: true),
                    EvTelefon = table.Column<string>(maxLength: 15, nullable: true),
                    TC = table.Column<string>(maxLength: 11, nullable: true),
                    CinsiyetErkek = table.Column<bool>(nullable: false),
                    SirketAraci = table.Column<bool>(nullable: false),
                    SirketAdres = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_KullaniciId",
                table: "Musteri",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteri");
        }
    }
}

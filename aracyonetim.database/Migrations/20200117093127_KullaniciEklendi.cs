using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class KullaniciEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    AdSoyad = table.Column<string>(maxLength: 100, nullable: false),
                    Eposta = table.Column<string>(maxLength: 100, nullable: false),
                    Parola = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 15, nullable: false),
                    Unvan = table.Column<string>(maxLength: 100, nullable: true),
                    Ilce = table.Column<string>(maxLength: 50, nullable: true),
                    Adres = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanici");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class bakimtalebikullaniciidguncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakimTalebi_Musteri_MusteriId",
                table: "BakimTalebi");

            migrationBuilder.DropIndex(
                name: "IX_BakimTalebi_MusteriId",
                table: "BakimTalebi");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "BakimTalebi");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "BakimTalebi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_KullaniciId",
                table: "BakimTalebi",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakimTalebi_Kullanici_KullaniciId",
                table: "BakimTalebi",
                column: "KullaniciId",
                principalTable: "Kullanici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakimTalebi_Kullanici_KullaniciId",
                table: "BakimTalebi");

            migrationBuilder.DropIndex(
                name: "IX_BakimTalebi_KullaniciId",
                table: "BakimTalebi");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "BakimTalebi");

            migrationBuilder.AddColumn<int>(
                name: "MusteriId",
                table: "BakimTalebi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_MusteriId",
                table: "BakimTalebi",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakimTalebi_Musteri_MusteriId",
                table: "BakimTalebi",
                column: "MusteriId",
                principalTable: "Musteri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

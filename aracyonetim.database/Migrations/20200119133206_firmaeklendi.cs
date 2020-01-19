using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class firmaeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "Musteri",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "LookupList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "Kullanici",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "BakimTalebi",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "Arac",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FirmaId = table.Column<int>(nullable: true),
                    FirmaId1 = table.Column<int>(nullable: true),
                    Isim = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Firma_Firma_FirmaId1",
                        column: x => x.FirmaId1,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_FirmaId",
                table: "Musteri",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_LookupList_FirmaId",
                table: "LookupList",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_FirmaId",
                table: "Kullanici",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_FirmaId",
                table: "BakimTalebi",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Arac_FirmaId",
                table: "Arac",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Firma_FirmaId1",
                table: "Firma",
                column: "FirmaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_Firma_FirmaId",
                table: "Arac",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BakimTalebi_Firma_FirmaId",
                table: "BakimTalebi",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Firma_FirmaId",
                table: "Kullanici",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LookupList_Firma_FirmaId",
                table: "LookupList",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Musteri_Firma_FirmaId",
                table: "Musteri",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_Firma_FirmaId",
                table: "Arac");

            migrationBuilder.DropForeignKey(
                name: "FK_BakimTalebi_Firma_FirmaId",
                table: "BakimTalebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Firma_FirmaId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_LookupList_Firma_FirmaId",
                table: "LookupList");

            migrationBuilder.DropForeignKey(
                name: "FK_Musteri_Firma_FirmaId",
                table: "Musteri");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropIndex(
                name: "IX_Musteri_FirmaId",
                table: "Musteri");

            migrationBuilder.DropIndex(
                name: "IX_LookupList_FirmaId",
                table: "LookupList");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_FirmaId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_BakimTalebi_FirmaId",
                table: "BakimTalebi");

            migrationBuilder.DropIndex(
                name: "IX_Arac_FirmaId",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "LookupList");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "BakimTalebi");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "Arac");
        }
    }
}

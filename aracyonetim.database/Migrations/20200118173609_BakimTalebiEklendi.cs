using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class BakimTalebiEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BakimTalebi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    MusteriId = table.Column<int>(nullable: false),
                    AracId = table.Column<int>(nullable: false),
                    BakimTarihi = table.Column<DateTime>(nullable: false),
                    Aciklama = table.Column<string>(maxLength: 500, nullable: false),
                    Durum = table.Column<int>(nullable: false),
                    DurumIdId = table.Column<int>(nullable: true),
                    YetkiliServisAciklama = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakimTalebi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BakimTalebi_Arac_AracId",
                        column: x => x.AracId,
                        principalTable: "Arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakimTalebi_LookupList_DurumIdId",
                        column: x => x.DurumIdId,
                        principalTable: "LookupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BakimTalebi_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[] { 498810, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Bekliyor", null, (short)0, 4 });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[] { 498811, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Onaylandı", null, (short)0, 4 });

            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[] { 498812, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Red Edildi", null, (short)0, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_AracId",
                table: "BakimTalebi",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_DurumIdId",
                table: "BakimTalebi",
                column: "DurumIdId");

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_MusteriId",
                table: "BakimTalebi",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BakimTalebi");

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 498810);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 498811);

            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 498812);
        }
    }
}

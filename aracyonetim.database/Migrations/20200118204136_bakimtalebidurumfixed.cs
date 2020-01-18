using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class bakimtalebidurumfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakimTalebi_LookupList_DurumIdId",
                table: "BakimTalebi");

            migrationBuilder.DropIndex(
                name: "IX_BakimTalebi_DurumIdId",
                table: "BakimTalebi");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "BakimTalebi");

            migrationBuilder.DropColumn(
                name: "DurumIdId",
                table: "BakimTalebi");

            migrationBuilder.AddColumn<int>(
                name: "DurumId",
                table: "BakimTalebi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_DurumId",
                table: "BakimTalebi",
                column: "DurumId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakimTalebi_LookupList_DurumId",
                table: "BakimTalebi",
                column: "DurumId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakimTalebi_LookupList_DurumId",
                table: "BakimTalebi");

            migrationBuilder.DropIndex(
                name: "IX_BakimTalebi_DurumId",
                table: "BakimTalebi");

            migrationBuilder.DropColumn(
                name: "DurumId",
                table: "BakimTalebi");

            migrationBuilder.AddColumn<int>(
                name: "Durum",
                table: "BakimTalebi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurumIdId",
                table: "BakimTalebi",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BakimTalebi_DurumIdId",
                table: "BakimTalebi",
                column: "DurumIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakimTalebi_LookupList_DurumIdId",
                table: "BakimTalebi",
                column: "DurumIdId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

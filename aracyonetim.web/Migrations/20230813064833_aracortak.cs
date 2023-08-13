using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aracyonetim.web.Migrations
{
    /// <inheritdoc />
    public partial class aracortak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracOrtak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    OrtakAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oran = table.Column<double>(type: "float", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracOrtak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AracOrtak_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AracOrtak_FirmaId",
                table: "AracOrtak",
                column: "FirmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AracOrtak");
        }
    }
}

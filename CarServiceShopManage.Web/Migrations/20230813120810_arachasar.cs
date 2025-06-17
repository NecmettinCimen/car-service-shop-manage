using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aracyonetim.web.Migrations
{
    /// <inheritdoc />
    public partial class arachasar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracHasar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    SagArkaCamurluk = table.Column<int>(type: "int", nullable: false),
                    ArkaKaput = table.Column<int>(type: "int", nullable: false),
                    SolArkaCamurluk = table.Column<int>(type: "int", nullable: false),
                    SagArkaKapi = table.Column<int>(type: "int", nullable: false),
                    SagOnKapi = table.Column<int>(type: "int", nullable: false),
                    Tavan = table.Column<int>(type: "int", nullable: false),
                    SolArkaKapi = table.Column<int>(type: "int", nullable: false),
                    SolOnKapi = table.Column<int>(type: "int", nullable: false),
                    SagOnCamurluk = table.Column<int>(type: "int", nullable: false),
                    MotorKaputu = table.Column<int>(type: "int", nullable: false),
                    SolOnCamurluk = table.Column<int>(type: "int", nullable: false),
                    OnTampon = table.Column<int>(type: "int", nullable: false),
                    ArkaTampon = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracHasar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AracHasar_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AracHasar_FirmaId",
                table: "AracHasar",
                column: "FirmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AracHasar");
        }
    }
}

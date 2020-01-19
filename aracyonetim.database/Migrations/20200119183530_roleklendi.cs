using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class roleklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Kullanici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ChartDto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FirmaId = table.Column<int>(nullable: true),
                    Isim = table.Column<string>(nullable: true),
                    Sayi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ChartDto_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FirmaId = table.Column<int>(nullable: true),
                    Isim = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rol_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FirmaId = table.Column<int>(nullable: true),
                    MenuNo = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolMenu_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolMenu_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreateDate", "CreatorId", "FirmaId", "IsDeleted", "Isim", "Status" },
                values: new object[] { 498815, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, "Admin", (short)0 });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreateDate", "CreatorId", "FirmaId", "IsDeleted", "Isim", "Status" },
                values: new object[] { 498823, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, "Kullanıcı", (short)0 });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreateDate", "CreatorId", "FirmaId", "IsDeleted", "Isim", "Status" },
                values: new object[] { 498828, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, "Yetkili Servis", (short)0 });

            migrationBuilder.InsertData(
                table: "RolMenu",
                columns: new[] { "Id", "CreateDate", "CreatorId", "FirmaId", "IsDeleted", "MenuNo", "RolId", "Status" },
                values: new object[,]
                {
                    { 498816, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 1, 498815, (short)0 },
                    { 498817, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 2, 498815, (short)0 },
                    { 498818, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 3, 498815, (short)0 },
                    { 498819, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 4, 498815, (short)0 },
                    { 498820, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 5, 498815, (short)0 },
                    { 498821, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 6, 498815, (short)0 },
                    { 498822, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 7, 498815, (short)0 },
                    { 498824, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 1, 498823, (short)0 },
                    { 498825, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 2, 498823, (short)0 },
                    { 498826, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 3, 498823, (short)0 },
                    { 498827, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 4, 498823, (short)0 },
                    { 498829, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 1, 498828, (short)0 },
                    { 498830, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 5, 498828, (short)0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_RolId",
                table: "Kullanici",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartDto_FirmaId",
                table: "ChartDto",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_FirmaId",
                table: "Rol",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenu_FirmaId",
                table: "RolMenu",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenu_RolId",
                table: "RolMenu",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Rol_RolId",
                table: "Kullanici",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Rol_RolId",
                table: "Kullanici");

            migrationBuilder.DropTable(
                name: "ChartDto");

            migrationBuilder.DropTable(
                name: "RolMenu");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_RolId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Kullanici");
        }
    }
}

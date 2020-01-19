using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class musterirol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreateDate", "CreatorId", "FirmaId", "IsDeleted", "Isim", "Status" },
                values: new object[] { 498831, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, "Müşteri", (short)0 });

            migrationBuilder.InsertData(
                table: "RolMenu",
                columns: new[] { "Id", "CreateDate", "CreatorId", "FirmaId", "IsDeleted", "MenuNo", "RolId", "Status" },
                values: new object[] { 498832, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 4, 498831, (short)0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolMenu",
                keyColumn: "Id",
                keyValue: 498832);

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 498831);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class bakimtalebidurumtamamlandi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LookupList",
                columns: new[] { "Id", "CreateDate", "CreatorId", "IsDeleted", "Isim", "ParentId", "Status", "Tip" },
                values: new object[] { 498813, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Tamamlandı", null, (short)0, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupList",
                keyColumn: "Id",
                keyValue: 498813);
        }
    }
}

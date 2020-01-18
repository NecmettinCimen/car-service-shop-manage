using Microsoft.EntityFrameworkCore.Migrations;

namespace aracyonetim.database.Migrations
{
    public partial class aracnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_LookupList_MarkaId",
                table: "Arac");

            migrationBuilder.DropForeignKey(
                name: "FK_Arac_LookupList_YakitId",
                table: "Arac");

            migrationBuilder.AlterColumn<int>(
                name: "YakitId",
                table: "Arac",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MarkaId",
                table: "Arac",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_LookupList_MarkaId",
                table: "Arac",
                column: "MarkaId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_LookupList_YakitId",
                table: "Arac",
                column: "YakitId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_LookupList_MarkaId",
                table: "Arac");

            migrationBuilder.DropForeignKey(
                name: "FK_Arac_LookupList_YakitId",
                table: "Arac");

            migrationBuilder.AlterColumn<int>(
                name: "YakitId",
                table: "Arac",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MarkaId",
                table: "Arac",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_LookupList_MarkaId",
                table: "Arac",
                column: "MarkaId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_LookupList_YakitId",
                table: "Arac",
                column: "YakitId",
                principalTable: "LookupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

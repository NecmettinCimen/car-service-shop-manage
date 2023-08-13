using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aracyonetim.web.Migrations
{
    /// <inheritdoc />
    public partial class aracortakfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrtakAdı",
                table: "AracOrtak",
                newName: "OrtakAdi");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "AracOrtak",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "AracOrtak");

            migrationBuilder.RenameColumn(
                name: "OrtakAdi",
                table: "AracOrtak",
                newName: "OrtakAdı");
        }
    }
}

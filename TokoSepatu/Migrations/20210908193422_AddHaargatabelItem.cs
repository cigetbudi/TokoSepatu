using Microsoft.EntityFrameworkCore.Migrations;

namespace TokoSepatu.Migrations
{
    public partial class AddHaargatabelItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Deskripsi",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HargaBeli",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HargaJual",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deskripsi",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HargaBeli",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HargaJual",
                table: "Items");
        }
    }
}

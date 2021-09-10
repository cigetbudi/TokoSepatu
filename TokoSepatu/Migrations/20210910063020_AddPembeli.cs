using Microsoft.EntityFrameworkCore.Migrations;

namespace TokoSepatu.Migrations
{
    public partial class AddPembeli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PembeliId",
                table: "tb_Penjualan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pembelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembelis", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Penjualan_PembeliId",
                table: "tb_Penjualan",
                column: "PembeliId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Penjualan_Pembelis_PembeliId",
                table: "tb_Penjualan",
                column: "PembeliId",
                principalTable: "Pembelis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Penjualan_Pembelis_PembeliId",
                table: "tb_Penjualan");

            migrationBuilder.DropTable(
                name: "Pembelis");

            migrationBuilder.DropIndex(
                name: "IX_tb_Penjualan_PembeliId",
                table: "tb_Penjualan");

            migrationBuilder.DropColumn(
                name: "PembeliId",
                table: "tb_Penjualan");
        }
    }
}

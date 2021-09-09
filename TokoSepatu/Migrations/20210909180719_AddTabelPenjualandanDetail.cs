using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TokoSepatu.Migrations
{
    public partial class AddTabelPenjualandanDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TanggalPenjualan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrandTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Penjualan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_PenjualanDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PenjualanId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_PenjualanDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_PenjualanDetail_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_PenjualanDetail_tb_Penjualan_PenjualanId",
                        column: x => x.PenjualanId,
                        principalTable: "tb_Penjualan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_PenjualanDetail_ItemId",
                table: "tb_PenjualanDetail",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_PenjualanDetail_PenjualanId",
                table: "tb_PenjualanDetail",
                column: "PenjualanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_PenjualanDetail");

            migrationBuilder.DropTable(
                name: "tb_Penjualan");
        }
    }
}

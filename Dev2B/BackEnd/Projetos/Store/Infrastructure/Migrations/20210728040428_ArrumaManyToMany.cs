using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ArrumaManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSale");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "saleItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_saleItem_ProductId1",
                table: "saleItem",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_saleItem_product_ProductId1",
                table: "saleItem",
                column: "ProductId1",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saleItem_product_ProductId1",
                table: "saleItem");

            migrationBuilder.DropIndex(
                name: "IX_saleItem_ProductId1",
                table: "saleItem");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "saleItem");

            migrationBuilder.CreateTable(
                name: "ProductSale",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    SalesId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSale", x => new { x.ProductsId, x.SalesId });
                    table.ForeignKey(
                        name: "FK_ProductSale_product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSale_sale_SalesId",
                        column: x => x.SalesId,
                        principalTable: "sale",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_SalesId",
                table: "ProductSale",
                column: "SalesId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ArrumaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "product",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "InclusionDate",
                table: "product",
                newName: "inclusionDate");

            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "product",
                type: "INT",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "inclusionDate",
                table: "product",
                newName: "InclusionDate");
        }
    }
}

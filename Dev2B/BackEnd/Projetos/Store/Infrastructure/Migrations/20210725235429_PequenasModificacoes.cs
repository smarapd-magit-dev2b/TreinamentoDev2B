using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PequenasModificacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idCustomer",
                table: "sale",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_sale_idCustomer",
                table: "sale",
                newName: "IX_sale_customerId");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "customer",
                type: "CHAR(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(1)",
                oldMaxLength: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "sale",
                newName: "idCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_sale_customerId",
                table: "sale",
                newName: "IX_sale_idCustomer");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "customer",
                type: "CHAR(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "CHAR(1)",
                oldMaxLength: 1,
                oldNullable: true);
        }
    }
}

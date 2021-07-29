using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class NomeECpfUnicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_customer_cpf",
                table: "customer",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customer_name",
                table: "customer",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_customer_cpf",
                table: "customer");

            migrationBuilder.DropIndex(
                name: "IX_customer_name",
                table: "customer");
        }
    }
}

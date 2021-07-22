using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class NomeECpfUnicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_costummer_cpf",
                table: "costummer",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_costummer_name",
                table: "costummer",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_costummer_cpf",
                table: "costummer");

            migrationBuilder.DropIndex(
                name: "IX_costummer_name",
                table: "costummer");
        }
    }
}

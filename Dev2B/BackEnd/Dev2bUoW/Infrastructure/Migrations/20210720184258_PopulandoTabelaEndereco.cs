using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PopulandoTabelaEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Bairro", "CEP", "Logradouro", "Numero" },
                values: new object[] { 1, "Bairro 1", "11111111", "Rua 1", 1 });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Bairro", "CEP", "Logradouro", "Numero" },
                values: new object[] { 2, "Bairro 2", "22222222", "Rua 2", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

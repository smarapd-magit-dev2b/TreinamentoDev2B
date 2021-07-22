using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MovidoCampoNumeroParaEntidadePessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "SobreNome",
                table: "Pessoa",
                newName: "Sobrenome");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Pessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CPF", "DataNascimento", "EnderecoId", "Nome", "Numero", "Sobrenome" },
                values: new object[] { 1, "11111111111", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nome 1", 100, "Sobrenome 1" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CPF", "DataNascimento", "EnderecoId", "Nome", "Numero", "Sobrenome" },
                values: new object[] { 2, "22222222222", new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nome 2", 200, "Sobrenome 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "Pessoa",
                newName: "SobreNome");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: 1,
                column: "Numero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: 2,
                column: "Numero",
                value: 2);
        }
    }
}

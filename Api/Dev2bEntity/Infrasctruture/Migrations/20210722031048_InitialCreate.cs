using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrasctruture.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    telefone = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    cpf = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    rg = table.Column<string>(type: "VARCHAR(12)", maxLength: 12, nullable: false),
                    sexo = table.Column<string>(type: "CHAR(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataInclusao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    descricao = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    preco = table.Column<decimal>(type: "DECIMAL(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "venda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    dataVenda = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venda", x => x.id);
                    table.ForeignKey(
                        name: "FK_venda_cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itemVenda",
                columns: table => new
                {
                    IdVenda = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valorTotal = table.Column<decimal>(type: "DECIMAL(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemVenda", x => new { x.IdVenda, x.IdProduto });
                    table.ForeignKey(
                        name: "FK_itemVenda_produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemVenda_venda_IdVenda",
                        column: x => x.IdVenda,
                        principalTable: "venda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_cpf",
                table: "cliente",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cliente_nome",
                table: "cliente",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_itemVenda_IdProduto",
                table: "itemVenda",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_venda_IdCliente",
                table: "venda",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itemVenda");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "venda");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}

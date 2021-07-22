using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Vercao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costummer",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    birthDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    phone = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    cpf = table.Column<string>(type: "CHAR(11)", maxLength: 11, nullable: false),
                    rg = table.Column<string>(type: "CHAR(9)", maxLength: 9, nullable: false),
                    gender = table.Column<string>(type: "CHAR(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costummer", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "costummer");
        }
    }
}

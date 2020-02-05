using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteAPI.Infra.Migrations
{
    public partial class Setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplane",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Modelo = table.Column<string>(maxLength: 50, nullable: false),
                    QtidadePassageiros = table.Column<string>(maxLength: 10, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplane", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplane");
        }
    }
}

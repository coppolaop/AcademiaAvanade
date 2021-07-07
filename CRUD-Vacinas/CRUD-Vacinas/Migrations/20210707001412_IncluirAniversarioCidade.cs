using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Vacinas.Migrations
{
    public partial class IncluirAniversarioCidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Aniversario",
                table: "Cidades",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aniversario",
                table: "Cidades");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace managersalon.Migrations
{
    public partial class ClientesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    Bairro = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Rg = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeSprint2.Migrations
{
    /// <inheritdoc />
    public partial class intidb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_avaliacoes",
                columns: table => new
                {
                    IdAvaliacoes = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Comentario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NotaAvaliacao = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataAvaliacao = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false),
                    StatusAvaliacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_avaliacoes", x => x.IdAvaliacoes);
                });

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeProduto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PrecoProduto = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TipoProduto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DescricaoProduto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto", x => x.IdProduto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_avaliacoes");

            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_produto");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestãoDeEstoque.Migrations
{
    public partial class MinhaPrimeiraMigracaoEF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Pais = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false, defaultValue: "ANGOLA")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Funcao = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Quantidade = table.Column<int>(type: "INT", nullable: false),
                    PrecoUnitario = table.Column<double>(type: "FLOAT", nullable: false),
                    DataFabrico = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataExpiracao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    PrecoTotal = table.Column<double>(type: "FLOAT", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductoFornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoFornecedor", x => new { x.FornecedorId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ProdutoForneccedor_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoFornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoUtilizadores",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    UtilizadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoUtilizadores", x => new { x.ProdutoId, x.UtilizadorId });
                    table.ForeignKey(
                        name: "FK_ProdutoUtilizador_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoUtilizadores_UtilizadorId",
                        column: x => x.UtilizadorId,
                        principalTable: "Utilizador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoFornecedor_ProdutoId",
                table: "ProductoFornecedor",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoUtilizadores_UtilizadorId",
                table: "ProdutoUtilizadores",
                column: "UtilizadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoFornecedor");

            migrationBuilder.DropTable(
                name: "ProdutoUtilizadores");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Utilizador");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}

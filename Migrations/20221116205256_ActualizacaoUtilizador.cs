using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestãoDeEstoque.Migrations
{
    public partial class ActualizacaoUtilizador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Removido",
                table: "Utilizador",
                type: "BIT",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Removido",
                table: "Utilizador");
        }
    }
}

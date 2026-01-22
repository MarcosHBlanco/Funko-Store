using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoFunkoMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Funko",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funko_MarcaId",
                table: "Funko",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funko_Marca_MarcaId",
                table: "Funko",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funko_Marca_MarcaId",
                table: "Funko");

            migrationBuilder.DropIndex(
                name: "IX_Funko_MarcaId",
                table: "Funko");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Funko");
        }
    }
}

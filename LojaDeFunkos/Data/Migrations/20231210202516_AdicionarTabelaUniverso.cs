using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaUniverso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universo",
                columns: table => new
                {
                    UniversoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universo", x => x.UniversoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Universo");
        }
    }
}

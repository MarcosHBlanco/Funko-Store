using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaFunko : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funko",
                columns: table => new
                {
                    FunkoId = table.Column<int>(type: "int", nullable: false).Annotation("Sqlite:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImagemUri = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    EntregaExpressa = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                },
                  constraints: table =>
                  {
                      table.PrimaryKey("PK_Funko", x => x.FunkoId);
                  });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funko");
        }
    }
}

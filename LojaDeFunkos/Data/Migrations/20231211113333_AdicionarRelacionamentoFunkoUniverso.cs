using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoFunkoUniverso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FunkoUniverso",
                columns: table => new
                {
                    UniversosUniversoId = table.Column<int>(type: "INTEGER", nullable: false),
                    funkosFunkoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunkoUniverso", x => new { x.UniversosUniversoId, x.funkosFunkoId });
                    table.ForeignKey(
                        name: "FK_FunkoUniverso_Funko_funkosFunkoId",
                        column: x => x.funkosFunkoId,
                        principalTable: "Funko",
                        principalColumn: "FunkoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FunkoUniverso_Universo_UniversosUniversoId",
                        column: x => x.UniversosUniversoId,
                        principalTable: "Universo",
                        principalColumn: "UniversoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FunkoUniverso_funkosFunkoId",
                table: "FunkoUniverso",
                column: "funkosFunkoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FunkoUniverso");
        }
    }
}

using LojaDeFunkos.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new FunkoDbContext();
            context.Marca.AddRange(ObterCargaInicialMarca());
            context.SaveChanges();

        }

        public IList<Marca> ObterCargaInicialMarca()
        {
            return new List<Marca>
            {
                new Marca() { Descricao = "Funko Pop" }
            };
        }

    }
}

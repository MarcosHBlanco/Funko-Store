using LojaDeFunkos.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosUniverso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new FunkoDbContext();
            context.Universo.AddRange(ObterCargaInicialUniverso());
            context.SaveChanges();

        }

        public IList<Universo> ObterCargaInicialUniverso()
        {
            return new List<Universo>
            {
                new Universo() { Nome = "Malvel" },
                new Universo() { Nome = "DC" },
                new Universo() { Nome = "Games" },
                new Universo() { Nome = "Filmes" },
                new Universo() { Nome = "Anime" },
                new Universo() { Nome = "Esportes" },
                new Universo() { Nome = "Música" }
            };
        }
    }
}

using LojaDeFunkos.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeFunkos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisFunko : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new FunkoDbContext();
            context.Funko.AddRange(ObterCargaInicialFunko());
            context.SaveChanges();
        }

        private IList<Funko> ObterCargaInicialFunko()
        {
            return new List<Funko>()
            {
                new Funko
                {
                    Nome = "Funko do Kakashi",
                    Descricao = "Funko Pop do icônico ninja Kakashi de Naruto, capturando sua presença misteriosa, para fãs ávidos do anime!",
                    ImagemUri = "/imagens/FunkoKakashi.jpg",
                    Preco = 59.90,
                    Status = true,
                    DataCadastro = DateTime.Now
                },
                 new Funko
                {
                    Nome = "Funko do Mando",
                    Descricao = "Funko Pop do Mandaloriano: um ícone de determinação da saga Star Wars, para fãs apaixonados da aventura intergaláctica!",
                    ImagemUri = "/imagens/FunkoMando.jpg",
                    Preco = 59.90,
                    Status = true,
                    DataCadastro = DateTime.Now
                },
                  new Funko
                  {
                      Nome = "Funko do Eivor",
                      Descricao = "Funko Pop do destemido Eivor de Assassin's Creed, capturando sua bravura e determinação dentro da saga.",
                      ImagemUri = "/imagens/FunkoEivor.jpg",
                      Preco = 59.90,
                      Status = true,
                      DataCadastro = DateTime.Now
                  }
            };
        }
    }
}

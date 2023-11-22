using LojaDeFunkos.Models;

namespace LojaDeFunkos.Servicos
{
    public class FunkoServico
    {
        public IList<Funko> ObterTodos()
        {
            return new List<Funko>()
                {
                    new Funko
                    {
                        FunkoId = 1,
                        Nome = "Funko do Kakashi",
                        Descricao = "Adquira o Funko Pop do icônico ninja Kakashi de Naruto, capturando sua presença misteriosa e carismática, ideal para colecionadores e fãs ávidos do anime!",
                        ImagemUri = "/imagens/FunkoKakashi.jpg",
                        Preco = 59.90,
                        EntregaExpressa = true,
                        DataCadastro = DateTime.Now
    },
                     new Funko
                    {
                        FunkoId = 2,
                        Nome = "Funko do Mando",
                        Descricao = "O Funko Pop do Mandaloriano: um ícone de determinação da saga Star Wars, ideal para colecionadores e fãs apaixonados pela aventura intergaláctica!",
                        ImagemUri = "/imagens/FunkoMando.jpg",
                        Preco = 59.90,
                        EntregaExpressa = true,
                        DataCadastro = DateTime.Now
                    },
                      new Funko
                      {
                          FunkoId = 3,
                          Nome = "Funko do Eivor",
                          Descricao = "O Funko Pop do destemido Eivor de Assassin's Creed, capturando sua bravura e determinação, um item imprescindível para os fãs da saga épica de videogames!",
                          ImagemUri = "/imagens/FunkoEivor.jpg",
                          Preco = 59.90,
                          EntregaExpressa = true,
                          DataCadastro = DateTime.Now
                      }
                };
        }

        public Funko Obter(int id) => ObterTodos().SingleOrDefault(item => item.FunkoId == id);
    }
}


using LojaDeFunkos.Models;

namespace LojaDeFunkos.Serviços;

public class FunkoServico : IFunkoServico
{

    public FunkoServico()
        => CarregarListaInicial();

    private IList<Funko>_funkos;

    private void CarregarListaInicial()
    {
        _funkos = new List<Funko>()
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

    public IList<Funko> ObterTodos()
        => _funkos;

    public Funko Obter(int id)
    {
        return ObterTodos().SingleOrDefault(item => item.FunkoId == id);
    }

    public void Incluir(Funko funko)
    {
        var proximoId = _funkos.Max(item => item.FunkoId) + 1;
        funko.FunkoId = proximoId;
        _funkos.Add(funko);
    }

    public void Alterar(Funko funko)
    {
        var funkoEncontrado = _funkos.SingleOrDefault(item => item.FunkoId == funko.FunkoId);
        funkoEncontrado.Nome = funko.Nome;
        funkoEncontrado.Descricao = funko.Descricao;
        funkoEncontrado.ImagemUri = funko.ImagemUri;
        funkoEncontrado.Preco = funko.Preco;
        funkoEncontrado.EntregaExpressa = funko.EntregaExpressa;
        funkoEncontrado.DataCadastro = funko.DataCadastro;
    }

    public void Excluir(int id)
    {
        var funkoEncontrado = Obter(id);
        _funkos.Remove(funkoEncontrado);
    }
}


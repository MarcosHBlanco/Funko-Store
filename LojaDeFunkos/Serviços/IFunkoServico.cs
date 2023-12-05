using LojaDeFunkos.Models;

namespace LojaDeFunkos.Serviços;

public interface IFunkoServico
{
    IList<Funko> ObterTodos();
    Funko Obter(int id);
    void Incluir(Funko funko);
    void Alterar(Funko funko);
    void Excluir(int id);
}


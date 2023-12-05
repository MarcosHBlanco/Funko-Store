using LojaDeFunkos.Data;
using LojaDeFunkos.Models;

namespace LojaDeFunkos.Serviços.Data;

public class FunkoServico:IFunkoServico
{
    private FunkoDbContext _context;

    public FunkoServico(FunkoDbContext context)
    {
        _context = context;
    }

    void IFunkoServico.Alterar(Funko funko)
    {
        throw new NotImplementedException();
    }

    void IFunkoServico.Excluir(int id)
    {
        throw new NotImplementedException();
    }

    void IFunkoServico.Incluir(Funko funko)
    {
        _context.Funko.Add(funko);
        _context.SaveChanges();
    }

    Funko IFunkoServico.Obter(int id)
    {
        throw new NotImplementedException();
    }

    IList<Funko> IFunkoServico.ObterTodos()
    {
        return _context.Funko.ToList();
    }
}


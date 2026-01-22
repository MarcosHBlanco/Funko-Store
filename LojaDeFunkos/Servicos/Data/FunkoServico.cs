using LojaDeFunkos.Data;
using LojaDeFunkos.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaDeFunkos.Serviços.Data;

public class FunkoServico : IFunkoServico
{
    private FunkoDbContext _context;

    public FunkoServico(FunkoDbContext context)
    {
        _context = context;
    }

    void IFunkoServico.Alterar(Funko funko)
    {
        var FunkoEncontrado = ((IFunkoServico)this).Obter(funko.FunkoId);
        FunkoEncontrado.Nome = funko.Nome;
        FunkoEncontrado.Descricao = funko.Descricao;
        FunkoEncontrado.Preco = funko.Preco;
        FunkoEncontrado.ImagemUri = funko.ImagemUri;
        FunkoEncontrado.Status = funko.Status;
        FunkoEncontrado.DataCadastro = funko.DataCadastro;
        FunkoEncontrado.MarcaId = funko.MarcaId;
        FunkoEncontrado.Universos = funko.Universos;

        _context.SaveChanges();
    }

    void IFunkoServico.Excluir(int id)
    {
        var FunkoEncontrado = ((IFunkoServico)this).Obter(id);
        _context.Funko.Remove(FunkoEncontrado);
        _context.SaveChanges();
    }

    void IFunkoServico.Incluir(Funko funko)
    {
        _context.Funko.Add(funko);
        _context.SaveChanges();
    }

    Funko IFunkoServico.Obter(int id)
    {
        return _context.Funko
                        .Include(item => item.Universos)
                        .SingleOrDefault(item => item.FunkoId == id);
    }

    IList<Funko> IFunkoServico.ObterTodos()
    {
        return _context.Funko.ToList();
    }

    public IList<Marca> ObterTodasMarcas()
    {
        return _context.Marca.ToList();
    }

    public Marca ObterMarca(int id) => _context.Marca.SingleOrDefault(item => item.MarcaId == id);

    public IList<Universo> ObterTodosUniversos()
    {
        return _context.Universo.ToList();
    }
}



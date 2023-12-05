using LojaDeFunkos.Models;
using LojaDeFunkos.Serviços;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaDeFunkos.Pages;

public class IndexModel : PageModel
{
    private IFunkoServico _servico;
    public IndexModel(IFunkoServico servico)
    {
        _servico = servico;
    }
    public IList<Funko> ListaFunkos { get; private set; }

    public void OnGet()
    {

        ViewData["Title"] = "Home page";

        ListaFunkos = _servico.ObterTodos();
    }
}

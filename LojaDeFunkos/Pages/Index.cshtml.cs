using LojaDeFunkos.Models;
using LojaDeFunkos.Servicos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaDeFunkos.Pages;

public class IndexModel : PageModel
{
    public IList<Funko> ListaFunkos { get; private set; }

    public void OnGet()
    {

        ViewData["Title"] = "Home page";

        var servico = new FunkoServico();

        ListaFunkos = servico.ObterTodos();
    }
}

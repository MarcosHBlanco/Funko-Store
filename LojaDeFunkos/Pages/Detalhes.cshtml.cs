using LojaDeFunkos.Models;
using LojaDeFunkos.Servicos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaDeFunkos
{
	public class DetalhesModel : PageModel
    {

        public Funko Funko { get; private set; }

        public void OnGet(int id)
        {
            var servico = new FunkoServico();

            Funko = servico.Obter(id);

        }
    }
}

using LojaDeFunkos.Models;
using LojaDeFunkos.Serviços;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaDeFunkos
{
	public class DetalhesModel : PageModel
    {

        private IFunkoServico _servico;
        public DetalhesModel(IFunkoServico servico)
        {
            _servico = servico;
        }

        public Funko Funko { get; private set; }

        public IActionResult OnGet(int id)
        {
            Funko = _servico.Obter(id);

            if(Funko == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

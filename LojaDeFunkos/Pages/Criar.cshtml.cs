using LojaDeFunkos.Models;
using LojaDeFunkos.Serviços;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaDeFunkos.Pages
{
    public class CriarModel : PageModel
    {
        private IFunkoServico _servico;

        public CriarModel(IFunkoServico servico)
        {
            _servico = servico;
        }

        [BindProperty]
        public Funko Funko { get; set; }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _servico.Incluir(Funko);


            return RedirectToPage("/Index");
        }
    }
}

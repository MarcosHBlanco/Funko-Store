using LojaDeFunkos.Models;
using LojaDeFunkos.Serviços;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaDeFunkos.Pages
{
	public class EditarModel : PageModel
    {

        private IFunkoServico _servico;

        public EditarModel(IFunkoServico servico)
        {
            _servico = servico;
        }

        [BindProperty]
        public Funko Funko { get; set; }

        public IActionResult OnGet(int id)
        {
            Funko = _servico.Obter(id);

            if (Funko == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _servico.Alterar(Funko);


            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            _servico.Excluir(Funko.FunkoId);

            return RedirectToPage("/Index");
        }
    }
}

using LojaDeFunkos.Models;
using LojaDeFunkos.Serviços;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaDeFunkos.Pages
{
    [Authorize]
	public class EditarModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        public SelectList UniversoOptionItems { get; set; }
        private IFunkoServico _servico;

        public EditarModel(IFunkoServico servico)
        {
            _servico = servico;
        }

        [BindProperty]
        public Funko Funko { get; set; }

        [BindProperty]
        public IList<int> UniversoIds { get; set; }

        public IActionResult OnGet(int id)
        {
            Funko = _servico.Obter(id);

            UniversoIds = Funko.Universos.Select(item => item.UniversoId).ToList();

            MarcaOptionItems = new SelectList(_servico.ObterTodasMarcas(),
                nameof(Marca.MarcaId),
                nameof(Marca.Descricao));
            UniversoOptionItems = new SelectList(_servico.ObterTodosUniversos(),
                nameof(Universo.UniversoId),
                nameof(Universo.Nome));

            if (Funko == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {

            Funko.Universos = _servico.ObterTodosUniversos()
                                      .Where(item => UniversoIds.Contains(item.UniversoId))
                                      .ToList();

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

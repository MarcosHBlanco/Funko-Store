using LojaDeFunkos.Models;
using LojaDeFunkos.Serviços;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaDeFunkos.Pages
{
    [Authorize]
    public class CriarModel : PageModel
    {

        public SelectList MarcaOptionItems { get; set; }
        public SelectList UniversoOptionItems { get; set; }
        private IFunkoServico _servico;

        public CriarModel(IFunkoServico servico)
        {
            _servico = servico;
        }

        public void OnGet()
        {
            MarcaOptionItems = new SelectList(_servico.ObterTodasMarcas(),
                nameof(Marca.MarcaId),
                nameof(Marca.Descricao));
            UniversoOptionItems = new SelectList(_servico.ObterTodosUniversos(),
                nameof(Universo.UniversoId),
                nameof(Universo.Nome));
        }

        [BindProperty]
        public Funko Funko { get; set; }

        [BindProperty]
        public IList<int> UniversoIds { get; set; }

        public IActionResult OnPost()
        {

            Funko.Universos = _servico.ObterTodosUniversos()
                                      .Where(item => UniversoIds.Contains(item.UniversoId))
                                      .ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _servico.Incluir(Funko);


            return RedirectToPage("/Index");
        }
    }
}

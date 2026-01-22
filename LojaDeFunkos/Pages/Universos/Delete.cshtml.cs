using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojaDeFunkos.Data;
using LojaDeFunkos.Models;

namespace LojaDeFunkos.Pages.Universos
{
    public class DeleteModel : PageModel
    {
        private readonly LojaDeFunkos.Data.FunkoDbContext _context;

        public DeleteModel(LojaDeFunkos.Data.FunkoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Universo Universo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Universo == null)
            {
                return NotFound();
            }

            var universo = await _context.Universo.FirstOrDefaultAsync(m => m.UniversoId == id);

            if (universo == null)
            {
                return NotFound();
            }
            else 
            {
                Universo = universo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Universo == null)
            {
                return NotFound();
            }
            var universo = await _context.Universo.FindAsync(id);

            if (universo != null)
            {
                Universo = universo;
                _context.Universo.Remove(Universo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

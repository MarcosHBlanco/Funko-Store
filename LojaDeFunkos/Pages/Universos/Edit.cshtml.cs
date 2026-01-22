using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LojaDeFunkos.Data;
using LojaDeFunkos.Models;

namespace LojaDeFunkos.Pages.Universos
{
    public class EditModel : PageModel
    {
        private readonly LojaDeFunkos.Data.FunkoDbContext _context;

        public EditModel(LojaDeFunkos.Data.FunkoDbContext context)
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

            var universo =  await _context.Universo.FirstOrDefaultAsync(m => m.UniversoId == id);
            if (universo == null)
            {
                return NotFound();
            }
            Universo = universo;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Universo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversoExists(Universo.UniversoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UniversoExists(int id)
        {
          return (_context.Universo?.Any(e => e.UniversoId == id)).GetValueOrDefault();
        }
    }
}

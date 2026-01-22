using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LojaDeFunkos.Data;
using LojaDeFunkos.Models;

namespace LojaDeFunkos.Pages.Universos
{
    public class CreateModel : PageModel
    {
        private readonly LojaDeFunkos.Data.FunkoDbContext _context;

        public CreateModel(LojaDeFunkos.Data.FunkoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Universo Universo { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Universo == null || Universo == null)
            {
                return Page();
            }

            _context.Universo.Add(Universo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

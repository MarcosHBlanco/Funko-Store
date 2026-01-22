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
    public class DetailsModel : PageModel
    {
        private readonly LojaDeFunkos.Data.FunkoDbContext _context;

        public DetailsModel(LojaDeFunkos.Data.FunkoDbContext context)
        {
            _context = context;
        }

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
    }
}

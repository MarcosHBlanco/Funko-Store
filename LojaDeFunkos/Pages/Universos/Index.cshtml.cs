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
    public class IndexModel : PageModel
    {
        private readonly LojaDeFunkos.Data.FunkoDbContext _context;

        public IndexModel(LojaDeFunkos.Data.FunkoDbContext context)
        {
            _context = context;
        }

        public IList<Universo> Universo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Universo != null)
            {
                Universo = await _context.Universo.ToListAsync();
            }
        }
    }
}

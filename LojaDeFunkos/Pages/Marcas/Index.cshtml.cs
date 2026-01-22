using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojaDeFunkos.Data;
using LojaDeFunkos.Models;

namespace LojaDeFunkos.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly LojaDeFunkos.Data.FunkoDbContext _context;

        public IndexModel(LojaDeFunkos.Data.FunkoDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marca != null)
            {
                Marca = await _context.Marca.ToListAsync();
            }
        }
    }
}

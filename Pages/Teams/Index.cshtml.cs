using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final;

namespace Project_final2.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly Final.AppDbContext _context;

        public IndexModel(Final.AppDbContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Team != null)
            {
                Team = await _context.Team.Include(p => p.Players).ToListAsync();
            }
        }
    }
}

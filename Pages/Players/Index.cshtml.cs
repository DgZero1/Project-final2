using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final;

namespace Project_final2.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly Final.AppDbContext _context;

        public IndexModel(Final.AppDbContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        [BindProperty(SupportsGet = true)]

        public int PageNum {get; set;} =1;

        public int PageSize {get; set;} =5;

         [BindProperty(SupportsGet = true)]

         public string CurrentSort {get; set;} = string.Empty;

       



        public async Task OnGetAsync()
        {
            var query =_context.Player.Select(p => p);
            
            switch (CurrentSort)
                {
                    
                    case "first_asc": 
                        query = query.OrderBy(p => p.FirstName);
                        break;
                   
                    case "first_desc":
                        query = query.OrderByDescending(p => p.FirstName);
                        break;
                   
                }

            if (_context.Player != null)
            {
                Player = await _context.Player.Skip((PageNum-1)*PageSize).Take(PageSize)
                .Include(p => p.Team).ToListAsync();
            }
        }
    }
}

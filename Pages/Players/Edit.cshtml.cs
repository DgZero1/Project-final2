using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final;

namespace Project_final2.Pages.Players
{
    public class EditModel : PageModel
    {
        private readonly Final.AppDbContext _context;

        public EditModel(Final.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Player Player { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player =  await _context.Players.FirstOrDefaultAsync(m => m.PlayerID == id);
            if (player == null)
            {
                return NotFound();
            }
            Player = player;
           ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID");
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

            _context.Attach(Player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(Player.PlayerID))
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

        private bool PlayerExists(int id)
        {
          return (_context.Players?.Any(e => e.PlayerID == id)).GetValueOrDefault();
        }
    }
}

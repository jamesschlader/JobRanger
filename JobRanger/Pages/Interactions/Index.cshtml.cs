using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

       public ApplicationUser AppUser { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                AppUser = await _context.ApplicationUser
                    .Include(i => i.Interactions)
                    .Include(j => j.Jobs)
                    .Include(e => e.Employers)
                    .FirstOrDefaultAsync(f => f.Id == userId);

                return Page();

            }

           return Page();
           
        }

        [BindProperty] public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            
           var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            Interaction.ApplicationUserId = userId;
            
            _context.Attach(Interaction).State = EntityState.Modified;

            try
            {
               
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteractionExists(Interaction.Id))
                    return NotFound();
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool InteractionExists(int id)
        {
            return _context.Interactions.Any(e => e.Id == id);
        }
    }
}
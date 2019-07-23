using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Job
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Job> Job { get; set; }

        public ApplicationUser AppUser { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                AppUser = await _context.ApplicationUser
                    .Include(e => e.Employers)
                    .Include(i => i.Jobs)
                    .Include(i => i.Interactions)
                    .Include(c => c.Contacts)
                    .FirstOrDefaultAsync(i => i.Id == userId);

                return Page();
            }

            return Page();
        }
    }
}
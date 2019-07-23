using System;
using System.Collections.Generic;
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
    public class LogModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LogModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Interaction> Interaction { get; set; }

        public ApplicationUser AppUser { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                AppUser = await _context.ApplicationUser
                    .Include(i => i.Interactions)
                    .Include(j => j.Jobs)
                    .Include(c => c.Contacts)
                    .Include(e => e.Employers)
                    .FirstOrDefaultAsync(f => f.Id == userId);

                return Page();

            }

            return Page();

        }
    }
}
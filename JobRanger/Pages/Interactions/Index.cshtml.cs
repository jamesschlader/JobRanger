using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace JobRanger.Pages.Interactions
{
    public class IndexModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public IndexModel(JobRanger.Data.ApplicationDbContext context)
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
                    .Include(j=>j.Jobs)
                    .Include(e=>e.Employers)
                    .FirstOrDefaultAsync(i => i.Id == userId);

                return Page();
            }

            return Page();
            
        }
    }
}

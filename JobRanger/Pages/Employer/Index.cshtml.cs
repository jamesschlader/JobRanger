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
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace JobRanger.Pages.Employer
{
    public class IndexModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public IndexModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Employer> Employer { get;set; }

        public ApplicationUser AppUser { get; set; }

        public async Task<IActionResult> OnGetAsync()
       {
            
           if (User.Identity.IsAuthenticated)
           {
              var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

               AppUser = await _context.ApplicationUser
                   .Include(i => i.Employers)
                   .ThenInclude(e => e.Contacts)
                   .Include(e => e.Jobs)
                   .Include(e => e.Interactions)
                   .FirstOrDefaultAsync(i => i.Id == userId);

               return Page();
           }

           return Page();

            /*  Employer = await _context.Employer
                      .Include(e => e.Jobs)
                      .Include(c => c.Contacts)
                      .AsNoTracking()
                      .OrderByDescending(i => i.Jobs.Count)
                      .AsNoTracking()
                      .ToListAsync(); */
        }

    }
}

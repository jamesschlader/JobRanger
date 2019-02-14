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

namespace JobRanger.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public IndexModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public ApplicationUser AppUser { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                AppUser = await _context.ApplicationUser
                    .Include(i => i.Employers)
                    .Include(c=>c.Contacts)
                    .FirstOrDefaultAsync(i => i.Id == userId);

                return Page();
            }

            return Page();


            Contact = await _context.Contact
                .Include(c => c.Employer).ToListAsync();
        }
    }
}

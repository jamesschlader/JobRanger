using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

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

       public async Task OnGetAsync()
        {
            
           Employer = await _context.Employer
                .Include(e=>e.Jobs)
               .Include(c=>c.Contacts)
                .AsNoTracking()
                .OrderByDescending(i => i.Jobs.Count)
                .ToListAsync();
            }
    }
}

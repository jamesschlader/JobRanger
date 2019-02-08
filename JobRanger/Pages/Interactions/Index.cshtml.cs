using System;
using System.Collections.Generic;
using System.Linq;
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
            
        
        public async Task OnGetAsync()
        {
            Interaction = await _context.Interactions
                .Include(i => i.Job)
                .ThenInclude(e=>e.Employer)
                .Include(i => i.Type)
                .OrderBy(i=>i.TargetTime)
                .ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Job
{
    public class DetailsModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public DetailsModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Job Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Job
                    .Include(job => job.Employer)
                    .Include(i=>i.Interactions)
                    .FirstOrDefaultAsync(m => m.Id == id);

            if (Job == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

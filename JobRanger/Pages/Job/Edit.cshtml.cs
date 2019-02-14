using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Job
{
    public class EditModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public EditModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Job Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Job
                .Include(job => job.Employer)
                .FirstOrDefaultAsync(j => j.Id== id);

          if (Job == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

           if (!ModelState.IsValid)
            {
                return Page();
            }
           

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            Job.ApplicationUserId = userId;

            _context.Attach(Job).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(Job.Id))
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

        private bool JobExists(int id)
        {
            return _context.Job.Any(e => e.Id == id);
        }
    }
}

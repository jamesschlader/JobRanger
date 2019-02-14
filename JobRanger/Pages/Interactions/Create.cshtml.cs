using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class CreateModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public CreateModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Job Job { get; set; }

        [BindProperty]
        public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
        
        Job = await _context.Job
            .Include(e=>e.Employer)
            .Include(i=>i.Interactions)
       .FirstOrDefaultAsync(m => m.Id == id);

            return Page();
        }

       public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyInteraction = new Models.Interaction();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            emptyInteraction.ApplicationUserId = userId;
          
           if (await TryUpdateModelAsync<Models.Interaction>(
                emptyInteraction,
                "interaction",
               j=>j.JobId, j=>j.Notes, j=>j.TargetTime,  j=>j.InteractionTypeName
                ))
            {
                
                _context.Interactions.Add(emptyInteraction);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

          
            return Page();

        }

        
    }
}
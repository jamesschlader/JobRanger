using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class CreateModel : InteractionTypesPageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public CreateModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Job Job { get; set; }
        public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
            PopulateInteractionTypesDropDownList(_context);
        ViewData["JobId"] = new SelectList(_context.Job, "Id", "Name");
        ViewData["InteractionTypesId"] = new SelectList(_context.InteractionTypes, "Id", "Id");

        Job = await _context.Job
            .Include(e=>e.Employer)
       .FirstOrDefaultAsync(m => m.Id == id);

            return Page();
        }

        [BindProperty]
        public Interaction NewInteraction { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyInteraction = new Models.Interaction();

            if (await TryUpdateModelAsync<Models.Interaction>(
                emptyInteraction,
                "interaction",
               j=>j.JobId, j=>j.Notes, j=>j.TargetTime, j=>j.InteractionTypesId
                ))
            {
                _context.Interactions.Add(emptyInteraction);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            PopulateInteractionTypesDropDownList(_context);
            return Page();

        }

        
    }
}
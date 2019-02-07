using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Interactions
{
    public class EditModel : InteractionTypesPageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public EditModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interaction = await _context.Interactions
                .Include(i => i.Job)
                .ThenInclude(e=>e.Employer)
                .Include(i => i.Type).FirstOrDefaultAsync(m => m.Id == id);

            if (Interaction == null)
            {
                return NotFound();
            }

            {

                PopulateInteractionTypesDropDownList(_context);
                ViewData["JobId"] = new SelectList(_context.Job, "Id", "Name");
                ViewData["InteractionTypesId"] = new SelectList(_context.InteractionTypes, "Id", "Id");
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Interaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteractionExists(Interaction.Id))
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

        private bool InteractionExists(int id)
        {
            return _context.Interactions.Any(e => e.Id == id);
        }
    }
}

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

namespace JobRanger.Pages.Interactions
{
    public class EditModel : PageModel
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
             .FirstOrDefaultAsync(m => m.Id == id);

            if (Interaction == null)
            {
                return NotFound();
            }

            {

                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

          Interaction.ApplicationUserId = userId;

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

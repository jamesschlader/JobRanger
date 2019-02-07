using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Interactions
{
    public class DeleteModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public DeleteModel(JobRanger.Data.ApplicationDbContext context)
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
                .Include(i => i.Type).FirstOrDefaultAsync(m => m.Id == id);

            if (Interaction == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interaction = await _context.Interactions.FindAsync(id);

            if (Interaction != null)
            {
                _context.Interactions.Remove(Interaction);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

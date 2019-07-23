using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class CreateWithContactModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateWithContactModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Contact Contact { get; set; }


        [BindProperty] public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Contact = await _context.Contact
                .Include(e => e.Employer)
                .Include(i => i.Interactions)
                .FirstOrDefaultAsync(m => m.Id == id);


            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var emptyInteraction = new Interaction();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            emptyInteraction.ApplicationUserId = userId;

            if (await TryUpdateModelAsync(
                emptyInteraction,
                "interaction",
                 j => j.Notes, j=>j.ContactId, j => j.TargetTime, j => j.InteractionTypeName, j => j.ToDo
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
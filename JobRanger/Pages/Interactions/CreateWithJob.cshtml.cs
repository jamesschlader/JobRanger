using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Job Job { get; set; }
        

        [BindProperty] public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Job = await _context.Job
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
                j => j.JobId, j => j.Notes, j=>j.ApplicationUserId, j => j.TargetTime, j => j.InteractionTypeName, j=>j.ToDo
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
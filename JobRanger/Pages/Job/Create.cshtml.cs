using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc;

namespace JobRanger.Pages.Job
{
    public class CreateModel : EmployerNamePageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Employer> Employers { get; set; }


        [BindProperty] public Models.Job Job { get; set; }

        public IActionResult OnGet()
        {
            PopulateEmployersDropDownList(_context);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            
            var emptyJob = new Models.Job();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            emptyJob.ApplicationUserId = userId;

            if (await TryUpdateModelAsync(
                emptyJob,
                "job",
                j => j.Name,  j => j.Number, j => j.EmployerId, j => j.Description
            ))
            {
                _context.Job.Add(emptyJob);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            //Select Employer's Id if TryUpdateModelAsync fails.
            PopulateEmployersDropDownList(_context, emptyJob.EmployerId);
            return Page();
        }
    }
}
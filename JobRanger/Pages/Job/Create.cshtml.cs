using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JobRanger.Data;
using JobRanger.Models;

using Microsoft.EntityFrameworkCore;


namespace JobRanger.Pages.Job
{
    public class CreateModel : EmployerNamePageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public CreateModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Employer> Employers { get; set; }

        public IActionResult OnGet()
        {
            PopulateEmployersDropDownList(_context);
            return Page();
        }

       
        [BindProperty]
        public Models.Job Job { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {

                return Page();
            }

            var emptyJob = new Models.Job();

            if (await TryUpdateModelAsync<Models.Job>(
                emptyJob,
                "job",
                j => j.Name, j => j.Number, j => j.EmployerId, j=>j.Description
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
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

namespace JobRanger.Pages.Agency
{
    public class CreateModel : AgencyIconSrcPageModel
    {
        
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public CreateModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateAgencyIconSrcDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Models.Agency Agency { get; set; }
        
     public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                Debug.WriteLine(ModelState.IsValid);
                return Page();
            }
            var emptyAgency = new Models.Agency();
            Debug.WriteLine(emptyAgency);
            if (await TryUpdateModelAsync<Models.Agency>(
                emptyAgency,
                "agency",
                a=>a.Name, a=>a.IconSrc, a=>a.WebSite

            ))
            {
                Debug.WriteLine(emptyAgency);
                _context.Agency.Add(emptyAgency);
                await _context.SaveChangesAsync();
            }
            
            return RedirectToPage("./Index");
        }
    }
}
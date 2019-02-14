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

namespace JobRanger.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public CreateModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EmployerId"] = new SelectList(_context.Employer, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; }
       
        public async Task<IActionResult> OnPostAsync()
        {

           if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyContact = new Models.Contact();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            emptyContact.ApplicationUserId = userId;

           

            if (await TryUpdateModelAsync<Models.Contact>(
            emptyContact,
            "contact",
            c=>c.Name,
            c=>c.Address1,
            c=>c.Address2,
            c=>c.City,
            c=>c.Email,
            c=>c.EmployerId,
            c=>c.PhoneNumber,
            c=>c.State,
            c=>c.ZipCode,
            c=>c.Title
                ))
            {
                
                _context.Contact.Add(emptyContact);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            return Page();

        }
    }
}
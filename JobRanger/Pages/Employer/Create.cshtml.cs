using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace JobRanger.Pages.Employer
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty] public Models.Employer Employer { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var emptyEmployer = new Models.Employer();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            emptyEmployer.ApplicationUserId = userId;

            if (await TryUpdateModelAsync(
                emptyEmployer,
                "employer",
                e=>e.ApplicationUserId,
                e=>e.Name,
                e=>e.Address1,
                e=>e.Address2,
                e=>e.City,
                e=>e.PhoneNumber,
                e=>e.State,
                e=>e.WebSite,
                e=>e.ZipCode
            ))
            {
                _context.Employer.Add(emptyEmployer);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }



            return Page();
        }
        
    }
}
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Employer
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty] public Models.Employer Employer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Employer = await _context.Employer.FirstOrDefaultAsync(m => m.Id == id);

            if (Employer == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            Employer.ApplicationUserId = userId;

            _context.Attach(Employer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployerExists(Employer.Id))
                    return NotFound();
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool EmployerExists(int id)
        {
            return _context.Employer.Any(e => e.Id == id);
        }
    }
}
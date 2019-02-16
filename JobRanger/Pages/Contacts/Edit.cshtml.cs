using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Contacts
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty] public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Contact = await _context.Contact
                .Include(c => c.Employer).FirstOrDefaultAsync(m => m.Id == id);

            if (Contact == null) return NotFound();
            ViewData["EmployerId"] = new SelectList(_context.Employer, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            Contact.ApplicationUserId = userId;

            _context.Attach(Contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(Contact.Id))
                    return NotFound();
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
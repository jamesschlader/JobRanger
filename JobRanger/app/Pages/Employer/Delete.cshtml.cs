using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Employer
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            Employer = await _context.Employer.FindAsync(id);
            await _context.Entry(Employer).Collection(s => s.Jobs).LoadAsync();
            await _context.Entry(Employer).Collection(s => s.Contacts).LoadAsync();

            if (Employer != null)
            {
                _context.Employer.Remove(Employer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
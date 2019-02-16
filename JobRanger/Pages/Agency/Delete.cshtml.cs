using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Agency
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty] public Models.Agency Agency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Agency = await _context.Agency.FirstOrDefaultAsync(m => m.Id == id);

            if (Agency == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            Agency = await _context.Agency.FindAsync(id);

            if (Agency != null)
            {
                _context.Agency.Remove(Agency);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
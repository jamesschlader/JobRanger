using System.Threading.Tasks;
using JobRanger.Data;
using JobRanger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Interaction Interaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Interaction = await _context.Interactions
                .Include(i => i.Job)
                .ThenInclude(j => j.Employer)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Interaction == null) return NotFound();
            return Page();
        }
    }
}
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Agency
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.Attach(Agency).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                /* if (!AgencyExists(Agency.Id))
                 {
                     return NotFound();
                 }
                 else
                 {
                     throw;
                 }*/
            }

            return RedirectToPage("./Index");
        }

        //   private bool AgencyExists(int id)
        //  {
        // return _context.Agency.Any(e => e.Id == id);
        //  }
    }
}
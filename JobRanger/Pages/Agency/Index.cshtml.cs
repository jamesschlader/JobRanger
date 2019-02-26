using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Agency
{
    public class Index : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Index(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Agency> Agency { get; set; }


        public async Task OnGetAsync()
        {
            Agency = await _context.Agency
                .OrderBy(a=>a.Name)
                .ToListAsync();
        }
    }
}
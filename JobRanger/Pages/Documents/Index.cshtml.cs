using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Documents
{
    public class IndexModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public IndexModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Document> Document { get;set; }

        public async Task OnGetAsync()
        {
            Document = await _context.Document.ToListAsync();
        }
    }
}

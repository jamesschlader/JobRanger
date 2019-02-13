using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Agency
{
    public class Index : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public Index(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Agency> Agency { get;set; }

      

      public async Task OnGetAsync()
        {
           
           Agency = await _context.Agency
                .ToListAsync();

        }
    }
}

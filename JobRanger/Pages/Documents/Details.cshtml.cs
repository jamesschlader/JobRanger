using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobRanger.Data;
using JobRanger.Models;

namespace JobRanger.Pages.Documents
{
    public class DetailsModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public DetailsModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Document Document { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Document = await _context.Document.FirstOrDefaultAsync(m => m.Id == id);
            UnicodeEncoding unicode = new UnicodeEncoding();

           
            Debug.WriteLine(unicode.GetString(Document.RawContent));
            var content = "";

            using (MemoryStream memoryStream = new MemoryStream(1048576))
            {
                await memoryStream.ReadAsync(Document.RawContent, 0, Document.RawContent.Length);
                Debug.WriteLine(memoryStream.ToString());
                content = memoryStream.ToString();
            }

            Document.Content = unicode.GetString(Document.RawContent);

            if (Document == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

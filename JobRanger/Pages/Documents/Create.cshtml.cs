using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JobRanger.Data;
using JobRanger.Models;
using JobRanger.Utilities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Documents
{
    public class CreateModel : PageModel
    {
        private readonly JobRanger.Data.ApplicationDbContext _context;

        public CreateModel(JobRanger.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public FileUpLoad FileUpLoad { get; set; }
        
       public async Task<IActionResult> OnPostAsync()
        {
            // Perform an initial check to catch FileUpload class
            // attribute violations.
           
            var title = Request.Form["FileUpLoad.Title"];
            var myContent = Request.Form["FileUpLoad.Document"];
            
            
            Debug.WriteLine(FileUpLoad.Title);
            Debug.WriteLine(FileUpLoad.Document);
            Debug.WriteLine(title);
            Debug.WriteLine(myContent.GetType());
           
            Debug.WriteLine(ModelState.IsValid);

           
            var content = await FileHelpers.ProcessFormFile(FileUpLoad.Document, ModelState);

            // Perform a second check to catch ProcessFormFile method
            // violations.
            Debug.WriteLine(ModelState.IsValid);
            if (!ModelState.IsValid)
            {
               
                return Page();
            }
            var document = new Document()
            {
                Name = FileUpLoad.Title,
                RawContent = content,
                ContentSize = FileUpLoad.Document.Length,
                UploadDT = DateTime.UtcNow
            };


            Debug.WriteLine(document.Content);
            Debug.WriteLine(document.ContentSize);
            Debug.WriteLine(document.UploadDT);

            _context.Document.Add(document);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
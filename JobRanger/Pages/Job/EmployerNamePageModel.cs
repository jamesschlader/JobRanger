using System.Linq;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Job
{
    public class EmployerNamePageModel : PageModel
    {
        public SelectList EmployerNameSelectList { get; set; }

        public void PopulateEmployersDropDownList(ApplicationDbContext context,
            object selectEmployer = null)
        {
            var employersQuery = from employer in context.Employer orderby employer.Name select employer;

            EmployerNameSelectList = new SelectList(employersQuery.AsNoTracking(), "Id", "Name", selectEmployer);
        }
    }
}
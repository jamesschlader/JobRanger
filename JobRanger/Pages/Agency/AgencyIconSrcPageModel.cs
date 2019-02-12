using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Agency
{
    public class AgencyIconSrcPageModel : PageModel
    {
        public SelectList AgencyIconSrcSelectList { get; set; }

        public void PopulateAgencyIconSrcDropDownList(ApplicationDbContext context, object selectIcons = null)
        {
            var iconQuery = from icon in context.Icons orderby icon.Source select icon;

            AgencyIconSrcSelectList = new SelectList(iconQuery.AsNoTracking(), "Source", "Source", selectIcons);
        }

       
    }
}

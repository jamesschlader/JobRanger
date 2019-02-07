using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobRanger.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Pages.Interactions
{
    public class InteractionTypesPageModel : PageModel
    {
        public SelectList InteractionTypeSelectList { get; set; }

        public void PopulateInteractionTypesDropDownList(ApplicationDbContext context,
            object selectInteraction = null)
        {
            var interactionsQuery = from interactionTypes in context.InteractionTypes orderby interactionTypes.Name select interactionTypes;

            InteractionTypeSelectList = new SelectList(interactionsQuery.AsNoTracking(), "Id", "Name", selectInteraction);
        }
    }
}

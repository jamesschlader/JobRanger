using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobRanger.Models
{
    public class Interaction
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Action Date")]
        public DateTime TargetTime { get; set; }

        public string Notes { get; set; }

        public int InteractionTypesId { get; set; }
        public virtual InteractionTypes Type { get; set; }

        public int JobId { get; set; }
        public virtual Job Job { get; set; }
        
    }
}

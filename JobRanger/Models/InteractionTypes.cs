using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobRanger.Models
{
    public class InteractionTypes
    {
        public int Id { get; set; }

        [DisplayName("Action")]
        public string Name { get; set; }

        [DisplayName("Action")]
        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}

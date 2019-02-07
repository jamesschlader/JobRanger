using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobRanger.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Job Number")]
        public int Number { get; set; }

        public string Description { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}

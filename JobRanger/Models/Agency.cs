using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobRanger.Models
{
    public class Agency 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string WebSite { get; set; }
      public string IconSrc { get; set; }
        
        public virtual ICollection<Job> Jobs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobRanger.Models
{
    public class Icons
    {
        public int Id { get; set; }

        [Required]
        public string Source { get; set; }
    }
}

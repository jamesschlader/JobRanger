using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace JobRanger.Models
{
    public class FileUpLoad
    {
        [Required]
        [Display(Name = "Title")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }


        [Required]
        [Display(Name = "Document")]
        public IFormFile Document { get; set; }
    }
}

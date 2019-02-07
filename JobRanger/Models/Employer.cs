using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace JobRanger.Models
{
    public class Employer
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Employer")]
        public string Name { get; set; }

        public string WebSite { get; set; }

        [DisplayName("Phone Number")]
       // [Phone]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; set; }

        [StringLength(75)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }

        public string State { get; set; }

        
        [DisplayName("Zip Code")]
        [RegularExpression("\\d{5}", ErrorMessage = "Please enter valid Zip Code")]
        public string ZipCode { get; set; }

        //public int JobId { get; set; }

        public ICollection<Job> Jobs { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}

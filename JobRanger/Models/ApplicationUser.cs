using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace JobRanger.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("First Name")] public string FirstName { get; set; }

        [DisplayName("Last Name")] public string LastName { get; set; }

        public virtual ICollection<Employer> Employers { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
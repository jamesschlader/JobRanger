﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace JobRanger.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        public string Title { get; set; }

        [DataType(DataType.EmailAddress)] public string Email { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [StringLength(75)] public string Address1 { get; set; }

        [StringLength(50)] public string Address2 { get; set; }

        [StringLength(50)] public string City { get; set; }

        public string State { get; set; }


        [DisplayName("Zip Code")]
        [RegularExpression("\\d{5}", ErrorMessage = "Please enter valid Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [ForeignKey("ApplicationUserId")] public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [DisplayName("Employer")] public int? EmployerId { get; set; }

        public Employer Employer { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}
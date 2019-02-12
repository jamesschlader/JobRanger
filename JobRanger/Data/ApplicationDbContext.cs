using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JobRanger.Models;


namespace JobRanger.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JobRanger.Models.Agency> Agency { get; set; }
        public DbSet<JobRanger.Models.Employer> Employer { get; set; }
        public DbSet<JobRanger.Models.Job> Job { get; set; }
        public DbSet<JobRanger.Models.Contact> Contact { get; set; }
        public DbSet<JobRanger.Models.Interaction> Interactions { get; set; }
        public DbSet<JobRanger.Models.InteractionTypes> InteractionTypes { get; set; }
        public DbSet<JobRanger.Models.ApplicationUser> ApplicationUser { get; set; }
        public DbSet<JobRanger.Models.Document> Document { get; set; }
        public DbSet<JobRanger.Models.Icons> Icons { get; set; }
    
    }
}

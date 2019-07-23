using JobRanger.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobRanger.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Agency> Agency { get; set; }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
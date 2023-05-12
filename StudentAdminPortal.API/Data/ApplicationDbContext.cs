using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System.Security.Cryptography.X509Certificates;

namespace StudentAdminPortal.API.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}

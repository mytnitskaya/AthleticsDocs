using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class AthleticsDocsContext : IdentityDbContext
    { 
        public DbSet<Student> Students { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        public AthleticsDocsContext(DbContextOptions<AthleticsDocsContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
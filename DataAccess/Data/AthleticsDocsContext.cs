using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class AthleticsDocsContext : IdentityDbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<LevelOfTraining> LevelOfTrainings { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Student> Students { get; set; }


        public AthleticsDocsContext(DbContextOptions<AthleticsDocsContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
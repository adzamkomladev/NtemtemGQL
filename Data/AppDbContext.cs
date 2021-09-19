using Microsoft.EntityFrameworkCore;
using NtemtemGQL.Extensions;
using NtemtemGQL.Models;

namespace NtemtemGQL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<WorkPeriod> WorkPeriods { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Relationships();
            modelBuilder.Seed();
        }
    }
}
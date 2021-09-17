using Microsoft.EntityFrameworkCore;
using NtemtemGQL.Models;

namespace NtemtemGQL.Data
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Organization> Organizations { get; set; }
    }
}
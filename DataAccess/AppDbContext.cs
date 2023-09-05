using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
      public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreatedAsync();
        }
       public DbSet<Host> Hosts { get; set; }
        public DbSet<Query> Queries{ get; set; } 

    }
}

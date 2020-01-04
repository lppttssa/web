using Microsoft.EntityFrameworkCore;

namespace FilterSortPagingApp.Models
{
    public class PilotsContext : DbContext
    {
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<City> Cities { get; set; }
        public PilotsContext(DbContextOptions<PilotsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
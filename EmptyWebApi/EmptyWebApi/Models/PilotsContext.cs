using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EmptyWebApi.Models
{
    public class PilotsContext : DbContext
    {
        public DbSet<Pilot> Pilots { get; set; }
        public PilotsContext(DbContextOptions<PilotsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

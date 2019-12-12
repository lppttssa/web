using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _4Task.Models
{
    public class CityContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        //public DbSet<Order> Orders { get; set; }

        public CityContext(DbContextOptions<CityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

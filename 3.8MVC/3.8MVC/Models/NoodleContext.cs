using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _3._8MVC.Models
{
    public class NoodleContext : DbContext
    {
        public DbSet<Noodle> Noodles { get; set; }
        public DbSet<Order> Orders { get; set; }

        public NoodleContext(DbContextOptions<NoodleContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

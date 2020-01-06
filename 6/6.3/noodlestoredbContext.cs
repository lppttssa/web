using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _6._3
{
    public partial class noodlestoredbContext : DbContext
    {
        public noodlestoredbContext()
        {
        }

        public noodlestoredbContext(DbContextOptions<noodlestoredbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Noodles> Noodles { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=noodlestoredb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.NoodleId);

                entity.HasOne(d => d.Noodle)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.NoodleId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

﻿using Microsoft.EntityFrameworkCore;

namespace FilterSortPagingApp.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
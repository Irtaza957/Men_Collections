using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Men_Collection.Models;

namespace Men_Collection.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Men_Collection.Models.Product> Product { get; set; }
        public DbSet<Men_Collection.Models.Category> Category { get; set; }
        public DbSet<Men_Collection.Models.Order> Order { get; set; }
    }
}

using System.Collections.Generic;
using System.Reflection.Emit;

using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                          new Category { id = 1, DisplayOrder = 1, Name = "Action" },
                          new Category { id = 2, DisplayOrder = 2, Name = "SciFi" },
                          new Category { id = 3, DisplayOrder = 3, Name = "History" }
                );
        }
    }
}
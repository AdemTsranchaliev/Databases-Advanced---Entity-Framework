using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.EntityConfiguration;
using P03_SalesDatabase.Data.Models;
using System;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext()
        {

        }

        public SalesContext(DbContextOptions contextOptions)
        {

        }

        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Store> Store { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new SalesConfig());
            modelBuilder.ApplyConfiguration(new StoreConfig());
        }
    }
}

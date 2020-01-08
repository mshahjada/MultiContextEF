using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class PrimaryContext: DbContext
    {
        public PrimaryContext() : base("DBContext1")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("config");

            // Fluent API configuration
        }

        public DbSet<Product> Products { get; set; }

       
    }

    public class SecondaryContext : DbContext
    {
        public SecondaryContext() : base("DBContext1")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("po");
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Purchase>()
            //    .HasRequired<Product>(x => x.Product).WithMany().WillCascadeOnDelete(false);

            // Fluent API configuration
        }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class ThirdContext : DbContext
    {
        public ThirdContext() : base("DBContext1")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("sale");

            // Fluent API configuration
        }
        public DbSet<SaleOrder> SaleOrders { get; set; }
    }
}
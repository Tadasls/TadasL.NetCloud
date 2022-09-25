using HW03_WarehouseRental.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace HW03_WarehouseRental.Domains.Services
{
    public class WareHouseDbContext : DbContext
    {
        public WareHouseDbContext()
        {

        }
        public WareHouseDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlite(@"Data Source=WareHouseDb.db");
                optionsBuilder.UseLazyLoadingProxies(); 
            }
            base.OnConfiguring(optionsBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AuthorBlog>().HasKey(sc => new { sc.AuthorId, sc.BlogId });

        //    modelBuilder.Entity<AuthorBlog>()
        //        .HasOne(sc => sc.Author)
        //        .WithMany(s => s.AuthorBlog)
        //        .HasForeignKey(sc => sc.AuthorId);


        //    modelBuilder.Entity<AuthorBlog>()
        //        .HasOne(sc => sc.Blog)
        //        .WithMany(s => s.AuthorBlog)
        //        .HasForeignKey(sc => sc.BlogId);
        //}



    }
}
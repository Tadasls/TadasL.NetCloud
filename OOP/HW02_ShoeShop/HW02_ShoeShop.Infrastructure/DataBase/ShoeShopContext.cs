using HW02_ShoeShop.Domais.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_ShoeShop.Infrastructure.DataBase
{
    public class ShoeShopContext : DbContext
    {
        public ShoeShopContext()
        {

            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ShoeShopDataBase.db");
        }

        // Registruojame nauja lentele savo duombazeje
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<ShoeSize> ShoeSizes { get; set; }
        public string DbPath { get; } // ConnectionString

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQL Server Configuration example
            // Server == Data Source
            // Database == Initial Catalog
            // optionsBuilder.UseSqlServer($"Server=(localdb)\\SqlServerDb; Database");

            // base.OnConfiguring(optionsBuilder);
            // DbPath == ConnectionString
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            // Needs: Microsoft.EntityFrameworkCore.Proxies

            // Kuo skiriasi LazyLoading nuo EagerLoading
            optionsBuilder.UseLazyLoadingProxies();


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Shoe>()
                .HasKey(a => a.ShoesId);
        }

    }
}

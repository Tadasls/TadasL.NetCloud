using Microsoft.EntityFrameworkCore;
using PartitionUzd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionUzd.Database
{
    public class PCDBContext : DbContext
    {
              
         private string connectionString = @"Server=localhost;Database=NeedForSppedDBPirma;Trusted_Connection=True;TrustServerCertificate=true;";
       
        public DbSet<Email> Emails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Root> Roots { get; set; }
        public DbSet<Tenant> Tenants { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Project>()
                .HasAlternateKey(p => p.partitionKey )
                .IsClustered();

            modelBuilder.Entity<Tenant>()
                .HasAlternateKey(p => p.userPrincipalName)
                .IsClustered();
        }

    }
}

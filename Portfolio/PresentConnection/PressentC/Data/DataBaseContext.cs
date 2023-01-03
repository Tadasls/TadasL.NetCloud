
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PressentConnection.Program;

namespace PressentConnection.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Root> Roots { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Project>().HasData(UsersInitialData.userInitialDataSeed); 


            modelBuilder.Entity<Tenant>()
            .HasKey(t=>t.objectId);

            modelBuilder.Entity<Email>()
           .HasKey(t => t.email);





        }



    }

}

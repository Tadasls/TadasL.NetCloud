using Microsoft.EntityFrameworkCore;
using PresentC2invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressentConnection.Data
{
    public class DataBaseContext : DbContext 
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }



    }

}

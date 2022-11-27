using Microsoft.EntityFrameworkCore;
using P02_Rest_Endpoints.Models;

namespace P02_Rest_Endpoints.Data
{
    public class DataContex : DbContext
    {

        public DataContex(DbContextOptions<DataContex> options) : base(options)
        {

        }

        public DbSet<DBData> Duomenys { get; set; }



    }
}

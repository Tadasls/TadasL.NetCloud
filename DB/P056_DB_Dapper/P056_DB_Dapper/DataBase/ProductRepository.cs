using Dapper;
using Microsoft.Data.Sqlite;
using P056_DB_Dapper.Database;
using P056_DB_Dapper.Database.Dapper;
using P056_DB_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_DB_Dapper.DataBase
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public ProductRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

       

        public void Create(Product product)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO Product (Name, Description)
                VALUES (@Name, @Description);", product);
        }

        public IEnumerable<Product> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);
            return connection.Query<Product>(@"
                SELECT rowid AS Id, Name, Description
                FROM Product");

        } 
        public int Delete(string productName)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);
            var affectedRows = connection.Execute(@"
                    DELETE
                    FROM Product
                    WHERE Name = @Name;", new { Name = productName });
            return affectedRows;
        }

       
    }
}

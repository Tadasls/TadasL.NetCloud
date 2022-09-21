using Dapper;
using Microsoft.Data.Sqlite;
using NoteBook_App.DataBase.Dapper;
using NoteBook_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook_App.DataBase
{
    public class NoteBookRepository : INoteBookRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public NoteBookRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }



        public void Create(NoteBook noteBook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO NoteBook (Name, Description)
                VALUES (@Name, @Description);", noteBook);
        }

        public IEnumerable<NoteBook> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);
            return connection.Query<NoteBook>(@"
                SELECT rowid AS Id, Name, Description
                FROM NoteBook");

        }
        public int Delete(string productName)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);
            var affectedRows = connection.Execute(@"
                    DELETE
                    FROM NoteBook
                    WHERE Name = @Name;", new { Name = productName });
            return affectedRows;
        }


    }
}
using Dapper;
using Microsoft.Data.Sqlite;
using NoteBook_App.DataBase.Dapper;
using NoteBook_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook_App.DataBase
{
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;

        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

       
        public void Setup()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

     
            var table = connection.Query<string>(@"
                SELECT name
                FROM sqlite_master
                WHERE type = 'table'
                    AND name = 'Notebook';");
            var tableName = table.FirstOrDefault();

           if (!string.IsNullOrEmpty(tableName) && tableName == "Notebook")
                return;

            connection.Execute(@"
                CREATE TABLE Notebook (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name VARCHAR(100) NOT NULL,
                CreationDatetime DATETIME DEFAULT current_timestamp,
                Description VARCHAR(1000) NULL,
                Priority VARCHAR(100) DEFAULT 0);");




        }
    }
}
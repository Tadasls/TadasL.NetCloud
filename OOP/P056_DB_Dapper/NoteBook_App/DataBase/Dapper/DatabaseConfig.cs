using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook_App.DataBase.Dapper
{
    public class DatabaseConfig
    {
        public DatabaseConfig()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnString = "Data Source=" + Path.Join(path, "ProductDapperNew.db");
        }

        public string ConnString { get; }
    }
}

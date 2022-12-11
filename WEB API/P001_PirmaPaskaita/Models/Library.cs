using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppMSSQL.Models.Enums;

namespace WebAppMSSQL.Models
{
    public class Library
    {   
        public List<Book> Books { get; set; }
        public List<LocalUser> LocalUsers { get; set; }

        public Library(List<Book> books, List<LocalUser> localUsers)
        {
            Books = books;
            LocalUsers = localUsers;
        }


    }
}
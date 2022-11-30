using ApiMokymai.Interfaces;
using ApiMokymai.Models;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.Enums;

namespace ApiMokymai.Data
{
    public class BookSet : IBookSet
    {
        //data seed klaseje kaip privatus / o kreipiantis i viesa lista paduodami duomenys is privataus


        private List<Book> books = new List<Book>()
            {
            new Book(1, "Biblija", "Dievas", ECoverType.Hardcover , 2000),
            new Book(2, "Vadovelis", "Mokytojas", ECoverType.Electronic , 2001),
            new Book(3, "Vadovelis2", "Daile", ECoverType.Electronic , 2003),
            new Book(4, "Vadovelis5", "Albumas", ECoverType.Paperback , 2025),
            new Book(5, "Vadovelis6", "vasara", ECoverType.Electronic , 2004),
            new Book(6, "Vadovelis2", "Mokytojas", ECoverType.Hardcover , 2008),
            new Book(7, "Vadovelis4", "Mokytojas", ECoverType.Hardcover , 2010),
            new Book(8, "Vadovelis", "Mokytojas", ECoverType.Electronic , 2015),
            new Book(9, "Vadovelis3", "Mokytojas", ECoverType.Paperback , 2019),
            new Book(10, "Vadovelis1", "Mokytojas", ECoverType.Hardcover , 2020),
            };

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }



    }
}



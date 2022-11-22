using ApiMokymai.Books;

namespace ApiMokymai.Data
{
    public class BookSet : IBookSet
    {
       
        private List<Book> books = new List<Book>()
            {
            new Book(1, "Biblija", "Dievas", ECoverType.Hardcover , 2000),
            new Book(2, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(3, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(4, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(5, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(6, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(7, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(8, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(9, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            new Book(10, "Vadovelis", "Mokytojas", ECoverType.Electric , 2020),
            };

       public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }



    }
}



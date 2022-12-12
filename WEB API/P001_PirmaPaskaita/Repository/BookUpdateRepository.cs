using System.Linq;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Repository.IRepository;

namespace WebAppMSSQL.Repository
{
    public class BookUpdateRepository : Repository<Book>, IUpdateBookRepository
    {
        private readonly KnygynasContext _db;

        public BookUpdateRepository(KnygynasContext db) : base(db)
        {
            _db = db;
        }

        public Book Update(Book book)
        {
           
            book.UpdateDateTime = DateTime.Now;
            _db.Books.Update(book);
            _db.SaveChanges();

            return book;
        }

        public List<Book> Filter(Book book)
        {
            //var books = _db.Books.Where(e => e.Title == book.Title && e.Author == book.Author && e.ECoverType == book.ECoverType).ToList();


            var books = _db.Books
                .Where(b => b.Title.Contains(book.Title != null ? book.Title : "") 
                         || b.Author.Contains(book.Author != null ? book.Author : "")
                         ).ToList();

            return  books;



        }

        public void UpdateTakenLibraryBooksKN(int bookId, int modifier)
        {
            Book book = _db.Books.First(u => u.Id == bookId);
            book.Stock += modifier;
            _db.Books.Update(book);
            _db.SaveChanges();
        }



    }
}
using Microsoft.EntityFrameworkCore;
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
        public void Save()
        {
            _db.SaveChanges();
        }


        public void Update(Book book)
        {
            book.Updated = DateTime.Now;
            _db.Books.Update(book);
            _db.SaveChanges();
           // return book;
        }

      

        public List<Book> Filter(Book book)
        {
          
            var books = _db.Books
                .Where(b => b.Title.Contains(book.Title != null ? book.Title : "") 
                         || b.Author.Contains(book.Author != null ? book.Author : "")
                         ).ToList();

            return  books;


        }




    }
}
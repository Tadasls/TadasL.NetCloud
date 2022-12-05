using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
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
    }
}
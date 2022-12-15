using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class StockService : IStockService
    {
        private readonly KnygynasContext _db;
        public StockService(KnygynasContext db)
        {
            _db = db;
        }
        public void UpdateTakenLibraryBooksKN(int bookId, int modifier)
        {
            Book book = _db.Books.First(u => u.Id == bookId);
            book.Stock += modifier;
            _db.Books.Update(book);
            _db.SaveChanges();
        }
        public void UpdateTakenLibraryBooks(int userId, int modifier)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            user.HasAmountOfBooks += modifier;
            _db.LocalUsers.Update(user);
            _db.SaveChanges();
        }

    }
}

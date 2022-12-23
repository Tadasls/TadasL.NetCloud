using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
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
        public async Task UpdateTakenLibraryBooksKN(int bookId, int modifier)
        {
            Book book = _db.Books.First(u => u.Id == bookId);
            book.Stock += modifier;
            _db.Books.Update(book);
           await _db.SaveChangesAsync();
        }
        public async Task UpdateTakenLibraryBooks(int userId, int modifier)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            user.HasAmountOfBooks += modifier;
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();
        }



        public async Task PridetiTaskuUzPrisijungima(int userId, int modifier)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            if (user.WasOnline.Value.Day != DateTime.Today.Day && user.WasOnline.Value.Month != DateTime.Today.Month)
            {
                user.KluboTaskai += modifier;
                _db.LocalUsers.Update(user);
                await _db.SaveChangesAsync();
            }
           

        }

        public async Task AtnaujintiPrisijungimoData(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            user.WasOnline = DateTime.Now;
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();

        }





    }
}

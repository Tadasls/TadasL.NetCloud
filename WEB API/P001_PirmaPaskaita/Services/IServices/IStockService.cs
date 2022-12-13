namespace WebAppMSSQL.Services.IServices
{
    public interface IStockService
    {
        void UpdateTakenLibraryBooks(int userId, int modifier);
        void UpdateTakenLibraryBooksKN(int bookId, int modifier);
    }
}
namespace WebAppMSSQL.Services.IServices
{
    public interface IStockService
    {
        Task UpdateTakenLibraryBooks(int userId, int modifier);
        Task UpdateTakenLibraryBooksKN(int bookId, int modifier);
    }
}
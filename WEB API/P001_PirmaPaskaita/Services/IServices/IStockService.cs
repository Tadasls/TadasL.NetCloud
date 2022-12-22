namespace WebAppMSSQL.Services.IServices
{
    public interface IStockService
    {
        Task PapildytiTaskaisUzPrisijungima(int userId, int modifier);
        Task UpdateTakenLibraryBooks(int userId, int modifier);
        Task UpdateTakenLibraryBooksKN(int bookId, int modifier);
    }
}
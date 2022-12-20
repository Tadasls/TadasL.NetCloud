using ApiMokymai.Models.ApiModels;

namespace L05_Tasks_MSSQL.Services
{
    public interface IFakeApiProxyService
    {
        Task CreateBook(BookApiModel data);
        Task<IEnumerable<BookApiModel>> GetBooks();
    }
}
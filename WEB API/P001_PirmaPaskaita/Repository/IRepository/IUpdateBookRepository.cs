using L05_Tasks_MSSQL.Models;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IUpdateBookRepository : IBookRepository<Book>
    {
        Book Update(Book book);
    }
}
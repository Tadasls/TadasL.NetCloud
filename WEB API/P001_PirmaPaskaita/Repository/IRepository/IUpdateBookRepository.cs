using L05_Tasks_MSSQL.Models;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IUpdateBookRepository : IRepository<Book>
    {
        Book Update(Book book);
        List<Book> Filter(Book book);
    }
}
using WebAppMSSQL.Models;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IUpdateBookRepository : IRepository<Book>
    {
       void Update(Book book);
        List<Book> Filter(Book book);
   
    }
}
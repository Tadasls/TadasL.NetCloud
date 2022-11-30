using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;

namespace L05_Tasks_MSSQL.Services
{
    public interface IBookWrapper
    {
        GetBookDto Bind(Book book);

        Book Bind(CreateBookDto book);

        Book Bind(UpdateBookDto book);
    }
}
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IBookWrapper
    {
        GetBookDto Bind(Book book);

        Book Bind(CreateBookDto book);

        Book Bind(UpdateBookDto book);

        Book Bind(FilterBooksRequestDto book);
    }
}
using ApiMokymai.Data.DTO;
using ApiMokymai.Models;

namespace ApiMokymai.Services
{
    public interface IBookWraper
    {
        GetBookDto Bind(Book book);
        Book Bind(CreateBookDto book);
        Book Bind(UpdateBookDto book);
    }
    

}

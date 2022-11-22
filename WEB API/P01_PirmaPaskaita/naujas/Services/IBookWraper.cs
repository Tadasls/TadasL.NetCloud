using ApiMokymai.Data.DTO;
using ApiMokymai.Data;

namespace ApiMokymai.Services
{
    public interface IBookWraper
    {
        GetBookDto Bind(Book book);
        Book Bind(CreateBookDto book);
        Book Bind(UpdateBookDto book);
    }
    

}

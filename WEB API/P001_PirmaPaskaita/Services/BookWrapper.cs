using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.Enums;

namespace L05_Tasks_MSSQL.Services
{

    public class BookWrapper : IBookWrapper
    {
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto
            {
                Id = book.Id,
                LeidybosMetai = book.PublishYear,
                PavadinimasIrAutorius = book.Title + " " + book.Author
            };
        }

        public Book Bind(CreateBookDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas)
            };
        }

        public Book Bind(UpdateBookDto book)
        {
            return new Book
            {
                Id = book.Id,
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas)
            };
        }


    }
}
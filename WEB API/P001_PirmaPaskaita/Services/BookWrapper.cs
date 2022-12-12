using WebAppMSSQL.Interfaces;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.Enums;

namespace WebAppMSSQL.Services
{

    public class BookWrapper : IBookWrapper
    {
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto
            {
                Id = book.Id,
                LeidybosMetai = book.PublishYear,
                PavadinimasIrAutorius = book.Title + " " + book.Author,
                KnyguKiekis = book.Stock,
            };
        }

        public Book Bind(CreateBookDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
                Stock = book.KnyguKiekis,
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
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
                Stock = book.KnyguKiekis,
            };
        }
        public Book Bind(FilterBooksRequestDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            };

        }


    }
}
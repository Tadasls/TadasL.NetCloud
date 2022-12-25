using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.Enums;
using WebAppMSSQL.Services.IServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebAppMSSQL.Services.Wraperiai
{

    public class BookWrapper : IBookWrapper
    {
        public BookWrapper()
        {

        }


        private readonly KnygynasContext _db;
        public BookWrapper(KnygynasContext db)
        {
            _db = db;
        }


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
                Stock = book.KnyguKiekis,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),

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
                Stock = book.KnyguKiekis,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
                Updated = DateTime.Now,
                EBookStatus = (EBookStatus)Enum.Parse(typeof(EBookStatus), book.KnygosStatusas)

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
using ApiMokymai.Data;
using ApiMokymai.Data.DTO;
using ApiMokymai.Models;

namespace ApiMokymai.Services
{
    public class BookWrapper : IBookWraper
    {
        
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto {

                Id = book.Id,
                PavadinimasIrAutorius = $"{book.Title}ir{book.Author}",
                LeidybosMetai = book.PublishYear,

            };
        }
        public Book Bind (CreateBookDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                Cover  = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            };       
        }

        public Book Bind(UpdateBookDto book)
        {
            return new Book
            {
                Id= book.Id,
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                Cover = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            };
        }

   
    }
}

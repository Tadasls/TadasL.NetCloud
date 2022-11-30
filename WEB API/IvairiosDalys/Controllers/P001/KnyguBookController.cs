using L05_Tasks_MSSQL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers.P001
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnyguBookController : ControllerBase
    {
        List<Book> allBooks = new List<Book>()
        {
            new Book { Id = 1, Title = "Knyga1", Author = "Autorius1", PublishYear = 2001 },
            new Book { Id = 2, Title = "Knyga2", Author = "Autorius2", PublishYear = 2002 },
            new Book { Id = 3, Title = "Knyga3", Author = "Autorius3", PublishYear = 2003 },
            new Book { Id = 4, Title = "Knyga4", Author = "Autorius4", PublishYear = 2004 },
            new Book { Id = 5, Title = "Knyga5", Author = "Autorius5", PublishYear = 2005 },
            new Book { Id = 6, Title = "Knyga6", Author = "Autorius6", PublishYear = 2006 },
            new Book { Id = 7, Title = "Knyga7", Author = "Autorius7", PublishYear = 2007 },
            new Book { Id = 8, Title = "Knyga8", Author = "Autorius8", PublishYear = 2008 },
            new Book { Id = 9, Title = "Knyga9", Author = "Autorius9", PublishYear = 2009 }
        };

        [HttpGet("RandomBook")]
        public Book GetMeAnyBook()
        {
            var anyBook = allBooks[Random.Shared.Next(allBooks.Count)];
            return anyBook;
        }

        [HttpGet("{id}")]
        public Book GetMeABook(int id)
        {
            return allBooks.FirstOrDefault(b => b.Id == id);
        }

        [HttpGet("Search")]
        public IEnumerable<Book>? abcdefg(int? id, string? title, string? author)
        {
            if (id != null)
                return from book in allBooks
                       where book.Id == id
                       select book;

            if (title != null)
                return from book in allBooks
                       where book.Title.Contains(title)
                       select book;

            if (author != null)
                return from book in allBooks
                       where book.Author.Contains(author)
                       select book;

            return null;
        }

    }
}
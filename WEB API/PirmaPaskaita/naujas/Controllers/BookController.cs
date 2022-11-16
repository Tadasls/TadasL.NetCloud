using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace naujas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> books = new List<Book>
        {   
                new Book(){Id =1, Pavadinimas = "Jonas", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =2, Pavadinimas = "Jonas2", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =3, Pavadinimas = "Jonas3", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =4, Pavadinimas = "Jonas4", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =5, Pavadinimas = "Jonas5", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =6, Pavadinimas = "Jonas6", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =7, Pavadinimas = "Jonas7", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =8, Pavadinimas = "Jonas8", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =9, Pavadinimas = "Jonas9", Autorius = "Jonaitis", leidybosMetai = 2018},
                new Book(){Id =10, Pavadinimas = "Jonas10", Autorius = "Jonaitis", leidybosMetai = 2018},
            };
    

            [HttpGet("books")]
        public List<Book> GetMyBooks()
        {
            return books;              
        }

        [HttpGet("books/{id}")]
        public Book? GetMyBooksById(int id)
        {
            return books.FirstOrDefault(p => p.Id == id);
        }

        [HttpGet("booksTitle/{Autorius}")]
        public Book? GetMyBooksById(string Autorius)
        {
            return books.FirstOrDefault(p => p.Autorius == Autorius); 
           
        }


        [HttpGet("pagal")]
        public Book? GetMyPersonByNameAndSurname(string Autorius, string Pavadinimas)
        {
            return books.FirstOrDefault(p => p.Autorius == Autorius && p.Pavadinimas == Pavadinimas);
        }






    }
}

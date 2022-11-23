using ApiMokymai.Data;
using ApiMokymai.Data.DTO;
using ApiMokymai.Interfaces;
using ApiMokymai.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers.P003
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _bookManager;
       
       

        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
          
            

        }

        [HttpGet]
        public ActionResult<List<GetBookDto>> GetBooks()
        {
            return Ok(_bookManager.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<GetBookDto> GetBookById(int id)
        {
            return Ok(_bookManager.Get(id));
        }

        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> FilterBooks(FilterBookReqestDto book)
        {
            Dictionary<string, string> filter = new Dictionary<string, string>();

            filter.Add(nameof(book.Pavadinimas), book.Pavadinimas);
            filter.Add(nameof(book.Autorius), book.Autorius);
            filter.Add(nameof(book.KnygosTipas), book.KnygosTipas);

            return Ok(_bookManager.Filter(filter));
        }

        [HttpPost]
        public ActionResult PostBook(CreateBookDto book)
        {
            return Ok(_bookManager.Add(book));
        }

        [HttpPut]
        public ActionResult PutBook(UpdateBookDto book)
        {
            _bookManager.Update(book);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            _bookManager.Delete(id);
            return Ok();
        }



    }
}

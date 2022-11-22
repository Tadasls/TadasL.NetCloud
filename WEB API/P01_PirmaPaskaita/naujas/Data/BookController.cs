using ApiMokymai.Books;
using ApiMokymai.Data.DTO;
using ApiMokymai.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly IOperationTransient _operationTransient;
        

        //public BookController(IOperationTransient operationTransient)
        //{
        //    _operationTransient = operationTransient;
        //}

        [HttpGet("All")]
        public ActionResult<List<GetBookDto>> GetBooks()
        {

            throw new NotImplementedException();
            //return Ok(new
            //{
            //    Transient = _operationTransient.GetOperationId(),
            //});


        }

        [HttpGet("{id}")]
        public ActionResult<GetBookDto> GetBookById(int id) {
            throw new NotImplementedException();
        }

        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> FilterBooks(FilterBookReqestDto filterBookReqestDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult PostBook(CreateBookDto createBookDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult PutBook(UpdateBookDto updateBookDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            throw new NotImplementedException();
        }



    }
}

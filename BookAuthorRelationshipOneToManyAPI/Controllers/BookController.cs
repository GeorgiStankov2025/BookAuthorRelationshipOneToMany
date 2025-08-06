using BookAuthorRelationshipOneToManyAPI.Entities;
using Microsoft.AspNetCore.HttpLogging;
using BookAuthorRelationshipOneToManyAPI.Exceptions;
using BookAuthorRelationshipOneToManyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BookAuthorRelationshipOneToManyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController(IBookServices bookServices, IExceptionList exception) : ControllerBase
    {

        [HttpPost("create-book")]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {

            var result = await bookServices.CreateBookService(book);

            if (result.GetType() != book.GetType())
            {

                return BadRequest(result);

            }

            return Ok(result);

        }

        [HttpGet("get-AllBooks")]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {

            var result = await bookServices.GetAllBooksService();

            return Ok(result);

        }

        [HttpGet("get-book-By-Name")]
        public async Task<ActionResult<Book>> GetBookByName(Guid Id)
        {

            var result = await bookServices.GetBookByNameService(Id);

            if (result.GetType() == exception.BookNotFound().GetType())
            {

                return NotFound(result);

            }

            return Ok(result);

        }

        [HttpDelete("delete-Book")]

        public async Task<ActionResult<Book>> RemoveBook(Guid Id)
        {

            var result= await bookServices.RemoveBookService(Id);

            if(result.GetType()==exception.BookNotFound().GetType())
            {

                return NotFound(result);
               
            }

            return Ok(result);

        }

    }
}

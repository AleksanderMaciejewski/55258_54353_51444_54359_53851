using Bookstore.BusinessLogic;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bookstore.Services.ApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookApiController : ControllerBase
    {
        private readonly IBookBll _bookBll;

        public BookApiController(IBookBll bookBll)
        {
            _bookBll = bookBll;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddBookAsync([FromBody] BookModel book, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool result = await _bookBll.AddBookAsync(book, ct);
            return result ? Ok(result) : StatusCode(500, "A problem happened while handling your request.");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<bool>> DeleteBookAsync(int id, CancellationToken ct)
        {
            bool result = await _bookBll.DeleteBookAsync(id, ct);
            return result ? Ok(result) : NotFound();
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult<bool>> UpdateBookAsync(int id, [FromBody] BookModel book, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool result = await _bookBll.UpdateBookAsync(id, book, ct);
            return result ? Ok(result) : StatusCode(500, "A problem happened while handling your request.");
        }

        [HttpGet("GetBook/{id}")]
        public async Task<ActionResult<BookModel>> GetBookByIdAsync(int id, CancellationToken ct)
        {
            var book = await _bookBll.GetBookByIdAsync(id, ct);
            return book != null ? Ok(book) : NotFound();
        }

        [HttpGet("GetAllBooks")]
        public async Task<ActionResult<List<BookModel>>> GetAllBooksAsync(CancellationToken ct)
        {
            var books = await _bookBll.GetAllBooksAsync(ct);
            return Ok(books);
        }
    }
}

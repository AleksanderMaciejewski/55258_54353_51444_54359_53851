using Bookstore.BusinessLogic;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Services.ApiControllers
{
    [ApiController]
    [Route("api/Book")]
    public class BookApiController : ControllerBase
    {
        private readonly IBookBll _bookBll;

        public BookApiController(IBookBll bookBll)
        {
            _bookBll = bookBll;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookBll.AddBookAsync(book, ct);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> DeleteBookAsync(int id, CancellationToken ct)
        {
            return await _bookBll.DeleteBookAsync(id, ct);
        }

        [HttpPut("Update")]
        public async Task<ActionResult<bool>> UpdateBookAsync(int id, BookModel book, CancellationToken ct)
        {
            return Ok(await _bookBll.UpdateBookAsync(id, book, ct));
        }

        [HttpGet("GetBook")]
        public async Task<BookModel> GetBookByIdAsync(int id, CancellationToken ct)
        {
            return await _bookBll.GetBookByIdAsync(id, ct);
        }

    }
}

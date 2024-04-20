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
        public async Task<bool> DeleteBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookBll.DeleteBookAsync(book, ct);
        }

        [HttpPut("Update")]
        public async Task<bool> UpdateBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookBll.UpdateBookAsync(book, ct);
        }

        [HttpGet("GetBooks")]
        public async Task<List<BookModel>> GetBooksAsync(CancellationToken ct)
        {
            return await _bookBll.GetBooksAsync(ct);
        }

    }
}

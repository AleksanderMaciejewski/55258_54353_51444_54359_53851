using Bookstore.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    // Controller class for handling book-related HTTP requests
    public class BookController : Controller 
    {
        private readonly IBookBll _bookBll;

        public BookController(IBookBll bookBll)
        {
            _bookBll = bookBll;   
        }

        public async Task<IActionResult> Home(CancellationToken ct)
        {
            var books = await _bookBll.GetBooksAsync(ct);
            return View(books);
        }

    }
}

using Bookstore.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    // Controller class for handling ordered book-related HTTP requests
    public class OrderedBookController : Controller
    {
        private readonly IOrderedBookBll _orderedBookBll;
        public OrderedBookController(IOrderedBookBll orderedBookBll)
        {
            _orderedBookBll = orderedBookBll;
        }

        public async Task<IActionResult> Home(CancellationToken ct)
        {
            var model = await _orderedBookBll.GetAllAsync(ct);
            return View(model);
        }

    }
}

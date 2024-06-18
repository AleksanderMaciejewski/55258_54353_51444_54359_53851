using Bookstore.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    // Controller class for handling sold book-related HTTP requests
    public class SoldBookController : Controller
    {
        private readonly ISoldBookBll _soldBookBll;
        public SoldBookController(ISoldBookBll soldBookBll)
        {
            _soldBookBll = soldBookBll;
        }

        public async Task<IActionResult> Home(CancellationToken ct)
        {
            var model = await _soldBookBll.GetAllAsync(ct);
            return View(model);
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class SoldBookController : Controller
    {

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }

    }
}

using Bookstore.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    // Controller class for handling warehouse-related HTTP requests
    public class WarehouseController : Controller
    {
        private readonly IWarehouseBll _warehouseBll;

        public WarehouseController(IWarehouseBll warehouseBll)
        {
            _warehouseBll = warehouseBll;
        }

        public async Task<IActionResult> Home(CancellationToken ct)
        {
            var model = await _warehouseBll.GetAllAsync(ct);
            return View(model);
        }

    }
}

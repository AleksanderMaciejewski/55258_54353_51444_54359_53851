using Bookstore.BusinessLogic;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Services.ApiControllers
{
    [ApiController]
    [Route("api/Warehouse")]
    public class WarehouseApiController : ControllerBase
    {
        private readonly IWarehouseBll _warehouseBll;

        public WarehouseApiController(IWarehouseBll warehouseBll)
        {
            _warehouseBll = warehouseBll;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<BookSummaryModel>>> GetAllAsync(CancellationToken ct)
        {
            return await _warehouseBll.GetAllAsync(ct);
        }

    }
}

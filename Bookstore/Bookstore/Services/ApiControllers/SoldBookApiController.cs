using Bookstore.BusinessLogic;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Services.ApiControllers
{
    [ApiController]
    [Route("api/SoldBook")]
    public class SoldBookApiController : ControllerBase
    {
        private readonly ISoldBookBll _soldBookBll;

        public SoldBookApiController(ISoldBookBll soldBookBll)
        {
            _soldBookBll = soldBookBll;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddSoldBookAsync(SoldBookModel soldBook, CancellationToken ct)
        {
            return await _soldBookBll.AddSoldBookAsync(soldBook, ct);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<SoldBookModel>>> GetAllAsync(CancellationToken ct)
        {
            return await _soldBookBll.GetAllAsync(ct);
        }

    }
}

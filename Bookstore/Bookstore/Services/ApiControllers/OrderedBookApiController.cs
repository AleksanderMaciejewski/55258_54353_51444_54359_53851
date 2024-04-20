using Bookstore.BusinessLogic;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Services.ApiControllers
{
    [ApiController]
    [Route("api/OrderedBook")]
    public class OrderedBookApiController : ControllerBase
    {
        private readonly IOrderedBookBll _orderedBookBll;

        public OrderedBookApiController(IOrderedBookBll orderedBookBll)
        {
            _orderedBookBll = orderedBookBll;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddOrderedBookAsync(OrderedBookModel orderedBook, CancellationToken ct)
        {
            return await _orderedBookBll.AddOrderedBookAsync(orderedBook, ct);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<OrderedBookModel>>> GetAllAsync(CancellationToken ct)
        {
            return await _orderedBookBll.GetAllAsync(ct);
        }

    }
}

using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface IOrderedBookBll
    {
        Task<bool> AddOrderedBookAsync(OrderedBookModel orderedBookModel, CancellationToken ct);
        Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct);
    }
}

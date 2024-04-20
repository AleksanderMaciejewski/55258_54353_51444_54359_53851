using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public interface IOrderedBookDal
    {
        Task<bool> AddOrderedBookAsync(OrderedBookModel orderedBookModel, CancellationToken ct);
        Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct);
    }
}

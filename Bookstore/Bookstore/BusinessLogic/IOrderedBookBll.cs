using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface IOrderedBookBll
    {
        Task<bool> AddOrderedBookAsync(int book, int client, CancellationToken ct);
        Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct);
    }
}

using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface ISoldBookBll
    {
        Task<bool> AddSoldBookAsync(int bookId, int clientId, CancellationToken ct);
        Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct);
    }
}

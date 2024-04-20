using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface IWarehouseBll
    {
        Task<List<BookSummaryModel>> GetAllAsync(CancellationToken ct);

    }
}

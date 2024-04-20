using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface ISoldBookBll
    {
        Task<bool> AddSoldBookAsync(SoldBookModel soldBook, CancellationToken ct);
        Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct);
    }
}

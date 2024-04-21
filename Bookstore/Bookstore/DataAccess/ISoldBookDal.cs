using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public interface ISoldBookDal
    {
        Task<bool> AddSoldBookAsync(SoldBookModel soldBook, CancellationToken ct);
        Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct);

    }
}

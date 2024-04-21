using Bookstore.DataAccess;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.BusinessLogic
{
    public class SoldBookBll : ISoldBookBll
    {
        private readonly ISoldBookDal _soldBookDal;
        public SoldBookBll(ISoldBookDal soldBookDal)
        {
            _soldBookDal = soldBookDal;
        }

        public async Task<bool> AddSoldBookAsync(SoldBookModel soldBook, CancellationToken ct)
        {
            return await _soldBookDal.AddSoldBookAsync(soldBook, ct);
        }

        public async Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct)
        {
            return await _soldBookDal.GetAllAsync(ct);
        }

    }
}

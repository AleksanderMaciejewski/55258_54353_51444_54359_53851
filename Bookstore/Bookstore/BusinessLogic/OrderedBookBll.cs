using Bookstore.DataAccess;
using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public class OrderedBookBll : IOrderedBookBll
    {
        private readonly IOrderedBookDal _orderedBookDal;

        public OrderedBookBll(IOrderedBookDal orderedBookDal)
        {
            _orderedBookDal = orderedBookDal;
        }

        public async Task<bool> AddOrderedBookAsync(OrderedBookModel orderedBook, CancellationToken ct)
        {
            return await _orderedBookDal.AddOrderedBookAsync(orderedBook, ct);
        }

        public async Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct)
        {
            return await _orderedBookDal.GetAllAsync(ct);
        }
    }
}

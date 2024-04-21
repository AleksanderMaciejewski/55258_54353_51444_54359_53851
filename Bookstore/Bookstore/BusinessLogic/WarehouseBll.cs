using Bookstore.DataAccess;
using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public class WarehouseBll : IWarehouseBll
    {
        private readonly IBookDal _bookDal;

        public WarehouseBll(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public async Task<List<BookSummaryModel>> GetAllAsync(CancellationToken ct)
        {
            var books = await _bookDal.GetBooksAsync(ct);
            var result = books
                .GroupBy(b => new { b.Title, b.Author })  
                .Select(g => new BookSummaryModel
                {
                    NumberOfBooks = g.Count(), 
                    Title = g.Key.Title,        
                    Author = g.Key.Author       
                })
                .ToList();

            return result;
        }

    }
}

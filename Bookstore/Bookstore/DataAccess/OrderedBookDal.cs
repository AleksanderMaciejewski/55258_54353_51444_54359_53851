using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public class OrderedBookDal : IOrderedBookDal
    {
        public async Task<bool> AddOrderedBookAsync(OrderedBookModel soldBook, CancellationToken ct)
        {
            return true;
        }

        public async Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct)
        {
            return new List<OrderedBookModel>()
            {
                new OrderedBookModel()
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Book = new BookModel()
                    {
                        Id = 1,
                        Title = "Test",
                        Author = "Test"
                    }
                }
            };
        }

    }
}

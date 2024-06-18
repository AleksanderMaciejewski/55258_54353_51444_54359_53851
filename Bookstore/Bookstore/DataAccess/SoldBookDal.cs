using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public class SoldBookDal : ISoldBookDal
    {
        public async Task<bool> AddSoldBookAsync(SoldBookModel soldBook, CancellationToken ct)
        {
            return true;
        }

        public async Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct)
        {
            return new List<SoldBookModel>()
            {
                new SoldBookModel()
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

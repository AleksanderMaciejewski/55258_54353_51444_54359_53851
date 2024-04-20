using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

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
                    BookId = 1,
                    SellingBookDate = new DateTime(2023, 1,1)
                }
            };
        }

    }
}

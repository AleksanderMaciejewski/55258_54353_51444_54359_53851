using Bookstore.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.DataAccess
{
    public class OrderedBookDal : IOrderedBookDal
    {
        private readonly ApplicationDbContext _context;

        public OrderedBookDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddOrderedBookAsync(OrderedBookModel orderedBookModel, CancellationToken ct)
        {
            _context.OrderedBooks.Add(orderedBookModel);
            return await _context.SaveChangesAsync(ct) > 0;
            // true if added successfully false if not
        }

        public async Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct)
        {
            return await _context.OrderedBooks.ToListAsync(ct);
        }

    }
}

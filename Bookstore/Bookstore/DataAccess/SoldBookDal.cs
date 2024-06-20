using Bookstore.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.DataAccess
{
    public class SoldBookDal : ISoldBookDal
    {
        private readonly ApplicationDbContext _context;

        public SoldBookDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddSoldBookAsync(SoldBookModel soldBook, CancellationToken ct)
        {
            _context.SoldBooks.Add(soldBook);
            return await _context.SaveChangesAsync(ct) > 0;
            // true if added successfully false if not
        }

        public async Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct)
        {
            return await _context.SoldBooks.ToListAsync(ct);
        }

    }
}

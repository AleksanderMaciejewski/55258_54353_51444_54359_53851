using Bookstore.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.DataAccess
{
    public class BookDal : IBookDal
    {
        private readonly ApplicationDbContext _context;

        public BookDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddBookAsync(BookModel book, CancellationToken ct)
        {
            _context.Books.Add(book);
            return await _context.SaveChangesAsync(ct) > 0;
            // true if added successfully false if not
        }

        public async Task<bool> DeleteBookAsync(int id, CancellationToken ct)
        {
            var book = await _context.Books.FindAsync(new object[] { id }, ct);
            if (book == null) return false;

            _context.Books.Remove(book);
            return await _context.SaveChangesAsync(ct) > 0;
        }

        public async Task<bool> UpdateBookAsync(int id, BookModel book, CancellationToken ct)
        {
            var existingBook = await _context.Books.FindAsync(new object[] { id }, ct);
            if (existingBook == null) return false;

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;

            _context.Books.Update(existingBook);
            return await _context.SaveChangesAsync(ct) > 0;
        }

        public async Task<BookModel> GetBookByIdAsync(int id, CancellationToken ct)
        {
            return await _context.Books.FindAsync(new object[] { id }, ct);
        }

        public async Task<List<BookModel>> GetBooksAsync(CancellationToken ct)
        {
            return await _context.Books.ToListAsync(ct);
        }
    }
}
using Bookstore.DataAccess;
using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public class BookBll : IBookBll
    {
        private readonly IBookDal _bookDal;

        public BookBll(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public async Task<bool> AddBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookDal.AddBookAsync(book, ct);
        }

        public async Task<bool> DeleteBookAsync(int id, CancellationToken ct)
        {
            return await _bookDal.DeleteBookAsync(id, ct);
        }

        public async Task<bool> UpdateBookAsync(int id, BookModel book, CancellationToken ct)
        {
            return await _bookDal.UpdateBookAsync(id, book, ct);
        }

        public async Task<List<BookModel>> GetBooksAsync(CancellationToken ct)
        {
            return await _bookDal.GetBooksAsync(ct);
        }

        public async Task<BookModel> GetBookByIdAsync(int id, CancellationToken ct)
        {
            return await _bookDal.GetBookByIdAsync(id, ct);
        }

    }
}

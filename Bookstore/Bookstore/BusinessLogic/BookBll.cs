using Bookstore.DataAccess;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<bool> DeleteBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookDal.DeleteBookAsync(book, ct);
        }

        public async Task<bool> UpdateBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookDal.UpdateBookAsync(book, ct);
        }

        public async Task<List<BookModel>> GetBooksAsync(string title, string author, CancellationToken ct)
        {
            return await _bookDal.GetBooksAsync(title, author, ct);
        }

    }
}

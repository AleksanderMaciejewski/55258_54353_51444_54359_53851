using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public interface IBookDal
    {
        Task<bool> AddBookAsync(BookModel book ,CancellationToken ct);
        Task<bool> DeleteBookAsync(BookModel book, CancellationToken ct);
        Task<bool> UpdateBookAsync(BookModel book, CancellationToken ct);
        Task<List<BookModel>> GetBooksAsync(CancellationToken ct);

    }
}

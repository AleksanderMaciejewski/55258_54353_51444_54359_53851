using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public interface IBookDal
    {
        Task<bool> AddBookAsync(BookModel book ,CancellationToken ct);
        Task<bool> DeleteBookAsync(int id, CancellationToken ct);
        Task<bool> UpdateBookAsync(int id, BookModel book, CancellationToken ct);
        Task<List<BookModel>> GetBooksAsync(CancellationToken ct);
        Task<BookModel> GetBookByIdAsync(int id, CancellationToken ct);

    }
}

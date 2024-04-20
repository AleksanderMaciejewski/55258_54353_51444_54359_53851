using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface IBookBll
    {
        Task<bool> AddBookAsync(BookModel book, CancellationToken ct);
        Task<bool> DeleteBookAsync(BookModel book, CancellationToken ct);
        Task<bool> UpdateBookAsync(BookModel book, CancellationToken ct);
        Task<List<BookModel>> GetBooksAsync(string title, string author, CancellationToken ct);

    }
}
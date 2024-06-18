// Namespace imports
using Bookstore.DataAccess; // Data access layer interfaces
using Bookstore.Models;     // Models used in the bookstore application

namespace Bookstore.BusinessLogic
{
    // Business logic class for handling book-related operations
    public class BookBll : IBookBll
    {
        // Private readonly field for the data access layer interface
        private readonly IBookDal _bookDal;

        // Constructor to initialize the data access layer dependency
        public BookBll(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        // Asynchronously adds a new book to the datastore
        public async Task<bool> AddBookAsync(BookModel book, CancellationToken ct)
        {
            return await _bookDal.AddBookAsync(book, ct);
        }

        // Asynchronously deletes a book from the datastore by its ID
        public async Task<bool> DeleteBookAsync(int id, CancellationToken ct)
        {
            return await _bookDal.DeleteBookAsync(id, ct);
        }

        // Asynchronously updates an existing book in the datastore by its ID
        public async Task<bool> UpdateBookAsync(int id, BookModel book, CancellationToken ct)
        {
            return await _bookDal.UpdateBookAsync(id, book, ct);
        }

        // Asynchronously retrieves a list of all books from the datastore
        public async Task<List<BookModel>> GetBooksAsync(CancellationToken ct)
        {
            return await _bookDal.GetBooksAsync(ct);
        }

        // Asynchronously retrieves a specific book by its ID from the datastore
        public async Task<BookModel> GetBookByIdAsync(int id, CancellationToken ct)
        {
            return await _bookDal.GetBookByIdAsync(id, ct);
        }
    }
}

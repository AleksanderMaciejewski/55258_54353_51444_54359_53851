// Namespace imports
using Bookstore.DataAccess; // Data access layer interfaces
using Bookstore.Models;     // Models used in the bookstore application

namespace Bookstore.BusinessLogic
{
    // Business logic class for handling warehouse-related operations
    public class WarehouseBll : IWarehouseBll
    {
        // Private readonly field for the data access layer interface
        private readonly IBookDal _bookDal;

        // Constructor to initialize the data access layer dependency
        public WarehouseBll(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        // Asynchronously retrieves a summary of all books from the datastore
        public async Task<List<BookSummaryModel>> GetAllAsync(CancellationToken ct)
        {
            // Retrieve all books from the data access layer
            var books = await _bookDal.GetBooksAsync(ct);
            // Group the books by title and author, and create a summary list
            var result = books
                .GroupBy(b => new { b.Title, b.Author })  // Group by book title and author
                .Select(g => new BookSummaryModel
                {
                    NumberOfBooks = g.Count(), // Count the number of books in each group
                    Title = g.Key.Title,       // Get the title from the group key
                    Author = g.Key.Author      // Get the author from the group key
                })
                .ToList();

            // Return the summary list
            return result;
        }
    }
}

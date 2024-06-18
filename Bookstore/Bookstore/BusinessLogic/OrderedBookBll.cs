// Namespace imports
using Bookstore.DataAccess; // Data access layer interfaces
using Bookstore.Models;     // Models used in the bookstore application
using System.Net;           // System network-related classes

namespace Bookstore.BusinessLogic
{
    // Business logic class for handling ordered book-related operations
    public class OrderedBookBll : IOrderedBookBll
    {
        // Private readonly fields for the data access layer and business logic layer interfaces
        private readonly IOrderedBookDal _orderedBookDal;
        private readonly IBookBll _bookBll;
        private readonly IClientBll _clientBll;

        // Constructor to initialize the data access layer and business logic layer dependencies
        public OrderedBookBll(IOrderedBookDal orderedBookDal, IBookBll bookBll, IClientBll clientBll)
        {
            _orderedBookDal = orderedBookDal;
            _bookBll = bookBll;
            _clientBll = clientBll;
        }

        // Asynchronously adds a new ordered book to the datastore
        public async Task<bool> AddOrderedBookAsync(int bookId, int clientId, CancellationToken ct)
        {
            // Retrieve the book by its ID
            var book = await _bookBll.GetBookByIdAsync(bookId, ct);
            // Retrieve the client by their ID
            var client = await _clientBll.GetClientByIdAsync(clientId, ct);

            // Check if both book and client exist
            if (book is not null && client is not null)
            {
                // Create a new OrderedBookModel instance
                var model = new OrderedBookModel()
                {
                    Book = book,
                    Date = DateTime.Now,
                    Client = client
                };
                // Add the ordered book to the datastore
                return await _orderedBookDal.AddOrderedBookAsync(model, ct);
            }
            // Return false if either book or client is not found
            return false;
        }

        // Asynchronously retrieves a list of all ordered books from the datastore
        public async Task<List<OrderedBookModel>> GetAllAsync(CancellationToken ct)
        {
            return await _orderedBookDal.GetAllAsync(ct);
        }
    }
}

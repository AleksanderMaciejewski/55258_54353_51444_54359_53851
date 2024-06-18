// Namespace imports
using Bookstore.DataAccess; // Data access layer interfaces
using Bookstore.Models;     // Models used in the bookstore application

namespace Bookstore.BusinessLogic
{
    // Business logic class for handling sold book-related operations
    public class SoldBookBll : ISoldBookBll
    {
        // Private readonly fields for the data access layer and business logic layer interfaces
        private readonly ISoldBookDal _soldBookDal;
        private readonly IBookBll _bookBll;
        private readonly IClientBll _clientBll;

        // Constructor to initialize the data access layer and business logic layer dependencies
        public SoldBookBll(ISoldBookDal soldBookDal, IBookBll bookBll, IClientBll clientBll)
        {
            _soldBookDal = soldBookDal;
            _bookBll = bookBll;
            _clientBll = clientBll;
        }

        // Asynchronously adds a new sold book to the datastore
        public async Task<bool> AddSoldBookAsync(int bookId, int clientId, CancellationToken ct)
        {
            // Retrieve the book by its ID
            var book = await _bookBll.GetBookByIdAsync(bookId, ct);
            // Retrieve the client by their ID
            var client = await _clientBll.GetClientByIdAsync(clientId, ct);

            // Check if both book and client exist
            if (book is not null && client is not null)
            {
                // Create a new SoldBookModel instance
                var model = new SoldBookModel()
                {
                    Book = book,
                    Date = DateTime.Now,
                    Client = client
                };
                // Add the sold book to the datastore
                return await _soldBookDal.AddSoldBookAsync(model, ct);
            }
            // Return false if either book or client is not found
            return false;
        }

        // Asynchronously retrieves a list of all sold books from the datastore
        public async Task<List<SoldBookModel>> GetAllAsync(CancellationToken ct)
        {
            return await _soldBookDal.GetAllAsync(ct);
        }
    }
}

using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public class BookDal: IBookDal
    {

        public async Task<bool> AddBookAsync(BookModel book, CancellationToken ct)
        {
            return true; 
            // true if added successfully false if not
        }

        public async Task<bool> DeleteBookAsync(int id, CancellationToken ct)
        {
            return true;
            // true if deleted successfully false if not
        }

        public async Task<bool> UpdateBookAsync(int id, BookModel book, CancellationToken ct)
        {
            return true;
            // true if updated successfully false if not
        }

        public async Task<List<BookModel>> GetBooksAsync(CancellationToken ct)
        {
            return new List<BookModel>()
            {
                new BookModel()
                {
                    Id = 1,
                    Title = "title",
                    Author = "author"
                },
                new BookModel()
                {
                    Id = 2,
                    Title = "title2",
                    Author = "author2"
                }
            };
        }

        public async Task<BookModel> GetBookByIdAsync(int id, CancellationToken ct)
        {
            return new BookModel()
            {
                Id = 1,
                Title = "title",
                Author = "author"
            };
        }

    }
}

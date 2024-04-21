using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class BookBllTestData
    {
        public CancellationToken _cancellationToken;

        public BookModel _correctBookModel;

        public BookModel _incorrectBookModel;

        public BookBllTestData()
        {
            _cancellationToken = new CancellationToken();

            _correctBookModel = new BookModel
            {
                Id = 1,
                Title = "TestTitle",
                Author = "TestAuthor"
            };

            _incorrectBookModel = new BookModel
            {
                Id = 0
            };
        }
    }
}

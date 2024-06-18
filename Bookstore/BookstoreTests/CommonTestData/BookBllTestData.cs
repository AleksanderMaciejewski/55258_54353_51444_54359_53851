using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class BookBllTestData
    {
        public CancellationToken _cancellationToken;

        public int _correctBookId;

        public int _incorrectBookId;

        public BookModel _correctBookModel;

        public BookModel _incorrectBookModel;


        public BookBllTestData()
        {
            _cancellationToken = new CancellationToken();

            _correctBookId = 1;

            _incorrectBookId = -1;

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

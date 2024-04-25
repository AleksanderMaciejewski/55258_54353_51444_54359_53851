using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class OrderedBookBllTestData
    {
        public CancellationToken _cancellationToken;

        public OrderedBookModel _correctOrderedBookModel;

        public OrderedBookModel _incorrectOrderedBookModel;

        public OrderedBookBllTestData()
        {
            _cancellationToken = new CancellationToken();

            _correctOrderedBookModel = new OrderedBookModel
            {
                Id = 1
            };

            _incorrectOrderedBookModel = new OrderedBookModel
            {
                Id = 0
            };
        }
    }
}

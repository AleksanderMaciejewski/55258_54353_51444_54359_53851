using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class SoldBookBllTestData
    {
        public CancellationToken _cancellationToken;

        public SoldBookModel _correctSoldBookModel;

        public SoldBookModel _incorrectSoldBookModel;

        public SoldBookBllTestData()
        {
            _cancellationToken = new CancellationToken();

            _correctSoldBookModel = new SoldBookModel
            {
                BookId = 1,
                SellingBookDate = DateTime.Now
            };

            _incorrectSoldBookModel = new SoldBookModel
            {
                BookId = 0,
                SellingBookDate = DateTime.MinValue
            };
        }
    }
}

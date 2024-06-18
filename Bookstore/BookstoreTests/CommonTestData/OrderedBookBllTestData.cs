using Bookstore.BusinessLogic;
using Bookstore.DataAccess;
using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class OrderedBookBllTestData
    {
        public CancellationToken _cancellationToken;

        public int _correctBookId = 1;

        public int _incorrectBookId = -1;

        public int _correctClientId = 1;

        public int _incorrectClientId = -1;

        public OrderedBookModel _correctOrderedBookModel;

        public OrderedBookModel _incorrectOrderedBookModel;

        public BookBll _bookBll;

        public ClientBll _clientBll;

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

            _bookBll = new BookBll(new BookDal());

            _clientBll = new ClientBll(new ClientDal());
        }
    }
}

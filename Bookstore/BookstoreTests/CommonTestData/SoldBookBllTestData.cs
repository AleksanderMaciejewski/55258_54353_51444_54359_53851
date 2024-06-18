using Bookstore.BusinessLogic;
using Bookstore.DataAccess;
using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class SoldBookBllTestData
    {
        public CancellationToken _cancellationToken;

        public SoldBookModel _correctSoldBookModel;

        public SoldBookModel _incorrectSoldBookModel;

        public int _correctBookId = 1;

        public int _incorrectBookId = -1;       
        
        public int _correctClientId = 1;

        public int _incorrectClientId = -1;

        public BookBll _bookBll;

        public ClientBll _clientBll;

        public SoldBookBllTestData()
        {
            _cancellationToken = new CancellationToken();

            _correctSoldBookModel = new SoldBookModel
            {
                Id = 1,
                Date = DateTime.Now
            };

            _incorrectSoldBookModel = new SoldBookModel
            {
                Id = 0,
                Date = DateTime.MinValue
            };

            _bookBll = new BookBll(new BookDal());

            _clientBll = new ClientBll(new ClientDal());
        }
    }
}

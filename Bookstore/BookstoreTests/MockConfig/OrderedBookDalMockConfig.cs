using Bookstore.DataAccess;
using Bookstore.Models;
using BookstoreTests.CommonTestData;
using NSubstitute;

namespace BookstoreTests.MockConfig
{
    public class OrderedBookDalMockConfig : OrderedBookBllTestData
    {
        public IOrderedBookDal _mockedOrderedBookDal;

        public OrderedBookDalMockConfig()
        {
            var mockedOrderedBookDal = Substitute.For<IOrderedBookDal>();

            mockedOrderedBookDal.AddOrderedBookAsync(_correctOrderedBookModel, _cancellationToken).Returns(true);
            mockedOrderedBookDal.GetAllAsync(_cancellationToken).Returns(new List<OrderedBookModel>
            {
                new OrderedBookModel{ Id=1},
                new OrderedBookModel{ Id=2},
                new OrderedBookModel{ Id=3}
            });

            mockedOrderedBookDal.AddOrderedBookAsync(_incorrectOrderedBookModel, _cancellationToken).Returns(false);

            _mockedOrderedBookDal = mockedOrderedBookDal;
        }
    }
}

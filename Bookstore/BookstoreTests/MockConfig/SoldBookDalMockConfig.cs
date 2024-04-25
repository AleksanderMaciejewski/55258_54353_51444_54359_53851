using Bookstore.DataAccess;
using Bookstore.Models;
using BookstoreTests.CommonTestData;
using NSubstitute;

namespace BookstoreTests.MockConfig
{
    public class SoldBookDalMockConfig : SoldBookBllTestData
    {
        public ISoldBookDal _mockedSoldBookDal;

        public SoldBookDalMockConfig()
        {
            var mockedSoldBookDal = Substitute.For<ISoldBookDal>();

            mockedSoldBookDal.AddSoldBookAsync(_correctSoldBookModel, _cancellationToken).Returns(true);
            mockedSoldBookDal.GetAllAsync(_cancellationToken).Returns(new List<SoldBookModel>
            {
                new SoldBookModel{ BookId = 1, SellingBookDate = DateTime.Now},
                new SoldBookModel{ BookId = 2, SellingBookDate = DateTime.Now},
                new SoldBookModel{ BookId = 3, SellingBookDate = DateTime.Now},
            });

            mockedSoldBookDal.AddSoldBookAsync(_incorrectSoldBookModel, _cancellationToken).Returns(false);

            _mockedSoldBookDal = mockedSoldBookDal;
        }
    }
}

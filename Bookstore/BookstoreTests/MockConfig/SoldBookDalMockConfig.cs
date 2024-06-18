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
                new SoldBookModel{ Id = 1, Date = DateTime.Now},
                new SoldBookModel{ Id = 2, Date = DateTime.Now},
                new SoldBookModel{ Id = 3, Date = DateTime.Now},
            });

            mockedSoldBookDal.AddSoldBookAsync(_incorrectSoldBookModel, _cancellationToken).Returns(false);

            _mockedSoldBookDal = mockedSoldBookDal;
        }
    }
}

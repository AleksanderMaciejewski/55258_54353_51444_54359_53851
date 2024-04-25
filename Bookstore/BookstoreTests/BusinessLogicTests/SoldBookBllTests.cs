using Bookstore.BusinessLogic;
using BookstoreTests.MockConfig;

namespace BookstoreTests.BusinessLogicTests
{
    [TestClass]
    public class SoldBookBllTests : SoldBookDalMockConfig
    {
        private SoldBookBll _soldBookBll;

        public SoldBookBllTests()
        {
            _soldBookBll = new SoldBookBll(_mockedSoldBookDal);
        }

        [TestMethod]
        public void AddSoldBookAsync_CorrectlyAdded()
        {
            var result = _soldBookBll.AddSoldBookAsync(_correctSoldBookModel, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void AddSoldBookAsync_IncorrectlyAdded()
        {
            var result = _soldBookBll.AddSoldBookAsync(_incorrectSoldBookModel, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void GetAllAsync()
        {
            var result = _soldBookBll.GetAllAsync(_cancellationToken);

            foreach (var item in result.Result) 
            {
                Assert.IsNotNull(item);
                Assert.IsNotNull(item.BookId);
                Assert.IsNotNull(item.SellingBookDate);
            }
        }
    }
}

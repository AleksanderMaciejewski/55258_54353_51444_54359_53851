using Bookstore.BusinessLogic;
using BookstoreTests.MockConfig;

namespace BookstoreTests.BusinessLogicTests
{
    [TestClass]
    public class OrderedBookBllTests : OrderedBookDalMockConfig
    {
        private OrderedBookBll _orderedBookBll;

        public OrderedBookBllTests()
        {
            _orderedBookBll = new OrderedBookBll(_mockedOrderedBookDal, _bookBll, _clientBll);
        }

        [TestMethod]
        public void AddOrderedBookAsync_IncorrectlyAdded()
        {
            var result = _orderedBookBll.AddOrderedBookAsync(_incorrectBookId, _incorrectClientId, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void GetAllAsync()
        {
            var result = _orderedBookBll.GetAllAsync(_cancellationToken);

            foreach (var item in result.Result)
            {
                Assert.IsNotNull(item);
                Assert.IsNotNull(item.Id);
            }
        }
    }
}

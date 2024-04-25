using Bookstore.BusinessLogic;
using BookstoreTests.MockConfig;

namespace BookstoreTests.BusinessLogicTests
{
    [TestClass]
    public class WarehouseBllTests: BookDalMockConfig
    {
        private WarehouseBll _warehouseBll;

        public WarehouseBllTests()
        {
            _warehouseBll = new WarehouseBll(_mockedBookDal);
        }

        [TestMethod]
        public void GetAllAsync()
        {
            var result = _warehouseBll.GetAllAsync(_cancellationToken);

            foreach (var item in result.Result)
            {
                Assert.IsNotNull(item);
                Assert.IsNotNull(item.NumberOfBooks);
                Assert.IsFalse(string.IsNullOrEmpty(item.Title));
                Assert.IsFalse(string.IsNullOrEmpty(item.Author));             
            }
        }
    }
}

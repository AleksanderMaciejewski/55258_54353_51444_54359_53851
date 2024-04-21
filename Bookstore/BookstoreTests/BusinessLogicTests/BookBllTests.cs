using Bookstore.BusinessLogic;
using BookstoreTests.CommonTestData;

namespace BookstoreTests.BusinessLogic
{
    [TestClass]
    public class BookBllTests : BookDalMockConfig
    {
        private BookBll _bookBll;

        public BookBllTests()
        {
            _bookBll = new BookBll(_mockedBookDal);
        }

        [TestMethod]
        public void AddBookAsync_CorrectlyAdded()
        {
            var result = _bookBll.AddBookAsync(_correctBookModel, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void AddBookAsync_IncorrectlyAdded()
        {
            var result = _bookBll.AddBookAsync(_incorrectBookModel, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void DeleteBookAsync_CorrectlyDeleted()
        {
            var result = _bookBll.DeleteBookAsync(_correctBookModel, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void DeleteBookAsync_IncorrectlyDeleted()
        {
            var result = _bookBll.DeleteBookAsync(_incorrectBookModel, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void UpdateBookAsync_CorrectlyUpdated()
        {
            var result = _bookBll.UpdateBookAsync(_correctBookModel, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void UpdateBookAsync_IncorrectlyUpdated()
        {
            var result = _bookBll.UpdateBookAsync(_incorrectBookModel, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void GetBooksAsync()
        {
            var result = _bookBll.GetBooksAsync(_cancellationToken);

            foreach (var book in result.Result)
            {
                Assert.IsNotNull(book);
                Assert.IsNotNull(book.Id);
                Assert.IsFalse(string.IsNullOrEmpty(book.Author));
                Assert.IsFalse(string.IsNullOrEmpty(book.Title));
            }
        }
    }
}

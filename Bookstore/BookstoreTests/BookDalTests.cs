using Bookstore.DataAccess;
using Bookstore.Models;
using Microsoft.CodeAnalysis.CSharp;

namespace Bookstore.Tests
{
    [TestClass]
    public class BookDalTests
    {
        private BookDal _bookDal;

        private BookModel _bookModel;

        private CancellationToken _cancellationToken;

        public BookDalTests()
        {
            _bookDal = new BookDal();

            _bookModel = new BookModel
            {
                Id = 1,
                Title = "TestTitle",
                Author = "TestAuthor"
            };
        }

        [TestMethod]
        public void AddBookAsync()
        {
            var result = _bookDal.AddBookAsync(_bookModel, _cancellationToken);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Result, true);
        }

        [TestMethod]
        public void DeleteBookAsync()
        {
            var result = _bookDal.DeleteBookAsync(_bookModel, _cancellationToken);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Result, true);
        }

        [TestMethod]
        public void UpdateBookAsync()
        {
            var result = _bookDal.UpdateBookAsync(_bookModel, _cancellationToken);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Result, true);
        }

        [TestMethod]
        public void GetBooksAsync()
        {
            var results = _bookDal.GetBooksAsync(_cancellationToken);

            foreach(var result in results.Result)
            {
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.Id);
                Assert.IsTrue(!string.IsNullOrEmpty(result.Title));
                Assert.IsTrue(!string.IsNullOrEmpty(result.Author));
            }
        }
    }
}

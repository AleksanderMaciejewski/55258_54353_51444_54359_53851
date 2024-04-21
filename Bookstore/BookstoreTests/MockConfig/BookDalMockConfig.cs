using Bookstore.DataAccess;
using Bookstore.Models;
using BookstoreTests.CommonTestData;
using NSubstitute;

namespace BookstoreTests.MockConfig
{
    public class BookDalMockConfig : BookBllTestData
    {
        public IBookDal _mockedBookDal;

        public BookDalMockConfig()
        {
            var mockedBookDal = Substitute.For<IBookDal>();

            mockedBookDal.AddBookAsync(_correctBookModel, _cancellationToken).Returns(true);
            mockedBookDal.DeleteBookAsync(_correctBookModel, _cancellationToken).Returns(true);
            mockedBookDal.UpdateBookAsync(_correctBookModel, _cancellationToken).Returns(true);
            mockedBookDal.GetBooksAsync(_cancellationToken).Returns(new List<BookModel>{
                new BookModel{ Id = 1, Author = "Author1", Title = "Title1"},
                new BookModel{ Id = 2, Author = "Author2", Title = "Title2"},
                new BookModel{ Id = 3, Author = "Author3", Title = "Title3"}
                });

            mockedBookDal.AddBookAsync(_incorrectBookModel, _cancellationToken).Returns(false);
            mockedBookDal.DeleteBookAsync(_incorrectBookModel, _cancellationToken).Returns(false);
            mockedBookDal.UpdateBookAsync(_incorrectBookModel, _cancellationToken).Returns(false);

            _mockedBookDal = mockedBookDal;
        }
    }
}

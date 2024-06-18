using Bookstore.BusinessLogic;
using BookstoreTests.MockConfig;

namespace BookstoreTests.BusinessLogicTests
{
    [TestClass]
    public class ClientBllTests : ClientDalMockConfig
    {
        private ClientBll _clientBll;

        public ClientBllTests()
        {
            _clientBll = new ClientBll(_mockedClientDal);
        }

        [TestMethod]
        public void AddClientAsync_CorrectlyAdded()
        {
            var result = _clientBll.AddClientAsync(_correctClientModel, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void AddClientAsync_IncorrectlyAdded()
        {
            var result = _clientBll.AddClientAsync(_incorrectClientModel, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void DeleteClientAsync_CorrectlyDeleted()
        {
            var result =  _clientBll.DeleteClientAsync(_correctClientId, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void DeleteClientAsync_IncorrectlyDeleted()
        {
            var result = _clientBll.DeleteClientAsync(_incorrectClientId, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void UpdateClientAsync_CorrectlyUpdated()
        {
            var result = _clientBll.UpdateClientAsync(_correctClientId, _correctClientModel, _cancellationToken);

            Assert.AreEqual(true, result.Result);
        }

        [TestMethod]
        public void UpdateClientAsync_IncorrectlyUpdated()
        {
            var result = _clientBll.UpdateClientAsync(_incorrectClientId, _incorrectClientModel, _cancellationToken);

            Assert.AreEqual(false, result.Result);
        }

        [TestMethod]
        public void GetClientsAsync()
        {
            var result = _clientBll.GetClientsAsync(_cancellationToken);

            foreach (var client in result.Result)
            {
                Assert.IsNotNull(client);
                Assert.IsNotNull(client.Id);
                Assert.IsFalse(string.IsNullOrEmpty(client.Name));
            }
        }
    }
}

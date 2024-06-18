using Bookstore.Models;

namespace BookstoreTests.CommonTestData
{
    public class ClientBllTestData
    {
        public CancellationToken _cancellationToken;

        public int _correctClientId = 1;

        public int _incorrectClientId = -1;

        public ClientModel _correctClientModel;

        public ClientModel _incorrectClientModel;

        public ClientBllTestData()
        {
            _cancellationToken = new CancellationToken();

            _correctClientModel = new ClientModel
            {
                Id = 1,
                Name = "Test"
            };

            _incorrectClientModel = new ClientModel
            {
                Id = 0
            };
        }
    }
}

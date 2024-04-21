using Bookstore.DataAccess;
using Bookstore.Models;
using BookstoreTests.CommonTestData;
using NSubstitute;

namespace BookstoreTests.MockConfig
{
    public class ClientDalMockConfig : ClientBllTestData
    {
        public IClientDal _mockedClientDal;

        public ClientDalMockConfig()
        {
            var mockedClientDal = Substitute.For<IClientDal>();

            mockedClientDal.AddClientAsync(_correctClientModel, _cancellationToken).Returns(true);
            mockedClientDal.DeleteClientAsync(_correctClientModel, _cancellationToken).Returns(true);
            mockedClientDal.UpdateClientAsync(_correctClientModel, _cancellationToken).Returns(true);
            mockedClientDal.GetClientsAsync(_cancellationToken).Returns(new List<ClientModel> {
                new ClientModel{ Id=1, Name="Client1"},
                new ClientModel{ Id=2, Name="Client2"},
                new ClientModel{ Id=3, Name="Client3"}
                });

            mockedClientDal.AddClientAsync(_incorrectClientModel, _cancellationToken).Returns(false);
            mockedClientDal.DeleteClientAsync(_incorrectClientModel, _cancellationToken).Returns(false);
            mockedClientDal.UpdateClientAsync(_incorrectClientModel,_cancellationToken).Returns(false);

            _mockedClientDal = mockedClientDal;
        }
    }
}

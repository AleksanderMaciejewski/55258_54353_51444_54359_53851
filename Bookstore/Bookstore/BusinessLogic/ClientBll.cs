using Bookstore.DataAccess;
using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public class ClientBll : IClientBll
    {
        private readonly IClientDal _clientDal;

        public ClientBll(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }

        public async Task<bool> AddClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientDal.AddClientAsync(client, ct);
        }

        public async Task<bool> DeleteClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientDal.DeleteClientAsync(client, ct);
        }

        public async Task<bool> UpdateClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientDal.UpdateClientAsync(client, ct);
        }

        public async Task<List<ClientModel>> GetClientsAsync(CancellationToken ct)
        {
            return await _clientDal.GetClientsAsync(ct);
        }

    }
}

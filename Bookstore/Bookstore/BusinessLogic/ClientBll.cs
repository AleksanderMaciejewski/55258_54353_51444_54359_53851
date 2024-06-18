// Namespace imports
using Bookstore.DataAccess; // Data access layer interfaces
using Bookstore.Models;     // Models used in the bookstore application

namespace Bookstore.BusinessLogic
{
    // Business logic class for handling client-related operations
    public class ClientBll : IClientBll
    {
        // Private readonly field for the data access layer interface
        private readonly IClientDal _clientDal;

        // Constructor to initialize the data access layer dependency
        public ClientBll(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }

        // Asynchronously adds a new client to the datastore
        public async Task<bool> AddClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientDal.AddClientAsync(client, ct);
        }

        // Asynchronously deletes a client from the datastore by its ID
        public async Task<bool> DeleteClientAsync(int id, CancellationToken ct)
        {
            return await _clientDal.DeleteClientAsync(id, ct);
        }

        // Asynchronously updates an existing client in the datastore by its ID
        public async Task<bool> UpdateClientAsync(int id, ClientModel client, CancellationToken ct)
        {
            return await _clientDal.UpdateClientAsync(id, client, ct);
        }

        // Asynchronously retrieves a list of all clients from the datastore
        public async Task<List<ClientModel>> GetClientsAsync(CancellationToken ct)
        {
            return await _clientDal.GetClientsAsync(ct);
        }

        // Asynchronously retrieves a specific client by its ID from the datastore
        public async Task<ClientModel> GetClientByIdAsync(int id, CancellationToken ct)
        {
            return await _clientDal.GetClientByIdAsync(id, ct);
        }
    }
}

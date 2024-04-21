using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public class ClientDal : IClientDal
    {
        public async Task<bool> AddClientAsync(ClientModel client, CancellationToken ct)
        {
            return true;
            // true if added successfully false if not
        }

        public async Task<bool> DeleteClientAsync(ClientModel client, CancellationToken ct)
        {
            return true;
            // true if deleted successfully false if not
        }

        public async Task<bool> UpdateClientAsync(ClientModel client, CancellationToken ct)
        {
            return true;
            // true if updated successfully false if not
        }

        public async Task<List<ClientModel>> GetClientsAsync(CancellationToken ct)
        {
            return new List<ClientModel>()
            {
                new ClientModel()
                {
                    Id = 1,
                    Name = "name"
                },
                new ClientModel()
                {
                    Id = 2,
                    Name = "name2"
                }
            };
        }

    }
}

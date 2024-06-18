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

        public async Task<bool> DeleteClientAsync(int id, CancellationToken ct)
        {
            return true;
            // true if deleted successfully false if not
        }

        public async Task<bool> UpdateClientAsync(int id, ClientModel client, CancellationToken ct)
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

        public async Task<ClientModel> GetClientByIdAsync(int id, CancellationToken ct)
        {
            return new ClientModel()
            {
                Id = 1,
                Name = "name"
            };
        }

    }
}

using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public interface IClientDal
    {
        Task<bool> AddClientAsync(ClientModel client, CancellationToken ct);
        Task<bool> DeleteClientAsync(ClientModel client, CancellationToken ct);
        Task<bool> UpdateClientAsync(ClientModel client, CancellationToken ct);
        Task<List<ClientModel>> GetClientsAsync(CancellationToken ct);

    }
}

using Bookstore.Models;

namespace Bookstore.DataAccess
{
    public interface IClientDal
    {
        Task<bool> AddClientAsync(ClientModel client, CancellationToken ct);
        Task<bool> DeleteClientAsync(int id, CancellationToken ct);
        Task<bool> UpdateClientAsync(int id, ClientModel client, CancellationToken ct);
        Task<List<ClientModel>> GetClientsAsync(CancellationToken ct);
        Task<ClientModel> GetClientByIdAsync(int id, CancellationToken ct);

    }
}

using Bookstore.Models;

namespace Bookstore.BusinessLogic
{
    public interface IClientBll
    {
        Task<bool> AddClientAsync(ClientModel client, CancellationToken ct);
        Task<bool> DeleteClientAsync(ClientModel client, CancellationToken ct);
        Task<bool> UpdateClientAsync(ClientModel client, CancellationToken ct);
        Task<List<ClientModel>> GetClientsAsync(CancellationToken ct);

    }
}

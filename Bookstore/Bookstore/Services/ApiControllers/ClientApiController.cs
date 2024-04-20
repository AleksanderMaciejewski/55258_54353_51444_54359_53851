using Bookstore.BusinessLogic;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Services.ApiControllers
{
    [ApiController]
    [Route("api/Client")]
    public class ClientApiController : ControllerBase
    {
        private readonly IClientBll _clientBll;

        public ClientApiController(IClientBll clientBll)
        {
            _clientBll = clientBll;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientBll.AddClientAsync(client, ct);
        }

        [HttpDelete("Delete")]
        public async Task<bool> DeleteClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientBll.DeleteClientAsync(client, ct);
        }

        [HttpPut("Update")]
        public async Task<bool> UpdateClientAsync(ClientModel client, CancellationToken ct)
        {
            return await _clientBll.UpdateClientAsync(client, ct);
        }

        [HttpGet("GetClients")]
        public async Task<List<ClientModel>> GetClientsAsync(CancellationToken ct)
        {
            return await _clientBll.GetClientsAsync(ct);
        }

    }
}

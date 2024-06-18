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
        public async Task<bool> DeleteClientAsync(int id, CancellationToken ct)
        {
            return await _clientBll.DeleteClientAsync(id, ct);
        }

        [HttpPut("Update")]
        public async Task<bool> UpdateClientAsync(int id, ClientModel client, CancellationToken ct)
        {
            return await _clientBll.UpdateClientAsync(id, client, ct);
        }

        [HttpGet("GetClientById")]
        public async Task<ClientModel> GetClientByIdAsync(int id, CancellationToken ct)
        {
            return await _clientBll.GetClientByIdAsync(id, ct);
        }

    }
}

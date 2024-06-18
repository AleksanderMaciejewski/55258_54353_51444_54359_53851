using Bookstore.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    // Controller class for handling client-related HTTP requests
    public class ClientController : Controller
    {
        private readonly IClientBll _clientBll;
        
        public ClientController(IClientBll clientBll)
        {
            _clientBll = clientBll;
        }

        public async Task<IActionResult> Home(CancellationToken ct)
        {
            var clients = await _clientBll.GetClientsAsync(ct);
            return View(clients);
        }

    }
}

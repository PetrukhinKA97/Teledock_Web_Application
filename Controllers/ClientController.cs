using Microsoft.AspNetCore.Mvc;
using Teledock_Web_Application.Connection;
using Teledock_Web_Application.Models;

namespace Teledock_Web_Application.Controllers
{
    public class ClientController : Controller
    {
        private readonly ConnectionDatabase database;

        public ClientController (ConnectionDatabase DB)
        {
            database= DB;
        }
        public IActionResult Index()
        {
            IEnumerable<ClientModel> DB= database.Clients.ToList();
            return View(DB);
        }
    }
}

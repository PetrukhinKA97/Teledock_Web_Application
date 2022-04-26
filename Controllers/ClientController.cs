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

        //GET
        public IActionResult Creite()
        {
           return View();
        }

        //GET
        public IActionResult Edit(ClientModel client)
        {
            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creite(ClientModel client)
        {
            if (client.Inn == client.Name.ToString())
            {
                ModelState.AddModelError("CustomError", "ИНН и Имя совпадает");
            }
            client.AddDate = DateTime.Now;
            client.UpdateDate = DateTime.Now;
            database.Clients.Add(client);
            database.SaveChanges();
            return RedirectToAction("Index", "Client");
        }
    }
}

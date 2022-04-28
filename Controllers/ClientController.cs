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

        //Get
        public IActionResult Edit(int? id)
        {

            if (id == null||id==0)
            {
                return NotFound();
            }
            var Client=database.Clients.Find(id);
            if (Client == null)
            {
                return NotFound();
            }
            Client.UpdateDate= DateTime.Now;
            return View(Client);
        }
       
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Edit(ClientModel client)
        {
            if (client.Inn == client.Name.ToString())
            {
                ModelState.AddModelError("CustomError", "ИНН и Имя совпадает");
            }
            client.UpdateDate = DateTime.Now;
            database.Clients.Update(client);
            database.SaveChanges();
            return RedirectToAction("Index", "Client");
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

        //GET
        public IActionResult Creite()
        {
            return View();
        }

        //Get
        public IActionResult Delete(int id)
        {
            var client = database.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            database.Remove(client);
            database.SaveChanges();
            return RedirectToAction("Index", "Client");
        }
    }
}

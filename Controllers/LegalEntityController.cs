using Microsoft.AspNetCore.Mvc;
using Teledock_Web_Application.Connection;
using Teledock_Web_Application.Models;

namespace Teledock_Web_Application.Controllers
{
    public class LegalEntityController : Controller
    {
        private readonly ConnectionDatabase database;

        public LegalEntityController(ConnectionDatabase DB)
        {
            database = DB;
        }
        public IActionResult Index()
        {
            IEnumerable<LegalEntityModel> DB = database.LegalEntity.ToList();
            return View(DB);
        }
        
        //Get
        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Client = database.Clients.Find(id);
            if (Client == null)
            {
                return NotFound();
            }
            return View(Client);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LegalEntityModel client)
        {
            database.LegalEntity.Update(client);
            database.SaveChanges();
            return RedirectToAction("Index", "LegalEntity");
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creite(LegalEntityModel client)
        {
            database.LegalEntity.Add(client);
            database.SaveChanges();
            return RedirectToAction("Index", "LegalEntity");
        }

        //GET
        public IActionResult Creite()
        {
            return View();
        }

        //Get
        public IActionResult Delete(int id)
        {
            var client = database.LegalEntity.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            database.Remove(client);
            database.SaveChanges();
            return RedirectToAction("Index", "LegalEntity");
        }
        
    }
}

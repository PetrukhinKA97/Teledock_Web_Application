using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Teledock_Web_Application.Connection;
using Teledock_Web_Application.Models;

namespace Teledock_Web_Application.Controllers
{
    public class UcheriditelController : Controller
    {
        //Разобраться с бд, убрать дублирование
        private readonly ConnectionDatabase database;

        //Разобраться с бд, убрать дублирование
        public UcheriditelController(ConnectionDatabase DB)
        {
            database = DB;
        }
        public IActionResult Index()
        {
            IEnumerable<UcheriditelModel> DB = database.Ucheriditel.ToList();
            return View(DB);
        }
        public IActionResult Edit(int? id)
        {
            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UcheriditelModel client)
        {
            client.UpdateDate = DateTime.Now;
            database.Ucheriditel.Update(client);
            database.SaveChanges();
            return RedirectToAction("Index", "Ucheriditel");
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creite(UcheriditelModel client)
        {
            client.AddDate = DateTime.Now;
            client.UpdateDate = DateTime.Now;
            database.Ucheriditel.Add(client);
            database.SaveChanges();
            return RedirectToAction("Index", "Ucheriditel");
        }

        //GET
        public IActionResult Creite()
        {
            return View();
        }

        //Get
        public IActionResult Delete(int id)
        {
            var client = database.Ucheriditel.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            database.Remove(client);
            database.SaveChanges();
            return RedirectToAction("Index", "Ucheriditel");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Teledock_Web_Application.Connection;
using Teledock_Web_Application.Models;

namespace Teledock_Web_Application.Controllers
{
    public class LegalEntityController : Controller
    {
        //Разобраться с бд, убрать дублирование
        private readonly ConnectionDatabase database;

        //Разобраться с бд, убрать дублирование
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
            return View();
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

            SelectList books = new SelectList(database.Ucheriditel.ToList(), "Fio");
            ViewBag.LegalEntityBag = books;
            return View();
        }

        //Get
        public IActionResult Delete(int id)
        {
            var LegalEntity = database.LegalEntity.Find(id);
            if (LegalEntity == null)
            {
                return NotFound();
            }
            database.Remove(LegalEntity);
            database.SaveChanges();
            return RedirectToAction("Index", "LegalEntity");
        }
        
    }
}

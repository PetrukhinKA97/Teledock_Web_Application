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
            var LegalEntity = database.LegalEntity.Find(id);
            if (LegalEntity == null)
            {
                return NotFound();
            }
            IEnumerable<LegalEntityModel> DB_Ucheriditel = database.Ucheriditel.ToList();
            return View(LegalEntity, DB_Ucheriditel);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LegalEntityModel LegalEntity)
        {
            database.LegalEntity.Update(LegalEntity);
            database.SaveChanges();
            return RedirectToAction("Index", "LegalEntity");
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creite(LegalEntityModel LegalEntity)
        {
            database.LegalEntity.Add(LegalEntity);
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

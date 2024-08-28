using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestS4L5BEAppPolizia.Models;
using TestS4L5BEAppPolizia.Services;

namespace TestS4L5BEAppPolizia.Controllers
{
    public class AnagraficheController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public AnagraficheController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public IActionResult Index()
        {
            var anagrafiche = _dbHelper.GetAnagrafiche();
            return View(anagrafiche);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                _dbHelper.AddAnagrafica(anagrafica);
                return RedirectToAction(nameof(Index));
            }
            return View(anagrafica);
        }

        public IActionResult Edit(int id)
        {
            var anagrafica = _dbHelper.GetAnagrafiche().FirstOrDefault(a => a.IdAnagrafica == id);
            if (anagrafica == null)
            {
                return NotFound();
            }
            return View(anagrafica);
        }

        [HttpPost]
        public IActionResult Edit(Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                _dbHelper.UpdateAnagrafica(anagrafica);
                return RedirectToAction(nameof(Index));
            }
            return View(anagrafica);
        }

        public IActionResult Delete(int id)
        {
            var anagrafica = _dbHelper.GetAnagrafiche().FirstOrDefault(a => a.IdAnagrafica == id);
            if (anagrafica == null)
            {
                return NotFound();
            }
            return View(anagrafica);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _dbHelper.DeleteAnagrafica(id);
            return RedirectToAction(nameof(Index));
        }
    }

}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestS4L5BEAppPolizia.Models;
using TestS4L5BEAppPolizia.Services;

namespace TestS4L5BEAppPolizia.Controllers
{
    public class VerbaliController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public VerbaliController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public IActionResult Index()
        {
            var verbali = _dbHelper.GetVerbali();
            return View(verbali);
        }

        public IActionResult Create()
        {
            ViewBag.Anagrafiche = new SelectList(_dbHelper.GetAnagrafiche(), "IdAnagrafica", "Cognome");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Verbale verbale)
        {
            if (ModelState.IsValid)
            {
                _dbHelper.AddVerbale(verbale);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Anagrafiche = new SelectList(_dbHelper.GetAnagrafiche(), "IdAnagrafica", "Cognome");
            return View(verbale);
        }

        public IActionResult Edit(int id)
        {
            var verbale = _dbHelper.GetVerbali().FirstOrDefault(v => v.IdVerbale == id);
            if (verbale == null)
            {
                return NotFound();
            }
            ViewBag.Anagrafiche = new SelectList(_dbHelper.GetAnagrafiche(), "IdAnagrafica", "Cognome");
            return View(verbale);
        }

        [HttpPost]
        public IActionResult Edit(Verbale verbale)
        {
            if (ModelState.IsValid)
            {
                _dbHelper.UpdateVerbale(verbale);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Anagrafiche = new SelectList(_dbHelper.GetAnagrafiche(), "IdAnagrafica", "Cognome");
            return View(verbale);
        }

        public IActionResult Delete(int id)
        {
            var verbale = _dbHelper.GetVerbali().FirstOrDefault(v => v.IdVerbale == id);
            if (verbale == null)
            {
                return NotFound();
            }
            return View(verbale);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _dbHelper.DeleteVerbale(id);
            return RedirectToAction(nameof(Index));
        }
    }

}

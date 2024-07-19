using Microsoft.AspNetCore.Mvc;
using TestS4L5BEAppPolizia.Models;
using TestS4L5BEAppPolizia.Services;

namespace TestS4L5BEAppPolizia.Controllers
{
    public class TipoViolazioniController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public TipoViolazioniController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public IActionResult Index()
        {
            var tipoViolazioni = _dbHelper.GetTipoViolazioni();
            return View(tipoViolazioni);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TipoViolazione tipoViolazione)
        {
            if (ModelState.IsValid)
            {
                _dbHelper.AddTipoViolazione(tipoViolazione);
                return RedirectToAction(nameof(Index));
            }
            return View(tipoViolazione);
        }

        public IActionResult Edit(int id)
        {
            var tipoViolazione = _dbHelper.GetTipoViolazioni().FirstOrDefault(v => v.IdViolazione == id);
            if (tipoViolazione == null)
            {
                return NotFound();
            }
            return View(tipoViolazione);
        }

        [HttpPost]
        public IActionResult Edit(TipoViolazione tipoViolazione)
        {
            if (ModelState.IsValid)
            {
                _dbHelper.UpdateTipoViolazione(tipoViolazione);
                return RedirectToAction(nameof(Index));
            }
            return View(tipoViolazione);
        }

        public IActionResult Delete(int id)
        {
            var tipoViolazione = _dbHelper.GetTipoViolazioni().FirstOrDefault(v => v.IdViolazione == id);
            if (tipoViolazione == null)
            {
                return NotFound();
            }
            return View(tipoViolazione);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _dbHelper.DeleteTipoViolazione(id);
            return RedirectToAction(nameof(Index));
        }
    }

}

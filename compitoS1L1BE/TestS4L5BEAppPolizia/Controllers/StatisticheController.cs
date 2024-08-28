using Microsoft.AspNetCore.Mvc;
using TestS4L5BEAppPolizia.Services;

namespace TestS4L5BEAppPolizia.Controllers
{
    public class StatisticheController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public StatisticheController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public IActionResult TotaleVerbaliPerTrasgressore()
        {
            var statistiche = _dbHelper.GetTotaleVerbaliPerTrasgressore();
            return View(statistiche);
        }

        public IActionResult TotalePuntiDecurtatiPerTrasgressore()
        {
            var statistiche = _dbHelper.GetTotalePuntiDecurtatiPerTrasgressore();
            return View(statistiche);
        }

        public IActionResult ViolazioniConPiuDi10Punti()
        {
            var violazioni = _dbHelper.GetViolazioniConPiuDi10Punti();
            return View(violazioni);
        }

        public IActionResult ViolazioniConImportoMaggioreDi400()
        {
            var violazioni = _dbHelper.GetViolazioniConImportoMaggioreDi400();
            return View(violazioni);
        }
    }

}

using Microsoft.AspNetCore.Mvc;
using TestS4L5BEAppPolizia.Services;
using TestS4L5BEAppPolizia.Models;

public class ViolazioniController : Controller
{
    private readonly DatabaseHelper _databaseHelper;

    public ViolazioniController(DatabaseHelper databaseHelper)
    {
        _databaseHelper = databaseHelper;
    }

    public IActionResult ViolazioniConPiuDi10Punti()
    {
        var violazioni = _databaseHelper.GetViolazioniConPiuDi10Punti();
        return View(violazioni);
    }

    public IActionResult ViolazioniConImportoMaggioreDi400()
    {
        var violazioni = _databaseHelper.GetViolazioniConImportoMaggioreDi400();
        return View(violazioni);
    }
}

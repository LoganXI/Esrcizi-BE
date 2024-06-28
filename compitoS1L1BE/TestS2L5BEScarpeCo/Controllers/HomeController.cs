using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestS2L5BEScarpeCo.Models;
using TestS2L5BEScarpeCo.Repo;



namespace TestS2L5BEScarpeCo.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var articoli = ArticoloRepo.GetArticoli();
            return View(articoli);
        }

        public IActionResult Dettagli(int id)
        {
            var articolo = ArticoloRepo.GetArticoloById(id);
            if (articolo == null)
            {
                return NotFound();
            }
            return View(articolo);
        }

        public IActionResult Aggiungi(Articolo articolo)
        {
            if (ModelState.IsValid)
            {
                ArticoloRepo.AddArticolo(articolo);
                return RedirectToAction("Index");
            }
            return View(articolo);
        }
    }
}

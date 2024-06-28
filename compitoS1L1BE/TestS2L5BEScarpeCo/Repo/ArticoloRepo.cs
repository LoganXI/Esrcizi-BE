using TestS2L5BEScarpeCo.Models;

namespace TestS2L5BEScarpeCo.Repo
{
    public class ArticoloRepo
    {
         
        private static List<Articolo> _articoli = new List<Articolo>
        {
            new Articolo { Id = 1, Nome = "Scarpa A", Prezzo = 59.99m, Descrizione = "Scarpa A descrizione dettagliata", CopertinaImg = "", ImgPlus = "img1_1.jpg", ImgPlusPlus = "img1_2.jpg" },
            new Articolo { Id = 2, Nome = "Scarpa B", Prezzo = 59.99m, Descrizione = "Scarpa A descrizione dettagliata", CopertinaImg = "img1.jpg", ImgPlus = "img1_1.jpg", ImgPlusPlus = "img1_2.jpg" },
            new Articolo { Id = 3, Nome = "Scarpa C", Prezzo = 59.99m, Descrizione = "Scarpa A descrizione dettagliata", CopertinaImg = "img1.jpg", ImgPlus = "img1_1.jpg", ImgPlusPlus = "img1_2.jpg" },
            new Articolo { Id = 4, Nome = "Scarpa D", Prezzo = 89.99m, Descrizione = "Scarpa B descrizione dettagliata", CopertinaImg = "img2.jpg", ImgPlus = "img2_1.jpg", ImgPlusPlus = "img2_2.jpg" }
        };  

        public static List<Articolo> GetArticoli() => _articoli;

        public static Articolo GetArticoloById(int id) => _articoli.FirstOrDefault(a => a.Id == id);

        public static void AddArticolo(Articolo articolo)
        {
            
            articolo.Id = _articoli.Any() ? _articoli.Max(a => a.Id) + 1 : 1;
            _articoli.Add(articolo);
        }
    }
}


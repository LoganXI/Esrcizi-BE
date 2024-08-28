using TestS2L5BEScarpeCo.Models;

namespace TestS2L5BEScarpeCo.Repo
{
    public class ArticoloRepo
    {
         
        private static List<Articolo> _articoli = new List<Articolo>
        {
            new Articolo { 
                Id = 1, 
                Nome = "Nike Air Max 270", 
                Prezzo = 99.99m, 
                Descrizione = "Scarpa sportiva di alta qualità.", 
                CopertinaImg = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/a9a58e7a-4122-4ed1-8593-cb87c66d7a4a/scarpa-air-max-270-a-Jq436k.png",
                ImgPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/53651b22-eb1e-4333-b89c-eb6d3e70e18f/scarpa-air-max-270-a-Jq436k.png", 
                ImgPlusPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/1cc79f0e-2153-4363-ade4-83eabda600c6/scarpa-air-max-270-a-Jq436k.png"
            },
           new Articolo {
                Id = 2,
                Nome = "Nike Air Max 90",
                Prezzo = 159.99m,
                Descrizione = "Scarpa sportiva di alta qualità.",
                CopertinaImg = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/8ea8c17b-45d1-483a-af6a-3edf863cd307/scarpa-air-max-90-fRmKKm.png",
                ImgPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/3ea79232-3c64-47eb-850a-da5512f61794/scarpa-air-max-90-fRmKKm.png",
                ImgPlusPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/e8b9402e-065c-424b-af8b-e3c12bc4d9d8/scarpa-air-max-90-fRmKKm.png"
            },new Articolo {
                Id = 3,
                Nome = "Nike Air Max Dn",
                Prezzo = 199.99m,
                Descrizione = "Scarpa sportiva di alta qualità.",
                CopertinaImg = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/f0813191-b222-481b-8f9b-46a660143264/scarpa-air-max-dn-a-NJwfDR.png",
                ImgPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/55ad6918-428d-438a-a155-e19eabd4a20d/scarpa-air-max-dn-a-NJwfDR.png",
                ImgPlusPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/78c60109-9aef-4b70-9d7d-3dcffc36e49d/scarpa-air-max-dn-a-NJwfDR.png"
            },new Articolo {
                Id = 4,
                Nome = "Nike Air Max Plus Drift",
                Prezzo = 189.99m,
                Descrizione = "Scarpa sportiva di alta qualità.",
                CopertinaImg = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/198e37ad-6f8f-4fe4-b888-1bd0c32ee2d9/scarpa-air-max-plus-drift-1L9ldF.png",
                ImgPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/528e72b3-f4cd-4182-b20a-1068ddb17e4f/scarpa-air-max-plus-drift-1L9ldF.png",
                ImgPlusPlus = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/04be003d-1d34-4bc9-af80-4ea504efe6c8/scarpa-air-max-plus-drift-1L9ldF.png"
            },
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


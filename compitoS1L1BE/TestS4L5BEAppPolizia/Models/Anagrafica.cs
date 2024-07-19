namespace TestS4L5BEAppPolizia.Models
{
    public class Anagrafica
    {
       
            public int IdAnagrafica { get; set; }
            public string Cognome { get; set; }
            public string Nome { get; set; }
            public string Indirizzo { get; set; }
            public string Citta { get; set; }
            public int CAP { get; set; }
            public string Cod_Fisc { get; set; }
            public ICollection<Verbale> Verbali { get; set; }
        
    }
}

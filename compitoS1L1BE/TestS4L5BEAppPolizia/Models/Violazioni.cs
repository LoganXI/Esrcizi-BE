namespace TestS4L5BEAppPolizia.Models
{
    public class Violazioni
    {
        
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public decimal Importo { get; set; }
        public DateTime DataViolazione { get; set; }
        public int DecurtamentoPunti { get; set; }
    }
}


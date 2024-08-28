namespace TestS4L5BEAppPolizia.Models
{
    public class Verbale
    {
        public int IdVerbale { get; set; }
        public DateTime DataViolazione { get; set; }
        public string IndirizzoViolazione { get; set; }
        public int Matricola_Agente { get; set; }
        public DateTime DataTrascrizioneVerbale { get; set; }
        public decimal Importo { get; set; }
        public int DecurtamentoPunti { get; set; }
        public int IdAnagraficaFK { get; set; }
        public Anagrafica Anagrafica { get; set; }
        public ICollection<ViolazioneXMulta> ViolazioniXMulta { get; set; }
    }
}

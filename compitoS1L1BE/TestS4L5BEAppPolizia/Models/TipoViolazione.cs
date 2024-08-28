namespace TestS4L5BEAppPolizia.Models
{
    public class TipoViolazione
    {
        public int IdViolazione { get; set; }
        public string Descrizione { get; set; }
        public ICollection<ViolazioneXMulta> ViolazioniXMulta { get; set; }
    }
}

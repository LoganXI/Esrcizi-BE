namespace TestS4L5BEAppPolizia.Models
{
    public class ViolazioneXMulta
    {
        public int IdViolazXMulta { get; set; }
        public int IdVerbaleFK { get; set; }
        public int IdViolazioneFK { get; set; }
        public Verbale Verbale { get; set; }
        public TipoViolazione TipoViolazione { get; set; }
    }
}

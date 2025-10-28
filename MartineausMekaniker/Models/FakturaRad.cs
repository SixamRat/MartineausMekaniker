namespace MartineausMekaniker.Models
{
    public class FakturaRad
    {
        public int FakturaRadId { get; set; }        
        public int FakturaId { get; set; }
        public Faktura? Faktura { get; set; }
        public string Beskrivning { get; set; } = string.Empty;
        public decimal Antal { get; set; }
        public decimal Pris { get; set; }
        public decimal Summa { get; set; }
        public string Typ { get; set; } = string.Empty;
    }
}
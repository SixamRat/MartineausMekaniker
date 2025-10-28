namespace MartineausMekaniker.Models
{
    public class Fordon
    {
        public int FordonId { get; set; }
        public string Registreringsnummer { get; set; } = string.Empty;
        public string Marke { get; set; } = string.Empty;
        public string Modell { get; set; } = string.Empty;
        public int Arsmodell { get; set; }
        public string Farg { get; set; } = string.Empty;
        public int? Miltal { get; set; }        
        public int KundId { get; set; }
        public Kund? Kund { get; set; }        
        public ICollection<Bokning>? Bokningar { get; set; }
    }
}
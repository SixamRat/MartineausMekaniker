namespace MartineausMekaniker.Models
{
    public class Faktura
    {
        public int FakturaId { get; set; }
        public string Fakturanummer { get; set; } = string.Empty;        
        public int KundId { get; set; }
        public Kund? Kund { get; set; }
        public int? BokningId { get; set; }
        public Bokning? Bokning { get; set; }        
        public DateTime FakturaDatum { get; set; }
        public DateTime ForfalloDatum { get; set; }
        public decimal Arbetskostnad { get; set; }
        public decimal Materialkostnad { get; set; }
        public decimal Summa { get; set; }
        public decimal Moms { get; set; }
        public decimal Totalt { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Betalningsvillkor { get; set; } = "30 dagar";        
        public ICollection<FakturaRad>? FakturaRader { get; set; }
    }
}
namespace MartineausMekaniker.Models
{
    public class Kund
    {
        public int KundId { get; set; }
        public string Namn { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public string Postnummer { get; set; } = string.Empty;
        public string Postort { get; set; } = string.Empty;
        public string Kundtyp { get; set; } = string.Empty; 
        public string? Organisationsnummer { get; set; }        
        public ICollection<Fordon>? Fordon { get; set; }
        public ICollection<Bokning>? Bokningar { get; set; }
        public ICollection<Faktura>? Fakturor { get; set; }
    }
}
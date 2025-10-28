namespace MartineausMekaniker.Models
{
    public class Bokning
    {
        public int BokningId { get; set; }        
        public int KundId { get; set; }
        public Kund? Kund { get; set; }
        public int FordonId { get; set; }
        public Fordon? Fordon { get; set; }
        public int? PersonalId { get; set; } 
        public Personal? Personal { get; set; }        
        public DateTime BokningsDatum { get; set; }
        public TimeSpan StartTid { get; set; }
        public TimeSpan SlutTid { get; set; }
        public string Bokningstyp { get; set; } = string.Empty; 
        public string Beskrivning { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; 
        public DateTime SkapadDatum { get; set; } = DateTime.Now;        
        public ICollection<Tidrapport>? Tidrapporter { get; set; }
    }
}
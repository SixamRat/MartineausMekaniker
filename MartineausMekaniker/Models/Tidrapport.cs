namespace MartineausMekaniker.Models
{
    public class Tidrapport
    {
        public int TidrapportId { get; set; }     
        public int PersonalId { get; set; }
        public Personal? Personal { get; set; }
        public int? BokningId { get; set; }
        public Bokning? Bokning { get; set; }       
        public DateTime Datum { get; set; }
        public TimeSpan StartTid { get; set; }
        public TimeSpan SlutTid { get; set; }
        public decimal TimmarArbetat { get; set; }
        public string Arbetstyp { get; set; } = string.Empty;
        public string Beskrivning { get; set; } = string.Empty;
        public DateTime SkapadDatum { get; set; } = DateTime.Now;
    }
}
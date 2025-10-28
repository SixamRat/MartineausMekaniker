namespace MartineausMekaniker.Models
{
    public class Personal
    {
        public int PersonalId { get; set; }
        public string Namn { get; set; } = string.Empty;
        public string Personnummer { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;       
        public string Befattning { get; set; } = string.Empty;
        public string Specialisering { get; set; } = string.Empty;
        public DateTime Anstallningsdatum { get; set; }
        public decimal Timpris { get; set; }       
        public int AterstSemesterdagar { get; set; }        
        public ICollection<Tidrapport>? Tidrapporter { get; set; }
        public ICollection<Bokning>? Bokningar { get; set; }
    }
}
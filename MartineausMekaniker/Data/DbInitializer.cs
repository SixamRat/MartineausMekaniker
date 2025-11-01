using MartineausMekaniker.Models;

namespace MartineausMekaniker.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            
            if (context.Personal.Any())
            {
                return; 
            }

            
            var personal = new List<Personal>
            {
                new Personal
                {
                    Namn = "Erik Martinsson",
                    Personnummer = "19850315-1234",
                    Email = "erik@martineau.se",
                    Telefon = "070-1234567",
                    Adress = "Verkstadsgatan 1",
                    Befattning = "Verkstadschef",
                    Specialisering = "Motor",
                    Anstallningsdatum = new DateTime(2015, 1, 15),
                    Timpris = 950m,
                    AterstSemesterdagar = 25
                },
                new Personal
                {
                    Namn = "Anna Svensson",
                    Personnummer = "19900520-5678",
                    Email = "anna@martineau.se",
                    Telefon = "070-2345678",
                    Adress = "Mekanikergatan 5",
                    Befattning = "Bilmekaniker",
                    Specialisering = "Bromsar",
                    Anstallningsdatum = new DateTime(2018, 3, 1),
                    Timpris = 850m,
                    AterstSemesterdagar = 18
                },
                new Personal
                {
                    Namn = "Johan Bergström",
                    Personnummer = "19880710-9012",
                    Email = "johan@martineau.se",
                    Telefon = "070-3456789",
                    Adress = "Däckvägen 12",
                    Befattning = "Däcktekniker",
                    Specialisering = "Däck",
                    Anstallningsdatum = new DateTime(2020, 6, 15),
                    Timpris = 750m,
                    AterstSemesterdagar = 22
                }
            };

            context.Personal.AddRange(personal);

            // Skapa kunder
            var kunder = new List<Kund>
            {
                new Kund
                {
                    Namn = "Maria Andersson",
                    Email = "maria.andersson@email.com",
                    Telefon = "073-1111111",
                    Adress = "Storgatan 15",
                    Postnummer = "12345",
                    Postort = "Stockholm",
                    Kundtyp = "Privat"
                },
                new Kund
                {
                    Namn = "AB Transport & Logistik",
                    Email = "info@transport.se",
                    Telefon = "08-2222222",
                    Adress = "Industrivägen 50",
                    Postnummer = "15432",
                    Postort = "Stockholm",
                    Kundtyp = "Företag",
                    Organisationsnummer = "556677-8899"
                },
                new Kund
                {
                    Namn = "Kalle Karlsson",
                    Email = "kalle@email.com",
                    Telefon = "073-3333333",
                    Adress = "Lillgatan 7",
                    Postnummer = "11122",
                    Postort = "Stockholm",
                    Kundtyp = "Privat"
                }
            };

            context.Kunder.AddRange(kunder);
            context.SaveChanges();

            // Skapa fordon
            var fordon = new List<Fordon>
            {
                new Fordon
                {
                    Registreringsnummer = "ABC123",
                    Marke = "Volvo",
                    Modell = "V70",
                    Arsmodell = 2015,
                    Farg = "Grå",
                    Miltal = 125000,
                    KundId = kunder[0].KundId
                },
                new Fordon
                {
                    Registreringsnummer = "DEF456",
                    Marke = "Mercedes",
                    Modell = "Sprinter",
                    Arsmodell = 2020,
                    Farg = "Vit",
                    Miltal = 85000,
                    KundId = kunder[1].KundId
                },
                new Fordon
                {
                    Registreringsnummer = "GHI789",
                    Marke = "Toyota",
                    Modell = "Corolla",
                    Arsmodell = 2019,
                    Farg = "Röd",
                    Miltal = 65000,
                    KundId = kunder[2].KundId
                }
            };

            context.Fordon.AddRange(fordon);
            context.SaveChanges();

            // Skapa bokningar
            var bokningar = new List<Bokning>
            {
                new Bokning
                {
                    KundId = kunder[0].KundId,
                    FordonId = fordon[0].FordonId,
                    PersonalId = personal[0].PersonalId,
                    BokningsDatum = DateTime.Now.AddDays(7),
                    StartTid = new TimeSpan(9, 0, 0),
                    SlutTid = new TimeSpan(11, 0, 0),
                    Bokningstyp = "Service",
                    Beskrivning = "Servicebok + Oljebyte",
                    Status = "Bokad"
                },
                new Bokning
                {
                    KundId = kunder[1].KundId,
                    FordonId = fordon[1].FordonId,
                    PersonalId = personal[1].PersonalId,
                    BokningsDatum = DateTime.Now.AddDays(3),
                    StartTid = new TimeSpan(13, 0, 0),
                    SlutTid = new TimeSpan(16, 0, 0),
                    Bokningstyp = "Reparation",
                    Beskrivning = "Bromsreparation",
                    Status = "Bokad"
                }
            };

            context.Bokningar.AddRange(bokningar);
            context.SaveChanges();

            // Skapa tidrapporter
            var tidrapporter = new List<Tidrapport>
            {
                new Tidrapport
                {
                    PersonalId = personal[0].PersonalId,
                    BokningId = bokningar[0].BokningId,
                    Datum = DateTime.Now.AddDays(-2),
                    StartTid = new TimeSpan(9, 0, 0),
                    SlutTid = new TimeSpan(12, 0, 0),
                    TimmarArbetat = 3m,
                    Arbetstyp = "Service",
                    Beskrivning = "Genomfört servicebok på Volvo V70"
                }
            };

            context.Tidrapporter.AddRange(tidrapporter);
            context.SaveChanges();
        }
    }
}
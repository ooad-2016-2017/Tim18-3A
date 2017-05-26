using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    class DefaultPodaci
    {
        public static void Initialize(TeamerDbContext context)
        {
            if (!context.Treneri.Any())
            {
                context.Treneri.AddRange(
                    new Trener()
                    {
                        Ime = "Amel",
                        Prezime = "Sazic",
                        Username = "Saza",
                        Password ="1234",
                        Email = "amel.sazic@gmail.com"

                    });
                context.SaveChanges();
            }
            if (!context.Menadzeri.Any())
            {
                context.Menadzeri.AddRange(
                    new Menadzer()
                    {
                        Ime = "Amer",
                        Prezime = "Puric",
                        Username = "Picko",
                        Password = "12345",
                        Email = "amer.puric@gmail.com"

                    });
                context.SaveChanges();
            }
            if (!context.Timovi.Any())
            {
                context.Timovi.AddRange(
                    new Tim()
                    {
                        Naziv = "3A",
                        Manager = context.Menadzeri.Where(x => x.Username == "Picko").FirstOrDefault()
                    });
                context.SaveChanges();
            }
            if (!context.Igraci.Any())
            {
                context.Igraci.AddRange(
                    new Igrac()
                    {
                        Ime = "Armin",
                        Prezime = "Omerbegovic",
                        Username = "Adza",
                        DatumRodjenja = DateTime.Now
                    });
                context.SaveChanges();
            }
        }
    }
}

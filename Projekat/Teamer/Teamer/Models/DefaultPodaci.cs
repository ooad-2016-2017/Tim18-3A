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
        }
    }
}

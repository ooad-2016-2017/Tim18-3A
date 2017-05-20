using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Dogadjaj
    {
        int TipDogadjaja { get; set; }
        string Lokacija { get; set; } //korisiti koordinate
        DateTime DatumDogadjaja { get; set; }
        string Opis { get; set; }
        List<Izvjestaj> Izvjestaji { get; set; }
    }
}

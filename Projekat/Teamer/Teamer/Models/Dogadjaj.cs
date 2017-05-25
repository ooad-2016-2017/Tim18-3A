using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Dogadjaj
    { 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int DogadjajID { get; set; }
        TipDogadjaja TipDogadjaja { get; set; }
        int TipDogadjajaID { get; set; }
        float GeoDuzina { get; set; }
        float GeoSirina { get; set; }
        DateTime DatumDogadjaja { get; set; }
        string Opis { get; set; }
        ICollection<Izvjestaj> Izvjestaji { get; set; }
    }
}

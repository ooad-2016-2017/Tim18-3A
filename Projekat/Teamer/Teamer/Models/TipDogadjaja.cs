using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    class TipDogadjaja
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int TipDogadjajaID { get; set; }
        [Required]
        string Kategorija { get; set; }
        [Required]
        string Kod { get; set; }
        [Required]
        string Opis { get; set; }
        Dogadjaj Dogadjaj { get; set; }
        int DogadjajID { get; set; }
    }
}

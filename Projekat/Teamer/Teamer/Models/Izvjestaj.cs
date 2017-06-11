using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Izvjestaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int IzvjestajID { get; set; }
        int Ocjena { get; set; }
        [Required]
        string Komentar { get; set; }
        Dogadjaj Dogadjaj { get; set; }
        int DogadjajID { get; set; }
        Igrac Igrac { get; set; }
    }
}

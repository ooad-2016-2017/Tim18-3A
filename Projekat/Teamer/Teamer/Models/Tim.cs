using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Tim
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int TimID { get; set; }
        [Required]
        string Naziv { get; set; }
        byte[] Slika { get; set; }

        int TrenerID { get; set; }
        Trener Trener { get; set; }

        ICollection<Igrac> Igraci { get; set; }

        int ManagerID { get; set; }
        Menadzer Manager { get; set; }

        ICollection<Dogadjaj> Dogadjaji { get; set; }
        ICollection<byte[]> Galerija { get; set; }
         
    }
}

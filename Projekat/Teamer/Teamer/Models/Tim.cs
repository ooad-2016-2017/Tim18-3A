using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Tim
    {
        int TimID { get; set; }
        string Naziv { get; set; }
        byte[] Slika { get; set; }

        int TrenerID { get; set; }
        Trener Trener { get; set; }

        ICollection<Igrac> Igraci { get; set; }

        int ManagerID { get; set; }
        Manager Manager { get; set; }

        ICollection<Dogadjaj> Dogadjaji { get; set; }
        //List<Image> LISTA SLIKAA
         
    }
}

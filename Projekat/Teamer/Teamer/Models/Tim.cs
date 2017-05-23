using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Tim
    {
        string Naziv { get; set; }
        byte[] Slika { get; set; }
        Trener Trener;
        List<Igrac> Igraci;
        Manager Manager;
        List<Dogadjaj> Dogadjaji;
        //List<Image> LISTA SLIKAA
         
    }
}

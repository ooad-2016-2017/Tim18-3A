using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Izvjestaj
    {
        int IzvjestajID { get; set; }
        int Ocjena { get; set; }
        string Komentar { get; set; }
        Dogadjaj Dogadjaj { get; set; }
        //Igrac Igrac { get; set; }
    }
}

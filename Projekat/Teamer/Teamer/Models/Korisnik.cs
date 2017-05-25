using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Korisnik
    {
        int KorisnikID { get; set; }
        DateTime DatumRodjenja { get; set; }
        string Email { get; set; }
        string Ime { get; set; }
        string Prezime { get; set; }
        string Password { get; set; }
        string Username { get; set; }
        byte[] Slika { get; set; }
        int TipDogadjaja { get; set; }
    }
}

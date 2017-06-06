using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.ViewModel
{
    abstract class KorisnikVM
    {
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public byte[] Slika { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Models;
using Teamer.ViewModel;

namespace Teamer.Mappers
{
    static class KorisnikMapper
    {
        public static MenadzerVM MapMenadzerToMenadzerVM(this Menadzer korisnik)
        {
            var korisnikVM = new MenadzerVM();

            korisnikVM.Ime = korisnik.Ime;
            korisnikVM.Prezime = korisnik.Prezime;
            korisnikVM.Password = korisnik.Password;
            korisnikVM.Slika = korisnik.Slika;
            korisnikVM.Email = korisnik.Email;
            korisnikVM.DatumRodjenja = korisnik.DatumRodjenja;
            korisnikVM.Timovi = korisnik.Timovi.ToList();

            return korisnikVM;
        }

        public static TrenerVM MapTrenerToTrenerVM(this Trener korisnik)
        {
            var korisnikVM = new TrenerVM();

            korisnikVM.Ime = korisnik.Ime;
            korisnikVM.Prezime = korisnik.Prezime;
            korisnikVM.Password = korisnik.Password;
            korisnikVM.Slika = korisnik.Slika;
            korisnikVM.Email = korisnik.Email;
            korisnikVM.DatumRodjenja = korisnik.DatumRodjenja;
            korisnikVM.Tim = korisnik.Tim;

            return korisnikVM;
        }

        public static IgracVM MapIgracToIgracVM(this Igrac korisnik)
        {
            var korisnikVM = new IgracVM();

            korisnikVM.Ime = korisnik.Ime;
            korisnikVM.Prezime = korisnik.Prezime;
            korisnikVM.Password = korisnik.Password;
            korisnikVM.Slika = korisnik.Slika;
            korisnikVM.Email = korisnik.Email;
            korisnikVM.DatumRodjenja = korisnik.DatumRodjenja;
            korisnikVM.Tim = korisnik.Tim;

            return korisnikVM;
        }

    }
}

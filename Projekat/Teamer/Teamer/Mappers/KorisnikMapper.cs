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
            korisnikVM.Username = korisnik.Username;
            korisnikVM.Password = korisnik.Password;
            korisnikVM.Slika = korisnik.Slika;
            korisnikVM.Email = korisnik.Email;
            korisnikVM.DatumRodjenja = korisnik.DatumRodjenja;
            korisnikVM.Sport = korisnik.Sport;
            korisnikVM.Timovi = korisnik.Timovi.ToList();

            return korisnikVM;
        }
        public static Menadzer MapMenadzerVMToMenadzer(this MenadzerVM korisnikVM)
        {
            var korisnik = new Menadzer();
            korisnik.Ime = korisnikVM.Ime;
            korisnik.Prezime = korisnikVM.Prezime;
            korisnik.Username = korisnikVM.Username;
            korisnik.Password = korisnikVM.Password;
            korisnik.Slika = korisnikVM.Slika;
            korisnik.Email = korisnikVM.Email;
            korisnik.DatumRodjenja = korisnikVM.DatumRodjenja;
            korisnik.Timovi = korisnikVM.Timovi;
            korisnik.Sport = korisnikVM.Sport;
            return korisnik;
        }

        public static TrenerVM MapTrenerToTrenerVM(this Trener korisnik)
        {
            var korisnikVM = new TrenerVM();

            korisnikVM.Ime = korisnik.Ime;
            korisnikVM.Prezime = korisnik.Prezime;
            korisnikVM.Username = korisnik.Username;
            korisnikVM.Password = korisnik.Password;
            korisnikVM.Slika = korisnik.Slika;
            korisnikVM.Email = korisnik.Email;
            korisnikVM.DatumRodjenja = korisnik.DatumRodjenja;
            korisnikVM.Tim = korisnik.Tim;
            korisnikVM.Sport = korisnik.Sport;

            return korisnikVM;
        }

        public static Trener MapTrenerVMToTrener(this TrenerVM korisnikVM)
        {
            var korisnik = new Trener();

            korisnik.Ime = korisnikVM.Ime;
            korisnik.Prezime = korisnikVM.Prezime;
            korisnik.Username = korisnikVM.Username;
            korisnik.Password = korisnikVM.Password;
            korisnik.Slika = korisnikVM.Slika;
            korisnik.Email = korisnikVM.Email;
            korisnik.DatumRodjenja = korisnikVM.DatumRodjenja;
            korisnik.Tim = korisnikVM.Tim;
            korisnik.Sport = korisnikVM.Sport;

            return korisnik;
        }

        public static IgracVM MapIgracToIgracVM(this Igrac korisnik)
        {
            var korisnikVM = new IgracVM();

            korisnikVM.Ime = korisnik.Ime;
            korisnikVM.Prezime = korisnik.Prezime;
            korisnikVM.Username = korisnik.Username;
            korisnikVM.Password = korisnik.Password;
            korisnikVM.Slika = korisnik.Slika;
            korisnikVM.Email = korisnik.Email;
            korisnikVM.DatumRodjenja = korisnik.DatumRodjenja;
            korisnikVM.Tim = korisnik.Tim;
            korisnikVM.Sport = korisnik.Sport;

            return korisnikVM;
        }

        public static Igrac MapIgracVMToIgrac(this IgracVM korisnikVM)
        {
            var korisnik = new Igrac();

            korisnik.Ime = korisnikVM.Ime;
            korisnik.Prezime = korisnikVM.Prezime;
            korisnik.Username = korisnikVM.Username;
            korisnik.Password = korisnikVM.Password;
            korisnik.Slika = korisnikVM.Slika;
            korisnik.Email = korisnikVM.Email;
            korisnik.DatumRodjenja = korisnikVM.DatumRodjenja;
            korisnik.Tim = korisnikVM.Tim;
            korisnik.Sport = korisnikVM.Sport;

            return korisnik;
        }
    }
}

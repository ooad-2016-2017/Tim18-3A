using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Mappers;
using Teamer.Models;
using Windows.UI.Xaml;

namespace Teamer.ViewModel
{
    class LoginViewModel
    {
        TeamerDbContext context;

        public LoginViewModel()
        {
            context = new TeamerDbContext();
        }

        public KorisnikVM PretraziKorisnike(string username)
        {
            KorisnikVM korisnik = null;
            MenadzerVM item;
            TrenerVM item2;
            IgracVM item3;
            if ((item = PretraziMenadzere(username)) != null)
            {
                korisnik = new MenadzerVM();
                korisnik = item;
            }
            if ((item2 = PretraziTrenere(username)) != null && korisnik == null)
            {
                korisnik = new TrenerVM();
                korisnik = item2;
            }
            if ((item3 = PretraziIgrace(username)) != null && korisnik == null)
            {
                korisnik = new IgracVM();
                korisnik = item2;
            }

            return korisnik;
        }

        private MenadzerVM PretraziMenadzere(string username)
        {
            var menadzer = context.Menadzeri.Where(x => x.Username == username).FirstOrDefault();

            MenadzerVM menadzerVM = null;
            if(menadzer != null)
            {
                menadzerVM = menadzer.MapMenadzerToMenadzerVM();
            }


            return menadzerVM;
        }
        private TrenerVM PretraziTrenere(string username)
        {
            var trener = context.Treneri.Where(x => x.Username == username).FirstOrDefault();

            TrenerVM trenerVM = null;
            if (trener != null)
            {
                trenerVM = trener.MapTrenerToTrenerVM();
            }

            return trenerVM;
        }

        private IgracVM PretraziIgrace(string username)
        {
            var igrac = context.Igraci.Where(x => x.Username == username).FirstOrDefault();

            IgracVM igracVM = null;
            if (igrac != null)
            {
                igracVM = igrac.MapIgracToIgracVM();
            }

            return igracVM;
        }
    }
}

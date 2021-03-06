﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Mappers;
using Teamer.Models;
using Windows.UI.Xaml;

namespace Teamer.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        TeamerDbContext context;
        private string username;
        private string password;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        public int tip;

        public LoginViewModel()
        {
            context = new TeamerDbContext();
        }

        public KorisnikVM PretraziKorisnike()
        {
            KorisnikVM korisnik = null;
            MenadzerVM item = new MenadzerVM();
            TrenerVM item2 = new TrenerVM();
            IgracVM item3 = new IgracVM();
            if ((item = PretraziMenadzere(Username)) != null)
            {
                korisnik = new MenadzerVM();
                korisnik = item;
                tip = 0;
            }
            if ((item2 = PretraziTrenere(Username)) != null && korisnik == null)
            {
                korisnik = new TrenerVM();
                korisnik = item2;
                tip = 1;
            }
            if ((item3 = PretraziIgrace(Username)) != null && korisnik == null)
            {
                korisnik = new IgracVM();
                korisnik = item2;
                tip = 2;
            }

            return korisnik;
        }

        private MenadzerVM PretraziMenadzere(string username)
        {
            var menadzer = context.Menadzeri.Include(x => x.Timovi).Where(x => x.Username == username).FirstOrDefault();

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Models;
using Windows.UI.Xaml.Controls;
using Teamer.Mappers;
using System.Text.RegularExpressions;

namespace Teamer.ViewModel
{
    class RegistrationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        TeamerDbContext context;
        private string _email;
        private string _username;
        private string _password;
        private string _cpassword;
        private DateTimeOffset _datumRodjenja;
        private string _sport;
        private byte[] _slika;
        private int _tipKorisnika;
        KorisnikVM korisnik;

        public RegistrationViewModel()
        {
            context = new TeamerDbContext();
        }
        public KorisnikVM KreirajKorisnika()
        {
            string greska;
            if ((greska = ProvjeriParametre()).Count() != 0)
            {
               
                switch (_tipKorisnika)
                {
                    case 1:
                        var menadzer = new MenadzerVM(Username, Password, Email, Slika, DatumRodjenja.Date, Sport);
                        context.Menadzeri.Add(menadzer.MapMenadzerVMToMenadzer());
                        korisnik = menadzer;
                        context.SaveChanges();
                        break;
                    case 2:
                        var trener = new TrenerVM(Username, Password, Email, Slika, DatumRodjenja.Date, Sport);
                        context.Treneri.Add(trener.MapTrenerVMToTrener());
                        korisnik = trener;
                        context.SaveChanges();
                        break;
                    case 3:
                        var igrac = new IgracVM(Username, Password, Email, Slika, DatumRodjenja.Date, Sport);
                        context.Igraci.Add(igrac.MapIgracVMToIgrac());
                        korisnik = igrac;
                        context.SaveChanges();
                        break;
                }
                
                return korisnik;
            }
            return null;
        }
        bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public string ProvjeriParametre()
        {
            string error = "";

            if (Email == null || Email.Count() == 0 || !(IsValidEmail(Email))) error += "email not entered, ";
            if (Username == null || Username.Count() == 0) error += "username not entered, ";
            if (Password == null || Password.Count() == 0) error += "password not entered, ";
            if (Cpassword == null || Cpassword.Count() == 0) error += "password confirmation not entered, ";
            if (Password != Cpassword) error += "passwords don't match, ";
            if (DatumRodjenja == null) error += "birth date is not set, ";
            if (Sport == null || Sport.Count() == 0) error += "sport is not selected, ";
            if (Slika == null) error += "image is not uploaded, ";
            if (_tipKorisnika == 0) error += "user type is not selected";

            return error;
        }
        public void OznaciMenadzera()
        {
            _tipKorisnika = 1;
        }
        public void OznaciTrenera()
        {
            _tipKorisnika = 2;
        }
        public void OznaciIgraca()
        {
            _tipKorisnika = 3;
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        public string Cpassword
        {
            get
            {
                return _cpassword;
            }

            set
            {
                _cpassword = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cpassword)));
            }
        }

        public DateTimeOffset DatumRodjenja
        {
            get
            {
                return _datumRodjenja;
            }

            set
            {
                _datumRodjenja = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DatumRodjenja)));
            }
        }

        public string Sport
        {
            get
            {
                return _sport;
            }

            set
            {
                _sport = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sport)));
            }
        }

        public byte[] Slika
        {
            get
            {
                return _slika;
            }

            set
            {
                _slika = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slika)));
            }
        }
    }
}

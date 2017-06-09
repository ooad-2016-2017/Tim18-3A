using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Models;
using Windows.UI.Xaml.Controls;

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
        private DateTime _datumRodjenja;
        private string _sport;
        private byte[] _slika;
        private int _tipKorisnika;
        public KorisnikVM korisnik;

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
                        korisnik = new MenadzerVM(Username, Password, Email, Slika, DatumRodjenja);
                        break;
                    case 2:
                        korisnik = new TrenerVM(Username, Password, Email, Slika, DatumRodjenja);
                        break;
                    case 3:
                        korisnik = new IgracVM(Username, Password, Email, Slika, DatumRodjenja);
                        break;
                }
                return korisnik;
            }
            return null;
        }
        public string ProvjeriParametre()
        {
            string error = "";

            if (Email == null || Email.Count() == 0) error += "email not entered, ";
            if (Username.Count() == 0 || Username == null) error += "username not entered, ";
            if (Password.Count() == 0 || Password == null) error += "password not entered, ";
            if (Cpassword.Count() == 0 || Cpassword == null) error += "password confirmation not entered";
            if (Password != Cpassword) error += "passwords don't match, ";
            if (DatumRodjenja == null) error += "birth date is not set, ";
            if (Sport.Count() == 0 || Sport == null) error += "sport is not selected, ";
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

        public DateTime DatumRodjenja
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

using System;
using Windows.UI.Xaml.Media.Imaging;

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

        public KorisnikVM(string username, string password, string email, byte[] slika, DateTime datum)
        {
            Username = username;
            Password = password;
            Email = email;
            Slika = slika;
            DatumRodjenja = datum;
        }
        public KorisnikVM() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Models;
using Windows.UI.Xaml.Controls;

namespace Teamer.ViewModel
{
    class MenadzerVM : KorisnikVM
    {
        public MenadzerVM(string username, string password, string email, byte[] slika, DateTime datum, string sport) 
            : base(username, password, email, slika, datum, sport) { }
        public MenadzerVM() : base() { }

        public List<Tim> Timovi { get; set; }
    }
}

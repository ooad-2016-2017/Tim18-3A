using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Models;
using Windows.UI.Xaml.Controls;

namespace Teamer.ViewModel
{
    class IgracVM : KorisnikVM
    {
        public Tim Tim { get; set; }
        public IgracVM(string username, string password, string email, byte[] slika, DateTime datum) 
            : base(username, password, email, slika, datum) { }
        public IgracVM() : base() { }
    }
}

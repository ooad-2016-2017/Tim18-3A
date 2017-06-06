using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamer.Models;

namespace Teamer.ViewModel
{
    class MenadzerVM : KorisnikVM
    {
        public List<Tim> Timovi { get; set; }
    }
}

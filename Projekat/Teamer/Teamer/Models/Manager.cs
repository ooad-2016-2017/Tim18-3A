using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Manager
    {
        int ManagerID { get; set; }
        List<Tim> Timovi { get; set; }
    }
}

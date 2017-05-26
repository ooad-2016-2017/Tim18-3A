using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Tim
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimID { get; set; }
        [Required]
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        public int? TrenerID { get; set; }
        public Trener Trener { get; set; }

        public ICollection<Igrac> Igraci { get; set; }

        public int ManagerID { get; set; }
        public Menadzer Manager { get; set; }

        public ICollection<Dogadjaj> Dogadjaji { get; set; }
        public ICollection<byte[]> Galerija { get; set; }
         
    }
}

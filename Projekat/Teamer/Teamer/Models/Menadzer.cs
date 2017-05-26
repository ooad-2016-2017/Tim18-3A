using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Menadzer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenadzerID { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        public byte[] Slika { get; set; }
        public ICollection<Tim> Timovi { get; set; }
    }
}

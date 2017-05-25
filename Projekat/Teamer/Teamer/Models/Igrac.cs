﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamer.Models
{
    public class Igrac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int IgracID { get; set; }
        DateTime DatumRodjenja { get; set; }
        string Email { get; set; }
        string Ime { get; set; }
        string Prezime { get; set; }
        string Password { get; set; }
        [Required]
        string Username { get; set; }
        byte[] Slika { get; set; }
        Tim Tim { get; set; }
    }
}

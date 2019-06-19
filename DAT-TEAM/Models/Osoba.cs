using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATteam.Models
{
    public class Osoba
{
        [Key]
        public int id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime datumZaposlenja { get; set; }

        public Osoba() { }

    }
}

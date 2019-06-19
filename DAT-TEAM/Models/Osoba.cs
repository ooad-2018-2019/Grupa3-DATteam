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
        private String ime { get; set; }
        private String prezime { get; set; }
        private String username { get; set; }
        private String password { get; set; }
        private String email { get; set; }
        private DateTime datumRodjenja { get; set; }
        private DateTime datumZaposlenja { get; set; }

        public Osoba() { }

    }
}

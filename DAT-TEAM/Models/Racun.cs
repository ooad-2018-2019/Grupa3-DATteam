using DATteam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATteam.Models
{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
        public Radnik Narucilac { set; get; }
        public DateTime datumKreiranja { set; get; }
        public List<Proizvod> stavkeRacuna { set; get; }

        public Racun()
        {
        }
    }
}

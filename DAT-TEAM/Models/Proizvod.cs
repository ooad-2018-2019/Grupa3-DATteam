using System;
using System.ComponentModel.DataAnnotations;

namespace DATteam.Models
{
    public class Proizvod
    {

        public int Id { get; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Proizvodjac { get; set; }
        public double Cijena { get; set; }
        public DateTime rokTrajanja { get; set; }
        public string lijekTip { get; set; }
        public bool naRecept { get; set; }
        public int kolicnia { get; set; }

        public Proizvod()
        {
        }

        public Proizvod(string naziv, int id, string opis, string proizvodjac, double cijena, DateTime rok, string tip, bool recept, int kol)
        {
            Naziv = naziv;
            Id = id;
            Opis = opis;
            Proizvodjac = proizvodjac;
            Cijena = cijena;
            rokTrajanja = rok;
            lijekTip = tip;
            naRecept = recept;
            kolicnia = kol;
        }


    }
}

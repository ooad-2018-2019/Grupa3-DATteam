using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATteam.Models
{
    public class Osoba
{
        private int id;
        private String ime;
        private String prezime;
        private String username;
        private String password;
        private String email;
        private DateTime datumRodjenja;
        private DateTime datumZaposlenja;

        public Osoba() { }

        public int getID() { return id; }

        public String getIme() { return ime; }
        public void setIme(String ime) { this.ime = ime; }


        public String getPrezime() { return prezime; }
        public void setPrezime(String prezime) { this.prezime = prezime; }


        public String getUsername() { return username; }
        public void setUsername(String username) { this.username = username; }


        public DateTime getDatumRodjenja() { return datumRodjenja; }
        public void setDatumRodjenja(DateTime datumRodjenja) { this.datumRodjenja = datumRodjenja; }

        public DateTime getDatumZaposlenja() { return datumZaposlenja; }
        public void setDatumZaposlenja(DateTime datumZaposlenja) { this.datumZaposlenja = datumZaposlenja; }

    }
}

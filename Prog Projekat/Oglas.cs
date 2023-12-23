using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Projekat
{
    public abstract class Oglas
    {
        private string naziv, email_korisnika;
        private int cena, broj_lajkova;
        private DateTime datum_objave;
        private List<byte[]> slike = new List<byte[]>();
        private List<Korisnik> pregledi = new List<Korisnik>();
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public string Email_korisnika
        {
            get { return email_korisnika;}
            set { email_korisnika = value;}
        }
        public int Broj_lajkova
        {
            get { return broj_lajkova; }
            set
            {
                if(value< 0)
                {
                    throw new Exception("Broj lajkova mora biti veci od 0");
                }
                else
                 broj_lajkova = value;
            }
        }
        public int Cena
        {
            get { return cena; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cena mora biti veci od 0");
                }
                else
                    cena = value;
            }
        }
        public DateTime Datum_objave
        {
            get { return datum_objave; }
            set { datum_objave = value; }
        }
        public List<byte[]> Slike
        {
            get { return slike; }
            set { slike = value; }
        }
        public List<Korisnik> Pregledi
        {
            get { return pregledi; }
            set { pregledi = value; }
        }
        public Oglas() { }
        public Oglas(string naziv, string email_korisnika, int cena, int broj_lajkova, DateTime datum_objave, List<byte[]> slike, List<Korisnik> pregledi)
        {
            Naziv = naziv;
            Email_korisnika = email_korisnika;
            Cena = cena;
            Broj_lajkova = broj_lajkova;
            Datum_objave = datum_objave;
            Slike = slike;
            Pregledi = pregledi;
        }

        abstract public void upisUBazu();

    }
}

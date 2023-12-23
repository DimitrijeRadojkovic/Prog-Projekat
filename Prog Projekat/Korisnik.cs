using MongoDB.Bson.Serialization.Attributes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prog_Projekat
{
    [BsonIgnoreExtraElements]
    public class Korisnik
    {
        
        private string ime, prezime, email, lozinka;
        private DateTime datum_registracije, datum_prijave;
        private List<Oglas> oglasi = new List<Oglas>();
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    email = value;
                else
                    throw new Exception("Email nije validan");
            }
        }
        public string Lozinka
        {
            get { return lozinka; }
            set
            {
                if (Regex.IsMatch(value, @"^(?=.*[A-Z])(?=.*\d).{8,}$"))
                    lozinka = value;
                else
                    throw new Exception("Lozinka mora sadrzati 8 karaktera, barem jedno veliko slovo i barem jedan broj");
            }
        }
        public DateTime DatumRegistracije
        {
            get { return datum_registracije;}
            set
            {
                datum_registracije = value;
            }
        }
        public DateTime DatumPrijave
        {
            get { return datum_prijave; }
            set { datum_prijave = value; }
        }
        public List<Oglas> Oglasi
        {
            get { return oglasi; }
            set { oglasi = value; }
        }
        public Korisnik() { }
        public Korisnik(string ime, string prezime, string email, string lozinka, DateTime datum_registracije, DateTime datum_prijave, List<Oglas> oglasi)
        {
            this.ime = ime;
            this.prezime = prezime;
            Email = email;
            Lozinka = lozinka;
            this.datum_registracije = datum_registracije;
            this.datum_prijave = datum_prijave;
            this.oglasi = oglasi;
        }
        public Korisnik(StreamReader sr)
        {
            Ime = sr.ReadLine();
            Prezime= sr.ReadLine();
            Email = sr.ReadLine();
        }
        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n{3}", ime, prezime, email, datum_prijave);
        }
    }
}

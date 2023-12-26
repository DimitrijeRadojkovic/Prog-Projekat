using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Projekat
{
    [BsonIgnoreExtraElements]
    internal class AutoOglas : Oglas
    {
        private string marka, model, gorivo, karoserija;
        private int godiste, kilometraza, kubikaza, snaga;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Gorivo
        {
            get { return gorivo; }
            set
            {
                gorivo = value;
            }
        }
        public string Karoserija
        {
            get { return karoserija; }
            set { karoserija = value; }
        }
        public int Godiste
        {
            get { return godiste; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Godiste mora biti vece od 0");
                }
                else
                    godiste = value;
            }
        }
        public int Kilometraza
        {
            get { return kilometraza; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Kilometraza mora biti veca ili jednaka 0");
                }
                else
                    kilometraza = value;
            }
        }
        public int Kubikaza
        {
            get { return kubikaza; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Kubikaza mora biti veca od 0");
                }
                else
                    kubikaza = value;
            }
        }
        public int Snaga
        {
            get { return snaga; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Snaga mora biti veca od 0");
                }
                else
                    snaga = value;
            }
        }
        public AutoOglas() { }
        public AutoOglas(string naziv, string email_korisnika, int cena, List<Korisnik> lajkovi, DateTime datum_objave, List<byte[]> slike, string marka, string model, string gorivo, string karoserija, int godiste, int kilometraza, int kubikaza, int snaga):base(naziv, email_korisnika, cena, lajkovi, datum_objave, slike)
        {
            this.marka = marka;
            this.model = model;
            this.gorivo = gorivo;
            this.karoserija = karoserija;
            Godiste = godiste;
            Kilometraza = kilometraza;
            Kubikaza = kubikaza;
            Snaga = snaga;
        }
        public AutoOglas(AutoOglas other)
            : base(other.Naziv, other.Email_korisnika, other.Cena, other.Lajkovi, other.Datum_objave, other.Slike)
        {
            this.marka = other.marka;
            this.model = other.model;
            this.gorivo = other.gorivo;
            this.karoserija = other.karoserija;
            this.godiste = other.godiste;
            this.kilometraza = other.kilometraza;
            this.kubikaza = other.kubikaza;
            this.snaga = other.snaga;
        }
        public AutoOglas(string marka)
        {
            this.marka = marka;
        }

        public override void upisUBazu()
        {
            Baza.UpisiOglas(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Projekat
{
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
        public AutoOglas(string naziv, string email_korisnika, int cena, int broj_lajkova, DateTime datum_objave, List<byte[]> slike, List<Korisnik> pregledi, string marka, string model, string gorivo, string karoserija, int godiste, int kilometraza, int kubikaza, int snaga):base(naziv, email_korisnika, cena, broj_lajkova, datum_objave, slike, pregledi)
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

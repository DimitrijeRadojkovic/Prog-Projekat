using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Prog_Projekat
{
    internal class Baza
    {
        static IMongoClient client;
        static IMongoCollection<Oglas> oglasi;
        static IMongoCollection<Korisnik> korisnici;
        public static void Povezivanje()
        {
            try
            {
                client = new MongoClient("mongodb+srv://dimitrijeradojkovic8:SuperTajnaSifra@cluster0.cysxt7x.mongodb.net/?retryWrites=true&w=majority");
                string imeBaze = "OglasiKupovinaProdaja";
                string imeTabele = "oglasi";
                oglasi = client.GetDatabase(imeBaze).GetCollection<Oglas>(imeTabele);
                imeTabele = "korisnici";
                korisnici = client.GetDatabase(imeBaze).GetCollection<Korisnik>(imeTabele);

                var email = Builders<Korisnik>.IndexKeys.Ascending(k => k.Email);
                var opcije = new CreateIndexOptions { Unique = true };
                var emailUnique = new CreateIndexModel<Korisnik>(email, opcije);

                korisnici.Indexes.CreateOne(emailUnique);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void UpisiOglas(Oglas o)
        {
            try
            {
                oglasi.InsertOne(o);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void UpisiKorisnika(Korisnik k)
        {
            try
            {
                korisnici.InsertOne(k);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static Korisnik PronadjiKorisnika(string email)
        {
            try
            {
                if (korisnici.CountDocuments(Builders<Korisnik>.Filter.Empty) > 0)
                {
                    var korisnik = korisnici.Find(Builders<Korisnik>.Filter.Eq("Email", email)).ToList();
                    return new Korisnik(korisnik[0].Ime, korisnik[0].Prezime, korisnik[0].Email, korisnik[0].Lozinka, korisnik[0].DatumRegistracije, korisnik[0].DatumPrijave, korisnik[0].Oglasi);
                }
                else
                    return null;
            }
            catch(Exception e )
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static void updateDatumPrijave(string email)
        {
            try
            {
                
                    korisnici.FindOneAndUpdate(Builders<Korisnik>.Filter.Eq("Email", email), Builders<Korisnik>.Update.Set(t => t.DatumPrijave, DateTime.Now));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

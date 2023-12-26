using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
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
                client = new MongoClient("mongodb+srv://dimitrijeradojkovic8:SuperTajnaSifra@cluster0.w38u8xv.mongodb.net/?retryWrites=true&w=majority");
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
                    if (korisnik.Count > 0)
                        return new Korisnik(korisnik[0].Ime, korisnik[0].Prezime, korisnik[0].Email, korisnik[0].Lozinka, korisnik[0].DatumRegistracije, korisnik[0].DatumPrijave, korisnik[0].Oglasi, korisnik[0].SacuvaniOglasi);
                    else
                        return null;
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
        public static AutoOglas PronadjiOglas(string Id)
        {
            try
            {
                if (oglasi.CountDocuments(Builders<Oglas>.Filter.Empty) > 0)
                {
                    
                        var oglasi1 = oglasi.Find(Builders<Oglas>.Filter.Eq("_id", new ObjectId(Id))).ToList();
                    if (oglasi1.Count > 0)
                    {
                        var oglas = (AutoOglas)oglasi1[0];
                        return new AutoOglas(oglas.Naziv, oglas.Email_korisnika, oglas.Cena, oglas.Lajkovi, oglas.Datum_objave, oglas.Slike, oglas.Marka, oglas.Model, oglas.Gorivo, oglas.Karoserija, oglas.Godiste, oglas.Kilometraza, oglas.Kubikaza, oglas.Snaga);
                    }
                        
                    else
                        return null;
                }
                else
                    return null;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static Korisnik UpdateKorisnik(Korisnik updatedKorisnik)
        {
            try
            {
                var options = new FindOneAndReplaceOptions<Korisnik>
                {
                    ReturnDocument = ReturnDocument.After
                };

                var updatedDocument = korisnici.FindOneAndReplace(Builders<Korisnik>.Filter.Eq("Email", updatedKorisnik.Email), updatedKorisnik, options);
                if (updatedDocument != null)
                {
                    return updatedDocument;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static List<Oglas> PokupiOglase()
        {
            try
            {
                if (oglasi.CountDocuments(Builders<Oglas>.Filter.Empty) > 0)
                {
                    return oglasi.Find(Builders<Oglas>.Filter.Empty).ToList();
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
        public static Oglas updateOglas(Oglas o)
        {
            try
            {
                var options = new FindOneAndReplaceOptions<Oglas>
                {
                    ReturnDocument = ReturnDocument.After
                };

                var updatedOglas = oglasi.FindOneAndReplace(Builders<Oglas>.Filter.Eq("_id", new ObjectId(o.Id)), o, options);

                if(updatedOglas != null)
                {
                    return updatedOglas;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Prog_Projekat
{
    public partial class Form1 : Form
    {
        public static Korisnik ProveriCookies(Korisnik a, Label prijavaLabel, Button prijavaButton, Button profil, int sirina)
        {
            if (File.Exists("cookies.txt"))
            {
                StreamReader sr = new StreamReader("cookies.txt");
                sr.ReadLine();
                sr.ReadLine();
                sr.ReadLine();
                string datestring = sr.ReadLine();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                sr.Close();
                if (DateTime.TryParse(datestring, out DateTime date))
                {
                    if (date.AddHours(1) > DateTime.Now)
                    {
                        StreamReader str = new StreamReader("cookies.txt");
                        a.Ime = str.ReadLine();
                        a.Prezime = str.ReadLine();
                        a.Email = str.ReadLine();
                        str.Close();
                        a = Baza.PronadjiKorisnika(a.Email);
                        if (a != null)
                        {
                            prijavaLabel.Text = "Dobrodosli, " + a.Ime + " " + a.Prezime;
                            prijavaLabel.Location = new Point(sirina - prijavaLabel.Width, 31);
                            prijavaButton.Hide();
                            profil.Show();
                            return a;
                        }
                        else
                        {
                            File.Delete("cookies.txt");
                            return new Korisnik();
                        }
                    }
                    else
                    {
                        File.Delete("cookies.txt");
                        return new Korisnik();
                    }
                }
                else
                {
                    return new Korisnik();
                }
            }
            else
                return new Korisnik();
        }
        public Form1()
        {
            InitializeComponent();
        }
        Korisnik k = new Korisnik();
        AutoOglas autooglas = new AutoOglas();
        List<Oglas> sviOglasi = new List<Oglas>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Baza.Povezivanje();
            k = new Korisnik(ProveriCookies(k, prijavaLabel, prijavaButton, profil, ClientSize.Width));
            sviOglasi = Baza.PokupiOglase();
            tabControl1.SelectedTab = tabPage2;
            tabControl1.SelectedTab = tabPage1;
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava(this);
            prijava.Show();
        }
        public void RegistracijaClosed(string ime, string prezime, string email)
        {
            if (ime != null && prezime != null && email != null)
            {
                k = Baza.PronadjiKorisnika(email);
                if(k != null)
                {
                    prijavaLabel.Text = "Dobrodosli, " + ime + " " + prezime;
                    prijavaLabel.Location = new Point(ClientSize.Width - prijavaLabel.Width, 31);
                    prijavaButton.Hide();
                    profil.Show();
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Text == "Dodaj oglas")
            {
                if (k.Ime != null)
                {
                    label2.Hide();
                    kategorija.Show();
                    label3.Show();
                }
                else
                {
                    prijavaButton_Click(sender, e);
                    kategorija.Hide();
                    label3.Hide();
                }
            }
            else if(tabControl1.SelectedTab.Text == "Pocetna")
            {
                sviOglasi = Baza.PokupiOglase();
                MessageBox.Show(k.ToString());
                if (sviOglasi != null && sviOglasi.Count > 0 && k.Ime != "")
                {
                    foreach(Oglas o in sviOglasi)
                    {
                        int br = 0;
                        //MessageBox.Show("ovo je iz svih oglasa " + o.Lajkovi[k.Email].ToString());

                        Panel p = new Panel();
                        p.Width = ClientSize.Width;
                        p.Height = 150;

                        PictureBox pb = new PictureBox();
                        pb.Location = new Point(30, 25);
                        pb.Size = new Size(200, 100);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Image = BajtoviUSliku(o.Slike[0]);

                        Label l = new Label();
                        l.Text = o.Naziv;
                        l.Location = new Point(250, 70);
                        l.Size = new Size(200, 100);
                        l.Font = new Font("Arial", 12, FontStyle.Bold);

                        Label l1 = new Label();
                        l1.Text = o.Cena.ToString() + " €";
                        l1.Location = new Point(500, 70);
                        l1.Size = new Size(100, 100);
                        l1.Font = new Font("Arial", 12, FontStyle.Bold);

                        Label l2 = new Label();
                        l2.Text = o.Id;
                        l2.Hide();

                        Label l3 = new Label();
                        if (o.Lajkovi.ContainsKey(k.Email))
                        {
                            l3.Text = ((bool)o.Lajkovi[k.Email]) ? "Ukloni iz sacuvanih" : "Sacuvaj oglas";
                        }
                        else
                        {
                            l3.Text = "Sacuvaj oglas";
                        }
                        l3.Location = new Point(580, 40);

                        Button like = new Button();
                        like.Location = new Point(600, 60);
                        like.Size = new Size(30, 30);
                        foreach (string kljuc in o.Lajkovi.Keys)
                        {
                            if ((bool)o.Lajkovi[kljuc] == true)
                                br++;
                        }
                        like.Text = br.ToString();
                        MessageBox.Show("ovo su korisnici.sacuvaniOglasi " + k.SacuvaniOglasi.Count);

                        //OVDE JE PROBLEM
                        if (o.Lajkovi.ContainsKey(k.Email))
                        {
                            if ((bool)o.Lajkovi[k.Email])
                            {
                                like.BackColor = Color.Red;
                                like.Click += (s, eventArgs) => updateLike(s, eventArgs, o, false, like);
                            }
                            else
                            {
                                like.BackColor = Color.White;
                                like.Click += (s, eventArgs) => updateLike(s, eventArgs, o, true, like);
                            }
                        }
                        else
                        {
                            like.BackColor = Color.White;
                            like.Click += (s, eventArgs) => updateLike(s, eventArgs, o, true, like);
                        }

                        Button b = new Button();
                        b.Location = new Point(650, 60);
                        b.Size = new Size(100, 30);
                        b.Text = "Vidi oglas";
                        b.Font = new Font("Arial", 12, FontStyle.Bold);
                        b.Click += (s, eventArgs) => otvoriOglas(o.Id);

                        p.Controls.Add(pb);
                        p.Controls.Add(l);
                        p.Controls.Add(l1);
                        p.Controls.Add(l2);
                        p.Controls.Add(b);
                        p.Controls.Add(like);
                        p.Controls.Add(l3);
                        tabPage1.Controls.Add(p);
                    }
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tabControl1.Width = this.ClientSize.Width;
            tabControl1.Height = this.ClientSize.Height;
        }

        private void kategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategorija.Hide();
            label3.Hide();
            panel2.Show();
            if(kategorija.SelectedItem.ToString() == "Automobili")
            {
                autoOglasPanel.Show();
            }
        }

        private void dodajSlike_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string putanja in openFileDialog1.FileNames)
                {
                    Bitmap bitmap = new Bitmap(putanja);

                    byte[] bajtoviSlike = SlikaUBajtove(bitmap);

                    autooglas.Slike.Add(bajtoviSlike);

                    bitmap.Dispose();
                }
            }
        }

        private void dodajAutoOglas_Click(object sender, EventArgs e)
        {
            autooglas.Naziv = naziv.Text;
            autooglas.Email_korisnika = k.Email;
            autooglas.Cena = Convert.ToInt32(cena.Text);
            autooglas.Datum_objave = DateTime.Now;
            autooglas.Marka = markaAutoOglas.Text;
            autooglas.Model = modelAutoOglas.Text;
            autooglas.Gorivo = gorivoAutoOglas.SelectedItem.ToString();
            autooglas.Karoserija = karoserijaAutoOglas.SelectedItem.ToString();
            autooglas.Godiste = Convert.ToInt32(godisteAutoOglas.Text);
            autooglas.Kubikaza = Convert.ToInt32(kubikazaAutoOglas.Text);
            autooglas.Kilometraza = Convert.ToInt32(kilometrazaAutoOglas.Text);
            autooglas.Snaga = Convert.ToInt32(snagaAutoOglas.Text);
            
            Baza.UpisiOglas(autooglas);
            k.Oglasi.Add(autooglas);
            k = new Korisnik(Baza.UpdateKorisnik(k));
            MessageBox.Show("Oglas uspesno dodat");
            MessageBox.Show(k.ToString());
        }
        public void updateLike(object sender, EventArgs e, Oglas o, bool res, Button b)
        {
            MessageBox.Show("ovo je iz updatelike na pocetku " + k.ToString());
            if(k.Ime != null)
            {
                o.Lajkovi[k.Email] = res;
                Baza.updateOglas(o);
                MessageBox.Show("ovo je nakon promene o " + 
                o.Lajkovi[k.Email].ToString());
                int br = 0;
                if (res)
                {
                    k.SacuvaniOglasi.Add(o);
                    k = new Korisnik(Baza.UpdateKorisnik(k));
                }
                else
                {
                    k.SacuvaniOglasi.RemoveAll(s => s.Id == o.Id);
                    k = new Korisnik(Baza.UpdateKorisnik(k));
                }
                foreach(string kljuc in o.Lajkovi.Keys)
                {
                    if ((bool)o.Lajkovi[kljuc] == true)
                        br++;
                }
                b.Text = br.ToString();
                tabControl1.SelectedTab = tabPage2;
                tabControl1.SelectedTab = tabPage1;
            }
            else
                prijavaButton_Click(sender, e);
        }
        public static byte[] SlikaUBajtove(Bitmap bitmap)
        {
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return stream.ToArray();
        }
        public static Image BajtoviUSliku(byte[] byteNiz)
        {
            if (byteNiz == null || byteNiz.Length == 0)
                return null;

            MemoryStream stream = new MemoryStream(byteNiz);
            return Image.FromStream(stream);
        }
        public static bool proveriLike(Korisnik k, Oglas o)
        {
            if (k != null && o != null)
            {
                return o.Lajkovi.ContainsKey(k.Email) && (bool)o.Lajkovi[k.Email];
            }

            return false;
        }
        public void otvoriOglas(string id)
        {
            AutoOglasForm forma = new AutoOglasForm(id);
            forma.Show();
        }
    }
    
}

using System;
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
        public static void ProveriCookies(Korisnik a, Label prijavaLabel, Button prijavaButton, Button profil, int sirina)
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
                    if(date.AddHours(1) > DateTime.Now)
                    {
                       StreamReader str = new StreamReader("cookies.txt");
                       a.Ime = str.ReadLine();
                       a.Prezime = str.ReadLine();
                       a.Email = str.ReadLine();
                       str.Close();
                       prijavaLabel.Text = "Dobrodosli, " + a.Ime + " " + a.Prezime;
                        prijavaLabel.Location = new Point(sirina - prijavaLabel.Width, 31);
                       prijavaButton.Hide();
                        profil.Show();
                    }
                    else
                    {
                        File.Delete("cookies.txt");
                        a.Ime = "";
                        a.Prezime = "";
                        a.Email = "";
                    }
                }

            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        Korisnik k = new Korisnik();
        private void Form1_Load(object sender, EventArgs e)
        {
            Baza.Povezivanje();
            ProveriCookies(k, prijavaLabel, prijavaButton, profil, ClientSize.Width);
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
                prijavaLabel.Text = "Dobrodosli, " + ime + " " + prezime;
                prijavaLabel.Location = new Point(ClientSize.Width - prijavaLabel.Width, 31);
                prijavaButton.Hide();
                profil.Show();
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
        }

        private void dodajSlike_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
    
}

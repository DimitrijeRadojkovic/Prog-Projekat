using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Projekat
{
    public partial class Prijava : Form
    {
        private Form1 form1;
        public Prijava(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        public string Ime
        {
            get; set;
        }
        public string Prezime
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Registracija r = new Registracija(form1);
            r.Show();
            this.Close();
        }

        private void Prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.RegistracijaClosed(Ime, Prezime, Email);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik k = Baza.PronadjiKorisnika(textBox1.Text);
            if(k != null)
            {
                if(k.Lozinka == textBox2.Text)
                {
                    Ime = k.Ime;
                    Prezime = k.Prezime;
                    Email = k.Email;
                    k.DatumPrijave = DateTime.Now;
                    k = Baza.UpdateKorisnik(k);
                    StreamWriter sw = new StreamWriter("cookies.txt", false);
                    sw.WriteLine(k.ToString());
                    sw.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pogresna lozinka!");
                }
            }
            else
            {
                MessageBox.Show("Korisnik sa ovim emailom ne postoji!");
            }
        }
    }
}

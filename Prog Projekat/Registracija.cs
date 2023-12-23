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
    public partial class Registracija : Form
    {
        private Form1 form1;
        public Registracija(Form1 form)
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik k = new Korisnik(ime.Text, prezime.Text, email.Text, lozinka.Text, DateTime.Now, DateTime.Now, null);
                Baza.UpisiKorisnika(k);
                StreamWriter sw = new StreamWriter("cookies.txt", false);
                sw.WriteLine(k.ToString());
                sw.Close();
                Ime = k.Ime;
                Prezime = k.Prezime;
                Email = k.Email;
                this.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Prijava p = new Prijava(form1);
            p.Show();
            this.Close();
        }

        private void Registracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.RegistracijaClosed(Ime, Prezime, Email);
        }
    }
}

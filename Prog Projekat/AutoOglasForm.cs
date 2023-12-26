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
    public partial class AutoOglasForm : Form
    {
        public string Id
        {
            get; set;
        }
        public AutoOglasForm(string Id)
        {
            InitializeComponent();
            MessageBox.Show(Id);
            this.Id = Id;
        }
        AutoOglas oglas = new AutoOglas();
        private void AutoOglasForm_Load(object sender, EventArgs e)
        {
            oglas = Baza.PronadjiOglas(Id);
            slika.Location = new Point(30, 25);
            slika.SizeMode = PictureBoxSizeMode.Zoom;
            slika.Image = BajtoviUSliku(oglas.Slike[0]);

        }
        public static Image BajtoviUSliku(byte[] byteNiz)
        {
            if (byteNiz == null || byteNiz.Length == 0)
                return null;

            MemoryStream stream = new MemoryStream(byteNiz);
            return Image.FromStream(stream);
        }
    }
}

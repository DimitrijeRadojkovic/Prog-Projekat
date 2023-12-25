namespace Prog_Projekat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prijavaButton = new System.Windows.Forms.Button();
            this.prijavaLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dodajSlike = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.TextBox();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kategorija = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.profil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.autoOglasPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.markaAutoOglas = new System.Windows.Forms.TextBox();
            this.modelAutoOglas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gorivoAutoOglas = new System.Windows.Forms.ComboBox();
            this.karoserijaAutoOglas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kilometrazaAutoOglas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.godisteAutoOglas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.kubikazaAutoOglas = new System.Windows.Forms.TextBox();
            this.snagaAutoOglas = new System.Windows.Forms.TextBox();
            this.dodajAutoOglas = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.autoOglasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(713, 60);
            this.prijavaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 24);
            this.prijavaButton.TabIndex = 0;
            this.prijavaButton.Text = "Prijavi se";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // prijavaLabel
            // 
            this.prijavaLabel.AutoEllipsis = true;
            this.prijavaLabel.AutoSize = true;
            this.prijavaLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaLabel.Location = new System.Drawing.Point(653, 31);
            this.prijavaLabel.Name = "prijavaLabel";
            this.prijavaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prijavaLabel.Size = new System.Drawing.Size(135, 22);
            this.prijavaLabel.TabIndex = 1;
            this.prijavaLabel.Text = "Niste prijavljeni";
            this.prijavaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 85);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 400);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(796, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pocetna";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(796, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pretraga";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.kategorija);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(796, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dodaj oglas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.autoOglasPanel);
            this.panel2.Controls.Add(this.dodajSlike);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cena);
            this.panel2.Controls.Add(this.cenaLabel);
            this.panel2.Controls.Add(this.naziv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(10, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 349);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // dodajSlike
            // 
            this.dodajSlike.Location = new System.Drawing.Point(18, 183);
            this.dodajSlike.Name = "dodajSlike";
            this.dodajSlike.Size = new System.Drawing.Size(75, 23);
            this.dodajSlike.TabIndex = 5;
            this.dodajSlike.Text = "Dodaj slike";
            this.dodajSlike.UseVisualStyleBackColor = true;
            this.dodajSlike.Click += new System.EventHandler(this.dodajSlike_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Slike";
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(18, 117);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(134, 20);
            this.cena.TabIndex = 3;
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(15, 87);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(32, 14);
            this.cenaLabel.TabIndex = 2;
            this.cenaLabel.Text = "Cena";
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(18, 57);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(134, 20);
            this.naziv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Naziv oglasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label3.Location = new System.Drawing.Point(342, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izaberite kategoriju";
            // 
            // kategorija
            // 
            this.kategorija.FormattingEnabled = true;
            this.kategorija.Items.AddRange(new object[] {
            "Automobili",
            "Racunari i oprema",
            "Drugo"});
            this.kategorija.Location = new System.Drawing.Point(345, 163);
            this.kategorija.Name = "kategorija";
            this.kategorija.Size = new System.Drawing.Size(121, 22);
            this.kategorija.TabIndex = 1;
            this.kategorija.Visible = false;
            this.kategorija.SelectedIndexChanged += new System.EventHandler(this.kategorija_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Morate se prijaviti da biste dodali oglas!";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 50);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 77);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oglasi - kupovina i prodaja";
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(713, 61);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(75, 23);
            this.profil.TabIndex = 5;
            this.profil.Text = "Moj profil";
            this.profil.UseVisualStyleBackColor = true;
            this.profil.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp\"";
            this.openFileDialog1.Multiselect = true;
            // 
            // autoOglasPanel
            // 
            this.autoOglasPanel.Controls.Add(this.dodajAutoOglas);
            this.autoOglasPanel.Controls.Add(this.snagaAutoOglas);
            this.autoOglasPanel.Controls.Add(this.kubikazaAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label10);
            this.autoOglasPanel.Controls.Add(this.label11);
            this.autoOglasPanel.Controls.Add(this.kilometrazaAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label12);
            this.autoOglasPanel.Controls.Add(this.godisteAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label13);
            this.autoOglasPanel.Controls.Add(this.karoserijaAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label9);
            this.autoOglasPanel.Controls.Add(this.gorivoAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label8);
            this.autoOglasPanel.Controls.Add(this.modelAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label7);
            this.autoOglasPanel.Controls.Add(this.markaAutoOglas);
            this.autoOglasPanel.Controls.Add(this.label6);
            this.autoOglasPanel.Location = new System.Drawing.Point(189, 15);
            this.autoOglasPanel.Name = "autoOglasPanel";
            this.autoOglasPanel.Size = new System.Drawing.Size(581, 331);
            this.autoOglasPanel.TabIndex = 6;
            this.autoOglasPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marka";
            // 
            // markaAutoOglas
            // 
            this.markaAutoOglas.Location = new System.Drawing.Point(18, 42);
            this.markaAutoOglas.Name = "markaAutoOglas";
            this.markaAutoOglas.Size = new System.Drawing.Size(127, 20);
            this.markaAutoOglas.TabIndex = 1;
            // 
            // modelAutoOglas
            // 
            this.modelAutoOglas.Location = new System.Drawing.Point(18, 107);
            this.modelAutoOglas.Name = "modelAutoOglas";
            this.modelAutoOglas.Size = new System.Drawing.Size(127, 20);
            this.modelAutoOglas.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gorivo";
            // 
            // gorivoAutoOglas
            // 
            this.gorivoAutoOglas.FormattingEnabled = true;
            this.gorivoAutoOglas.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Benzin + Gas(TNG)",
            "Elektricni pogon"});
            this.gorivoAutoOglas.Location = new System.Drawing.Point(18, 168);
            this.gorivoAutoOglas.Name = "gorivoAutoOglas";
            this.gorivoAutoOglas.Size = new System.Drawing.Size(121, 22);
            this.gorivoAutoOglas.TabIndex = 5;
            // 
            // karoserijaAutoOglas
            // 
            this.karoserijaAutoOglas.FormattingEnabled = true;
            this.karoserijaAutoOglas.Items.AddRange(new object[] {
            "Limuzina",
            "Kupe",
            "Hecbek",
            "Karavan",
            "Kabriolet",
            "Monovolumen"});
            this.karoserijaAutoOglas.Location = new System.Drawing.Point(18, 243);
            this.karoserijaAutoOglas.Name = "karoserijaAutoOglas";
            this.karoserijaAutoOglas.Size = new System.Drawing.Size(121, 22);
            this.karoserijaAutoOglas.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "Karoserija";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Snaga(KS)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Kubikaza";
            // 
            // kilometrazaAutoOglas
            // 
            this.kilometrazaAutoOglas.Location = new System.Drawing.Point(268, 110);
            this.kilometrazaAutoOglas.Name = "kilometrazaAutoOglas";
            this.kilometrazaAutoOglas.Size = new System.Drawing.Size(127, 20);
            this.kilometrazaAutoOglas.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 14);
            this.label12.TabIndex = 10;
            this.label12.Text = "Kilometraza";
            // 
            // godisteAutoOglas
            // 
            this.godisteAutoOglas.Location = new System.Drawing.Point(268, 45);
            this.godisteAutoOglas.Name = "godisteAutoOglas";
            this.godisteAutoOglas.Size = new System.Drawing.Size(127, 20);
            this.godisteAutoOglas.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 14);
            this.label13.TabIndex = 8;
            this.label13.Text = "Godiste";
            // 
            // kubikazaAutoOglas
            // 
            this.kubikazaAutoOglas.Location = new System.Drawing.Point(268, 171);
            this.kubikazaAutoOglas.Name = "kubikazaAutoOglas";
            this.kubikazaAutoOglas.Size = new System.Drawing.Size(127, 20);
            this.kubikazaAutoOglas.TabIndex = 15;
            // 
            // snagaAutoOglas
            // 
            this.snagaAutoOglas.Location = new System.Drawing.Point(268, 248);
            this.snagaAutoOglas.Name = "snagaAutoOglas";
            this.snagaAutoOglas.Size = new System.Drawing.Size(127, 20);
            this.snagaAutoOglas.TabIndex = 16;
            // 
            // dodajAutoOglas
            // 
            this.dodajAutoOglas.Location = new System.Drawing.Point(437, 226);
            this.dodajAutoOglas.Name = "dodajAutoOglas";
            this.dodajAutoOglas.Size = new System.Drawing.Size(118, 39);
            this.dodajAutoOglas.TabIndex = 17;
            this.dodajAutoOglas.Text = "Dodaj oglas";
            this.dodajAutoOglas.UseVisualStyleBackColor = true;
            this.dodajAutoOglas.Click += new System.EventHandler(this.dodajAutoOglas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.prijavaLabel);
            this.Controls.Add(this.prijavaButton);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Oglasi - kupovina i prodaja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.autoOglasPanel.ResumeLayout(false);
            this.autoOglasPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Label prijavaLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profil;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodajSlike;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel autoOglasPanel;
        private System.Windows.Forms.TextBox markaAutoOglas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelAutoOglas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gorivoAutoOglas;
        private System.Windows.Forms.ComboBox karoserijaAutoOglas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox kilometrazaAutoOglas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox godisteAutoOglas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox snagaAutoOglas;
        private System.Windows.Forms.TextBox kubikazaAutoOglas;
        private System.Windows.Forms.Button dodajAutoOglas;
    }
}


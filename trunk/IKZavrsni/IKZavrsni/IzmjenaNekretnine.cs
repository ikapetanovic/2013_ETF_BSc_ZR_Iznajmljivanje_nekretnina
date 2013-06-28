using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBConnection;

namespace IKZavrsni
{
    public partial class IzmjenaNekretnine : Form
    {
        private Nekretnina n;

        public IzmjenaNekretnine()
        {
            InitializeComponent();
        }

        public IzmjenaNekretnine(Nekretnina nekretnina)
        {
            InitializeComponent();
            n = nekretnina;
        }

        private void IzmjenaNekretnine_Load(object sender, EventArgs e)
        {
            vrstaNekretnineComboBox.SelectedItem = n.VrstaNekretnine;
            nazivTextBox.Text = n.Naziv;
            adresaTextBox.Text = n.Adresa;
            lokacijaTextBox.Text = n.Lokacija;
            gradTextBox.Text = n.Grad;
            brojKvadrataNumericUpDown.Value = n.BrojKvadrata;
            godinaIzgradnjeNumericUpDown.Value = n.GodinaIzgradnje;
            nabavnaCijenaNumericUpDown.Value = Convert.ToDecimal(n.NabavnaCijena);
            biljeskeRichTextBox.Text = n.Biljeske;

            DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

            slikaPictureBox.Image = dao.VratiSlikuNekretnine(n.Id);
            toolStripStatusLabel1.Text = "";            
        }

        private void spasiNekretninuButton_Click(object sender, EventArgs e)
        {
            try
            {
                n.VrstaNekretnine = vrstaNekretnineComboBox.SelectedItem.ToString();
                n.Naziv = nazivTextBox.Text;
                n.Adresa = adresaTextBox.Text;
                n.Lokacija = lokacijaTextBox.Text;
                n.Grad = gradTextBox.Text;
                n.BrojKvadrata = Convert.ToInt16(brojKvadrataNumericUpDown.Value);
                n.GodinaIzgradnje = Convert.ToInt16(godinaIzgradnjeNumericUpDown.Value);
                n.NabavnaCijena = Convert.ToDouble(nabavnaCijenaNumericUpDown.Value);
                n.Biljeske = biljeskeRichTextBox.Text;
                Bitmap slika = (Bitmap)slikaPictureBox.Image;
                n.Slika = slika;

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                dao.AzurirajNekretninu(n);
                
                
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su ažurirani.";
            }
            catch (Exception izuzetak)
            {
                toolStripStatusLabel1.Text = izuzetak.Message + n.Id.ToString();
            } 
        }

        private void slikaPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files |*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                    slikaPictureBox.Image = new Bitmap(open.FileName);
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}

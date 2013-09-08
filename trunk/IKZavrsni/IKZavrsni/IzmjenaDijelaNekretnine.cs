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
    public partial class IzmjenaDijelaNekretnine : Form
    {
        private DioNekretnine dioNekretnine;
        private Nekretnina nekretnina;

        public IzmjenaDijelaNekretnine()
        {
            InitializeComponent();
        }

        public IzmjenaDijelaNekretnine(DioNekretnine dn, Nekretnina n)
        {
            InitializeComponent();
            dioNekretnine = dn;
            nekretnina = n;
        }

        private void IzmjenaDijelaNekretnine_Load(object sender, EventArgs e)
        {
            nekretninaTextBox.Text = nekretnina.Naziv;

            if (dioNekretnine.Sifra.Length >= 5)
            {
                if (dioNekretnine.Sifra[4].ToString() == "0")
                    spratComboBox.SelectedItem = "Prizemlje";
                else             
                    spratComboBox.SelectedItem = dioNekretnine.Sifra[4].ToString();

                if (dioNekretnine.Sifra.Length == 6)
                    prostorijaComboBox.SelectedItem = dioNekretnine.Sifra[5].ToString();
            }   

            nazivDijelaTextBox.Text = dioNekretnine.Naziv;
            vrstaNekretnineComboBox.SelectedItem = dioNekretnine.VrstaNekretnine;
            brojKvadrataDijelaTextBox.Text = dioNekretnine.BrojKvadrata.ToString();
            iznosNajmaNumericUpDown.Value = Convert.ToDecimal(dioNekretnine.IznosNajma);
            biljeskeDijelaRichTextBox.Text = dioNekretnine.Biljeske;

            DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

            slikaDijelaNekretninePictureBox.Image = dao.VratiSlikuDijelaNekretnine(dioNekretnine.Sifra);

            toolStripStatusLabel1.Text = "";  
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slikaDijelaNekretninePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files |*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                    slikaDijelaNekretninePictureBox.Image = new Bitmap(open.FileName);
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void spasiDioNekretnineButton_Click(object sender, EventArgs e)
        {
            try
            {
                dioNekretnine.Naziv = nazivDijelaTextBox.Text;
                dioNekretnine.VrstaNekretnine = vrstaNekretnineComboBox.SelectedItem.ToString();
                dioNekretnine.BrojKvadrata = Convert.ToInt32(brojKvadrataDijelaTextBox.Text);
                dioNekretnine.IznosNajma = Convert.ToDouble(iznosNajmaNumericUpDown.Value);
                dioNekretnine.Biljeske = biljeskeDijelaRichTextBox.Text;
                Bitmap slika = (Bitmap)slikaDijelaNekretninePictureBox.Image;
                dioNekretnine.Slika = slika;

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                dao.AzurirajDioNekretnine(dioNekretnine);

                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su ažurirani.";
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Podaci nisu ažurirani!";
            } 
        }
    }
}

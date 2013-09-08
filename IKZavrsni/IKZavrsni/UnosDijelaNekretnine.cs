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
    public partial class UnosDijelaNekretnine : Form
    {
        Nekretnina nekretnina;

        public UnosDijelaNekretnine()
        {
            InitializeComponent();
        }

        public UnosDijelaNekretnine(Nekretnina n)
        {
            InitializeComponent();
            nekretnina = n;
        }

        private void UnosDijelaNekretnine_Load(object sender, EventArgs e)
        {
            nekretninaTextBox.Text = nekretnina.Naziv;

            DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
            List<string> sifre = dao.VratiSifreDijelovaNekretnine(dao.VratiIdNekretnine(nekretnina.Naziv, nekretnina.Adresa, nekretnina.Grad));

            spratComboBox.Items.Add("Prizemlje");
            for (int i = 1; i < 10; i++)
                spratComboBox.Items.Add(i.ToString());

            for (int i = 1; i < 10; i++)
                prostorijaComboBox.Items.Add(i.ToString());


            for (int i = 0; i < sifre.Count(); i++)
                if (sifre[i].Count() > 4)
                {
                    if (sifre[i][4].ToString() == "0")
                        spratComboBox.Items.Remove("Prizemlje");
                    else
                        spratComboBox.Items.Remove(sifre[i][4].ToString());
                }

            for (int i = 0; i < sifre.Count(); i++)
                if (sifre[i].Count() > 5)
                    prostorijaComboBox.Items.Remove(sifre[i][5].ToString());


        }

        private void spasiDioNekretnineButton_Click(object sender, EventArgs e)
        {
            try
            {                
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                int idNekretnine = dao.VratiIdNekretnine(nekretnina.Naziv, nekretnina.Adresa, nekretnina.Grad);

                if (idNekretnine > -1) // vidi DAO za VratiIdNekretnine(...)
                {
                    string sifra = "";

                    if (idNekretnine / 10 < 1) // jednocifren broj
                    {
                        sifra += "000" + idNekretnine.ToString();
                    }
                    else if (idNekretnine / 10 < 10) // dvocifren
                    {
                        sifra += "00" + idNekretnine.ToString();
                    }
                    else if (idNekretnine / 10 < 100) // trocifren
                    {
                        sifra += "0" + idNekretnine.ToString();
                    }
                    else if (idNekretnine / 10 < 1000) // cetverocifren
                    {
                        sifra += idNekretnine.ToString();
                    }
                    

                    if (spratComboBox.SelectedIndex != -1)
                    {
                        String sifraSprat = spratComboBox.SelectedItem.ToString();
                        if (sifraSprat == "Prizemlje")
                            sifra += "0";
                        else
                            sifra += sifraSprat;

                        spratComboBox.Items.RemoveAt(spratComboBox.SelectedIndex);

                        if (prostorijaComboBox.SelectedIndex != -1)
                        {
                            sifra += prostorijaComboBox.SelectedItem.ToString();
                            prostorijaComboBox.Items.RemoveAt(prostorijaComboBox.SelectedIndex);
                        }
                    }
                    
                    DioNekretnine dn = new DioNekretnine(sifra, nazivDijelaTextBox.Text, vrstaNekretnineComboBox.SelectedItem.ToString(), "Slobodno", biljeskeDijelaRichTextBox.Text);
                    Bitmap slika = (Bitmap)slikaDijelaNekretninePictureBox.Image;
                    dn.Slika = slika;                    

                    if (brojKvadrataDijelaTextBox.Text != "")
                        dn.BrojKvadrata = Convert.ToInt32(brojKvadrataDijelaTextBox.Text);

                    dn.IznosNajma = Convert.ToDouble(iznosNajmaNumericUpDown.Value);

                    dao.UnesiDioNekretnine(dn, idNekretnine);

                    statusStrip1.BackColor = Color.White;
                    toolStripStatusLabel1.ForeColor = Color.Green;
                    toolStripStatusLabel1.Text = "Podaci su spašeni.";                    
                }
                else
                {
                    statusStrip1.BackColor = Color.White;
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Podaci nisu spašeni!";
                }
            }
            catch (Exception izuzetak)
            {
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = izuzetak.Message;
            }        
                        
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

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

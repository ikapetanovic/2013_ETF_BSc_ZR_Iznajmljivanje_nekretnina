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
    public partial class UnosNekretnine : Form
    {
        Nekretnina n;

        public UnosNekretnine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unesi_Click(object sender, EventArgs e)
        {         
        }

        private void Nekretnina_Load(object sender, EventArgs e)
        {
            nazivTextBox.Focus();
        }

        private void dodajSlikuTabPage_Enter(object sender, EventArgs e)
        {
            
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            
        }

        private void slikaPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files |*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                    slikaNekretninePictureBox.Image = new Bitmap(open.FileName);
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void spasiNekretninu_Click(object sender, EventArgs e)
        {
            try
            {
                
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                n = new Nekretnina(nazivTextBox.Text, adresaTextBox.Text, lokacijaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text);
                
                Bitmap slika = (Bitmap)slikaNekretninePictureBox.Image;
                n.Slika = slika;

                if(brojKvadrataMaskedTextBox.Text != "")
                    n.BrojKvadrata = Convert.ToInt32(brojKvadrataMaskedTextBox.Text);

                if (godinaIzgradnjeMaskedTextBox.Text != "")
                    n.GodinaIzgradnje = Convert.ToInt32(godinaIzgradnjeMaskedTextBox.Text);

                if (nabavnaCijenaMaskedTextBox.Text != "")
                    n.NabavnaCijena = Convert.ToDouble(nabavnaCijenaMaskedTextBox.Text);

                dao.UnesiNekretninu(n);
                dao.ZatvoriKonekciju();
                

                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su spašeni.";

            }
            catch (Exception)
            {                
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Podaci nisu spašeniQ";
            }
        }

        private void izadjiButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izadjiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spasiDioNekretnineButton_Click(object sender, EventArgs e)
        {
            try
            {                
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                int idNekretnine = dao.VratiIdNekretnine(nazivTextBox.Text, adresaTextBox.Text, gradTextBox.Text);

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
                    Bitmap slika = (Bitmap)slikaNekretninePictureBox.Image;
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

        private void dioZaIznajmljivanjeTabPage_Enter(object sender, EventArgs e)
        {
            nekretninaTextBox.Text = nazivTextBox.Text;
            statusStrip1.BackColor = Color.Transparent;
            toolStripStatusLabel1.ForeColor = Color.Transparent;
            toolStripStatusLabel1.Text = "";
        }

        private void dioZaIznajmljivanjeTabPage_Enter(object sender, EventArgs e, Nekretnina n)
        {       
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
    }
}

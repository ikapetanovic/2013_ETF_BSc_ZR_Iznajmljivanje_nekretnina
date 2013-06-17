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
        public UnosNekretnine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unesi_Click(object sender, EventArgs e)
        {
            
            try
            {

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                Nekretnina n = new Nekretnina(vrstaNekretnineComboBox.SelectedItem.ToString(), nazivTextBox.Text, adresaTextBox.Text, lokacijaTextBox.Text, gradTextBox.Text, Convert.ToInt16(brojKvadrataNumericUpDown.Value), Convert.ToInt16(godinaIzgradnjeNumericUpDown.Value), Convert.ToDouble(nabavnaCijenaNumericUpDown.Value), biljeskeRichTextBox.Text);
                Bitmap slika = (Bitmap)slikaPictureBox.Image;
                n.Slika = slika;

                dao.DodajNekretninu(n);

                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su spašeni.";

            }
            catch (Exception)
            {
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Podaci nisu spašeni!";
            }
            
        }

        private void Nekretnina_Load(object sender, EventArgs e)
        {

        }

        private void dodajSlikuTabPage_Enter(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
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

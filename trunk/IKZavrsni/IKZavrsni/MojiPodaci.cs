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
    public partial class MojiPodaci : Form
    {
        string korisnickoIme3;

        public MojiPodaci()
        {
            InitializeComponent();
        }

        public MojiPodaci(string korisnickoIme4)
        {
            InitializeComponent();
            korisnickoIme3 = korisnickoIme4;

        }

        private void spasi_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (ime.Text.Length < 1 || prezime.Text.Length < 1 || fiksniTelefon.Text.Length < 1 || adresa.Text.Length < 1 || grad.Text.Length < 1 || korisnickoIme.Text.Length < 1 || lozinka.Text.Length < 1)
                {
                    toolStripStatusLabel1.Text = "Popunite polja.";

                }
                else
                {
                    Korisnik k = new Korisnik(ime.Text, prezime.Text, fiksniTelefon.Text, mobilniTelefon.Text, email.Text, adresa.Text, grad.Text, korisnickoIme.Text, lozinka.Text);

                    // provjeri podatke!
                    DAO dao = new DAO("localhost", "ikzavrsni", "root", "");
                                       
                    //int id = dao.VratiUserID(korisnickoIme.Text, lozinka.Text);
                    dao.AzurirajKorisnika(k, 1);

                    toolStripStatusLabel1.Text = "Podaci su spašeni.";
                }               

            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }           
            
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MojiPodaci_Load(object sender, EventArgs e)
        {

            /*
            MessageBox.Show("Dot Net Perls is awesome.1");           
            DAO dao = new DAO("localhost", "ikzavrsni", "root", "");

            MessageBox.Show(korisnickoIme3);
            
            Korisnik k = dao.VratiKorisnika(korisnickoIme3);
            MessageBox.Show("Dot Net Perls is awesome.3");
            ime.Text = k.Ime;
            MessageBox.Show("Dot Net Perls is awesome.4");
            toolStripStatusLabel1.Text = k.Ime.ToString();
             */
            
            
        }
        
    }
}

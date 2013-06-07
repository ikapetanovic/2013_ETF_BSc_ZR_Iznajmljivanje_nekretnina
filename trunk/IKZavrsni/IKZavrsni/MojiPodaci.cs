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

                    DAO dao = new DAO("localhost", "ikzavrsni", "root", "");
                    dao.AzurirajKorisnika(k, 1);

                    toolStripStatusLabel1.ForeColor = Color.Green;
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
            DAO dao = new DAO("localhost", "ikzavrsni", "root", "");

            try
            {
                Korisnik k = dao.VratiKorisnika(korisnickoIme3);
                
                ime.Text = k.Ime;
                prezime.Text = k.Prezime;
                fiksniTelefon.Text = k.FiksniTelefon;
                mobilniTelefon.Text = k.MobilniTelefon;
                email.Text = k.Email;
                adresa.Text = k.Adresa;
                grad.Text = k.Grad;
                korisnickoIme.Text = k.KorisnickoIme;
                lozinka.Text = k.Lozinka;
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            } 
            
        }


        
    }
}

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
    public partial class Prijava : Form
    {
        

        public Prijava()
        {
            InitializeComponent();
        }

        private void uredu_Click(object sender, EventArgs e)
        {            
            string korisnik = korisnickoIme.Text;
            string sifra = lozinka.Text;
           
            try
            {
                // Provjeriti podatke! Fino ovo poslije srediti.
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                

                if (dao.ProvjeriPristup(korisnik, sifra))
                {
                    Izbornik meni = new Izbornik(korisnik);
                    meni.Show();
                    //this.Hide();
                }
                else
                {
                    statusStrip1.BackColor = Color.White;
                    toolStripStatusLabel1.Text = "Neovlašten pristup.";
                }
                              
                
            }
            catch (Exception)
            {
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.Text = "Neovlašten pristup.";
            }                      
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


    }
}

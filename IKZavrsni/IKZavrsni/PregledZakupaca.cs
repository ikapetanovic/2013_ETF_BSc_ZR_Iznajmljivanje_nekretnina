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
    public partial class PregledZakupaca : Form
    {        
        private List<Student> studenti;
        private List<Ostali> ostali;
        private List<PravnoLice> pravnaLica;

        public PregledZakupaca()
        {
            InitializeComponent();
            
            studenti = new List<Student>();
            ostali = new List<Ostali>();
            pravnaLica = new List<PravnoLice>();
        }

        private void PregledZakupaca_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "";
                ListViewItem temp = new ListViewItem();

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                
                studenti = dao.DajSveStudente();
                ostali = dao.DajSveOstale();
                pravnaLica = dao.DajSvaPravnaLica();

                foreach (Student s in studenti)
                {
                    temp = fizickaLicaListView.Items.Add(s.Ime);
                    temp.SubItems.Add(s.Prezime);
                    temp.SubItems.Add(s.BrojTelefona);
                    temp.SubItems.Add(s.Grad);

                    temp.SubItems.Add(s.Fakultet);
                }

                foreach (Ostali o in ostali)
                {
                    temp = fizickaLicaListView.Items.Add(o.Ime);
                    temp.SubItems.Add(o.Prezime);
                    temp.SubItems.Add(o.BrojTelefona);
                    temp.SubItems.Add(o.Grad);

                    temp.SubItems.Add(o.NazivFirme);
                }

                foreach (PravnoLice pl in pravnaLica)
                {
                    temp = pravnaLicaListView.Items.Add(pl.NazivPravnogLica);
                    temp.SubItems.Add(pl.Adresa);
                    temp.SubItems.Add(pl.OvlastenaOsoba);
                    temp.SubItems.Add(pl.BrojTelefona);
                }
            }
            catch (Exception izuzetak)
            {
                toolStripStatusLabel1.Text = izuzetak.Message;
            }
        }
    }
}

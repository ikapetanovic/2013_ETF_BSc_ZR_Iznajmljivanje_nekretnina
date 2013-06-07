using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBConnection;
using System.Collections; // ArrayList

namespace IKZavrsni
{
    public partial class VrsteRashoda : Form
    {
        private List<VrstaRashoda> vrsteRashoda;

        public VrsteRashoda()
        {
            InitializeComponent();
            vrsteRashoda = new List<VrstaRashoda>();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            try
            {

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "");

                VrstaRashoda vr = new VrstaRashoda(nazivDodaj.Text, Convert.ToDouble(cijenaDodaj.Value));
                dao.DodajVrstuRashoda(vr);

                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su spašeni u bazu.";
            }
            catch (Exception)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Podaci nisu spašeni!";
            }
            
        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            try
            {

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "");

                VrstaRashoda vr = new VrstaRashoda(nazivPromjena.Text, Convert.ToDouble(cijenaPromjena.Value));
                dao.IzbrisiVrstuRashoda(nazivPromjena.Text);

                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su ažurirani u bazi.";
            }
            catch (Exception izuzetak)
            {
                //toolStripStatusLabel1.ForeColor = Color.Red;
                //toolStripStatusLabel1.Text = "Podaci nisu ažurirani!";
                toolStripStatusLabel1.Text = izuzetak.Message;
            }
        }

        private void izmijeni_Click(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "");

                VrstaRashoda vr = new VrstaRashoda(nazivPromjena.Text, Convert.ToDouble(cijenaPromjena.Value));
                vr.Id = dao.VratiIdVrsteRashoda(nazivPromjena.Text);
                dao.AzurirajVrstuRashoda(vr);                

                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su ažurirani u bazi.";
            }
            catch (Exception izuzetak)
            {
                //toolStripStatusLabel1.ForeColor = Color.Red;
                //toolStripStatusLabel1.Text = "Podaci nisu ažurirani!";
                toolStripStatusLabel1.Text = izuzetak.Message;
            }

        }

        private void VrsteRashoda_Load(object sender, EventArgs e)
        {
            listViewVrsteRashoda.Items.Clear();
            ListViewItem temp = new ListViewItem();

            DAO dao = new DAO("localhost", "ikzavrsni", "root", "");

            vrsteRashoda = dao.VratiVrsteRashoda();
            
            foreach (VrstaRashoda vr in vrsteRashoda)
            {
                temp = listViewVrsteRashoda.Items.Add(vr.Naziv);
                temp.SubItems.Add(vr.Cijena.ToString());
            }
             
            
        }

        private void listViewVrsteRashoda_ItemActivate(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewVrsteRashoda.Items.Count; i++)
                if (listViewVrsteRashoda.Items[i].Selected == true)
                {
                    foreach (VrstaRashoda vr in vrsteRashoda)
                        if (vr.Naziv == listViewVrsteRashoda.Items[i].Text)
                        {
                            nazivPromjena.Text = vr.Naziv;
                            nazivPromjena.ReadOnly = false;
                            //cijenaPromjena.Value = vr.Cijena;
                            cijenaPromjena.ReadOnly = false;
                            return;

                        }
                }
        }
    }
}

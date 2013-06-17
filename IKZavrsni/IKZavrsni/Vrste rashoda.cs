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
        ListViewItem lvi;
        VrstaRashoda vrstaRashodaTmp;

        public VrsteRashoda()
        {
            InitializeComponent();
            vrsteRashoda = new List<VrstaRashoda>();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            try
            {

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                VrstaRashoda vr = new VrstaRashoda(nazivDodaj.Text, Convert.ToDouble(cijenaDodaj.Value));
                dao.DodajVrstuRashoda(vr);

                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su spašeni u bazu.";

                lvi = listViewVrsteRashoda.Items.Add(nazivDodaj.Text);
                lvi.SubItems.Add(cijenaDodaj.Value.ToString());
                nazivDodaj.Text = "";
                cijenaDodaj.Value = 0.00M;      


            }
            catch (Exception)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Podaci nisu spašeni!";
            }
            
        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Da li ste sigurni da želite izrisati odabrani rashod iz baze podataka?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {

                    DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                    VrstaRashoda vr = new VrstaRashoda(nazivPromjena.Text, Convert.ToDouble(cijenaPromjena.Value));

                    vr.Id = dao.VratiIdVrsteRashoda(vrstaRashodaTmp.Naziv);

                    dao.IzbrisiVrstuRashoda(vr.Id);

                    listViewVrsteRashoda.Items.Clear();
                    lvi = new ListViewItem();

                    vrsteRashoda = dao.VratiVrsteRashoda();

                    foreach (VrstaRashoda vr1 in vrsteRashoda)
                    {
                        lvi = listViewVrsteRashoda.Items.Add(vr1.Naziv);
                        lvi.SubItems.Add(vr1.Cijena.ToString());
                    }

                    nazivPromjena.Text = "";
                    cijenaPromjena.Value = 0.00M;

                    toolStripStatusLabel1.ForeColor = Color.Green;
                    toolStripStatusLabel1.Text = "Podaci su ažurirani.";
                }
                catch (Exception izuzetak)
                {
                    //toolStripStatusLabel1.ForeColor = Color.Red;
                    //toolStripStatusLabel1.Text = "Podaci nisu ažurirani!";
                    toolStripStatusLabel1.Text = izuzetak.Message;
                }
            }

            
        }

        private void izmijeni_Click(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                VrstaRashoda vr = new VrstaRashoda(nazivPromjena.Text, Convert.ToDouble(cijenaPromjena.Value));
                
                vr.Id = dao.VratiIdVrsteRashoda(vrstaRashodaTmp.Naziv);

                dao.AzurirajVrstuRashoda(vr);

                listViewVrsteRashoda.Items.Clear();
                lvi = new ListViewItem();

                vrsteRashoda = dao.VratiVrsteRashoda();

                foreach (VrstaRashoda vr1 in vrsteRashoda)
                {
                    lvi = listViewVrsteRashoda.Items.Add(vr1.Naziv);
                    lvi.SubItems.Add(vr1.Cijena.ToString());
                }

                nazivPromjena.Text = "";
                cijenaPromjena.Value = 0.00M;

                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su ažurirani.";                
                

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
            lvi = new ListViewItem();

            DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

            vrsteRashoda = dao.VratiVrsteRashoda();
            
            foreach (VrstaRashoda vr in vrsteRashoda)
            {
                lvi = listViewVrsteRashoda.Items.Add(vr.Naziv);
                lvi.SubItems.Add(vr.Cijena.ToString());
            }
             
            
        }

        private void listViewVrsteRashoda_ItemActivate(object sender, EventArgs e)
        {
            DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
            vrsteRashoda = dao.VratiVrsteRashoda();

            for (int i = 0; i < listViewVrsteRashoda.Items.Count; i++)
                if (listViewVrsteRashoda.Items[i].Selected == true)
                {
                    foreach (VrstaRashoda vr in vrsteRashoda)
                        if (vr.Naziv == listViewVrsteRashoda.Items[i].Text)
                        {
                            vrstaRashodaTmp = vr;                           
                            nazivPromjena.Text = vr.Naziv;                            
                            cijenaPromjena.Value = Convert.ToDecimal(vr.Cijena); 
                            return;

                        }
                }
        }
    }
}

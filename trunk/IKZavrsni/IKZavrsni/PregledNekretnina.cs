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
    public partial class PregledNekretnina : Form
    {
        private List<Nekretnina> nekretnine;

        public PregledNekretnina()
        {
            InitializeComponent();
            nekretnine = new List<Nekretnina>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcitanjeRashoda or = new OcitanjeRashoda();
            or.Show();
        }

        private void dodajDio_Click(object sender, EventArgs e)
        {
           
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            //nekretnineListView.Items.Clear();

            if (atributPretrazivanjaComboBox.SelectedIndex == -1)
            {
                atributPretrazivanjaComboBox.Focus();
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.Text = "Morate odabrati po čemu želite pretraživati.";
                errorProvider1.SetError(atributPretrazivanjaComboBox, "Morate odabrati po čemu želite pretraživati.");
                return;
            }
            
            if (unesenoTextBox.Text.Length == 0)
            {
                unesenoTextBox.Focus();
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.Text = "Niste unijeli potrebne podatke.";
                errorProvider1.SetError(unesenoTextBox, "Niste unijeli potrebne podatke.");
                return;
            }

            try
            {
                toolStripStatusLabel1.Text = "";

                ListViewItem temp = new ListViewItem();

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                nekretnine = dao.PretraziNekretnine(atributPretrazivanjaComboBox.SelectedItem.ToString(), unesenoTextBox.Text);

                foreach (Nekretnina n in nekretnine)
                {
                    temp = nekretnineListView.Items.Add(n.Naziv);
                    temp.SubItems.Add(n.Adresa);
                    temp.SubItems.Add(n.Lokacija);
                    temp.SubItems.Add(n.VrstaNekretnine);
                }

                unesenoTextBox.ResetText();
                atributPretrazivanjaComboBox.SelectedIndex = -1;
            }
            catch (Exception izuzetak)
            {
                toolStripStatusLabel1.Text = izuzetak.Message;
            }
        }

        private void izmijeniButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nekretnineListView.Items.Count; i++)
                if (nekretnineListView.Items[i].Selected == true)
                {
                    foreach (Nekretnina n in nekretnine)
                        if (n.Naziv == nekretnineListView.Items[i].Text)
                        {
                            IzmjenaNekretnine izmjenaNek = new IzmjenaNekretnine(n);                           
                            izmjenaNek.ShowDialog();
                            return;
                        }
                }
        }

        private void nekretnineListView_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void brisiNekretninuButton_Click(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                for (int i = 0; i < nekretnineListView.Items.Count; i++)
                    if (nekretnineListView.Items[i].Selected == true)
                    {
                        foreach (Nekretnina n in nekretnine)
                            if (n.Naziv == nekretnineListView.Items[i].Text)
                            {
                                DialogResult dr = new DialogResult();
                                dr = MessageBox.Show("Da li ste sigurni da želite izrisati odabranu nekretninu iz baze podataka?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (dr == System.Windows.Forms.DialogResult.Yes)
                                {
                                    dao.IzbrisiNekretninu(n.Id);
                                    nekretnineListView.Items.Clear();
                                    atributPretrazivanjaComboBox.SelectedIndex = -1;
                                    unesenoTextBox.Clear();
                                    statusStrip1.BackColor = Color.White;
                                    toolStripStatusLabel1.ForeColor = Color.Green;
                                    toolStripStatusLabel1.Text = "Uspješno izbrisani podaci.";
                                    return;
                                }
                            }
                    }
            }
            catch (Exception)
            {                
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Podaci nisu obrisani!";
            }
        }

        private void PregledNekretnina_Load(object sender, EventArgs e)
        {
            atributPretrazivanjaComboBox.SelectedIndex = 0;
        }
    }
}

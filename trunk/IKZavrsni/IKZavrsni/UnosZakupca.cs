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
    public partial class UnosZakupca : Form
    {
        private List<DioNekretnine> dijeloviNekretnina;
        private Student s;
        private Ostali o;
        private PravnoLice pl;

        public UnosZakupca()
        {
            InitializeComponent();
            dijeloviNekretnina = new List<DioNekretnine>();
        }

        private void UnosZakupca_Load(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                dijeloviNekretnina = dao.DijeloviZaIznajmljivanje();
                for (int i = 0; i < dijeloviNekretnina.Count(); i++)
                    dijeloviZaIznajmljivanjeComboBox.Items.Add(dijeloviNekretnina[i].Naziv);
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Greška prilikom konekcije na bazu!";
            }

        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spasi_Click(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                if (fizickoPravnoTabControl.SelectedIndex == 0) // Fizičko lice
                {
                    if (studentOstaliTabControl.SelectedIndex == 0) // Student
                    {
                        s = new Student(brojTelefonaMaskedTextBox.Text, emailTextBox.Text, adresaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text, imeTextBox.Text, prezimeTextBox.Text, licnaKartaTextBox.Text, jmbgTextBox.Text, fakultetComboBox.SelectedItem.ToString(), Convert.ToInt32(godinaStudijaNumericUpDown.Value), kucniTelefonMaskedTextBox.Text, roditeljTextBox.Text);
                        dao.UnesiStudenta(s);
                    }
                    else // Ostali
                    {
                        o = new Ostali(brojTelefonaMaskedTextBox.Text, emailTextBox.Text, adresaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text, imeTextBox.Text, prezimeTextBox.Text, licnaKartaTextBox.Text, jmbgTextBox.Text, nazivFirmeTextBox.Text, adresaFirmeTextBox.Text, radnoMjestoTextBox.Text);
                        dao.UnesiOstalog(o);
                    }
                        
                }
                else // Pravno lice
                {
                    pl = new PravnoLice(brojTelefonaMaskedTextBox.Text, emailTextBox.Text, adresaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text, pidTextBox.Text, nazivPravnogLicaTextBox.Text, ovlastenaOsobaTextBox.Text);
                    dao.UnesiPravnoLice(pl);
                }

                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Podaci su spašeni.";
            }
            catch (Exception izuzetak)
            {
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = izuzetak.Message;
            }
        }
    }
}

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
        private Iznajmljivanje i;

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
                    nazivDijelaZaIznajmljivanjeComboBox.Items.Add(dijeloviNekretnina[i].Naziv);
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
                int zakupacId;
                string dioNekretnineSifra;

                if (fizickoPravnoTabControl.SelectedIndex == 0) // Fizičko lice
                {
                    DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");

                    if (studentOstaliTabControl.SelectedIndex == 0) // Student
                    {
                        s = new Student(brojTelefonaMaskedTextBox.Text, emailTextBox.Text, adresaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text, imeTextBox.Text, prezimeTextBox.Text, licnaKartaTextBox.Text, jmbgTextBox.Text, fakultetComboBox.SelectedItem.ToString(), Convert.ToInt32(godinaStudijaNumericUpDown.Value), kucniTelefonMaskedTextBox.Text, roditeljTextBox.Text);
                        dao.UnesiStudenta(s);

                        zakupacId = dao.VratiIdZakupca(brojTelefonaMaskedTextBox.Text);

                        if (zakupacId != -1)
                        {
                            dioNekretnineSifra = dao.VratiSifruDijelaNekretnine(nazivDijelaZaIznajmljivanjeComboBox.SelectedItem.ToString());
                            i = new Iznajmljivanje(zakupacId, dioNekretnineSifra, Convert.ToDateTime(pocinjeOdDateTimePicker.Text), Convert.ToDateTime(zavrsavaDoDateTimePicker.Text));
                            dao.Iznajmi(i);

                            // postavi status na Zauzeto
                            // ukloni iz comboboxa

                            //statusStrip1.BackColor = Color.White;
                            //toolStripStatusLabel1.ForeColor = Color.Green;
                            toolStripStatusLabel1.Text = "Podaci su spašeni.";
                        }
                        else
                            throw new Exception("Podaci nisu spašeni!");
                    }
                    else // Ostali
                    {
                        o = new Ostali(brojTelefonaMaskedTextBox.Text, emailTextBox.Text, adresaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text, imeTextBox.Text, prezimeTextBox.Text, licnaKartaTextBox.Text, jmbgTextBox.Text, nazivFirmeTextBox.Text, adresaFirmeTextBox.Text, radnoMjestoTextBox.Text);
                        dao.UnesiOstalog(o);
                    }
                        
                }
                else // Pravno lice
                {
                    DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                    pl = new PravnoLice(brojTelefonaMaskedTextBox.Text, emailTextBox.Text, adresaTextBox.Text, gradTextBox.Text, biljeskeRichTextBox.Text, pidTextBox.Text, nazivPravnogLicaTextBox.Text, ovlastenaOsobaTextBox.Text);
                    dao.UnesiPravnoLice(pl);
                }                
                
                
            }
            catch (Exception izuzetak)
            {
                //statusStrip1.BackColor = Color.White;
                //toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = izuzetak.Message;
            }
        }
    }
}

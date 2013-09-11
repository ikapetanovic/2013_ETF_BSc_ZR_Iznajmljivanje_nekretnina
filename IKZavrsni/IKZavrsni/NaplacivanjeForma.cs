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
    public partial class NaplacivanjeForma : Form
    {
        private List<Naplacivanje> naplacivanja;

        public NaplacivanjeForma()
        {
            InitializeComponent();
            naplacivanja = new List<Naplacivanje>();
        }

        private void racunButton_Click(object sender, EventArgs e)
        {
            // prvo da uneseš datum kada je plaćeno, pa onda generisati račun
        }

        private void Naplacivanje_Load(object sender, EventArgs e)
        {
            odDatumaDateTimePicker.Value = DateTime.Today.AddMonths(-1);
        }

        private void prikaziButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(doDatumaDateTimePicker.Value.ToString());

            try
            {
                DAO dao = new DAO("localhost", "ikzavrsni", "root", "root");
                naplacivanja = dao.DajSvaNaplacivanja(Convert.ToDateTime(odDatumaDateTimePicker.Value), Convert.ToDateTime(doDatumaDateTimePicker.Value));

                naplacivanjeListView.Items.Clear();
                ListViewItem temp = new ListViewItem();

                foreach (Naplacivanje n in naplacivanja)
                {
                    temp = naplacivanjeListView.Items.Add(n.NazivDijelaNekretnine);
                    temp.SubItems.Add(n.IznosZaNaplatu.ToString());
                }
            }
            catch (Exception)
            { 
                




            }
        }
    }
}

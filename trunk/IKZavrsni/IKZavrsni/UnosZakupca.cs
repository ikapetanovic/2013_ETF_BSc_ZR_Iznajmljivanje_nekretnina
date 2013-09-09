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
    }
}

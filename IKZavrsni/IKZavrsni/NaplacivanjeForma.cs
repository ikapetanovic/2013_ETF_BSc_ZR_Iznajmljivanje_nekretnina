using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBConnection;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            // da odabere lokaciju na koju će biti snimljeno

            string putanja;
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF files|*.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    putanja = save.FileName;

                    Document doc = new Document(iTextSharp.text.PageSize.A6, 10, 10, 42, 35);
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@putanja, FileMode.Create));
                    doc.Open();
                    Paragraph pragraf = new Paragraph("\n Vlasnik: Ime i prezime \n Fiksni telefon: (033)123-456 \n Mobilni telefon: (061)123-456 \n Email: vlasnik@mail.com \n Adresa: Ulica 11 \n Grad: Sarajevo \n \n \n Zakupac: Imenko Prezimenko \n Adresa iznajmljene nekretnine: Neka ulica 23 \n\n\n Iznos za placanje: 350 KM");

                    doc.Add(pragraf);
                    doc.Close();
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Greška!");
            }            
        }

        private void Naplacivanje_Load(object sender, EventArgs e)
        {
            odDatumaDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            doDatumaDateTimePicker.Value = DateTime.Today;
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

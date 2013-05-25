using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IKZavrsni
{
    public partial class PregledNekretnina : Form
    {
        public PregledNekretnina()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcitanjeRashoda or = new OcitanjeRashoda();
            or.Show();
        }

        private void dodajDio_Click(object sender, EventArgs e)
        {
            EvidencijaDijelaKojiSeIznajmljuje edn = new EvidencijaDijelaKojiSeIznajmljuje();
            edn.Show();
        }
    }
}

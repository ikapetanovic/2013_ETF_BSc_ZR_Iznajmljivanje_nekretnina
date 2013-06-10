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
    public partial class Izbornik : Form
    {
        string korisnickoIme1;

        public Izbornik()
        {
            InitializeComponent();
        }

       
        public Izbornik(string korisnickoIme2)
        {
            InitializeComponent();
            korisnickoIme1 = korisnickoIme2;
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nekretnina en = new Nekretnina();
            en.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledNekretnina pn = new PregledNekretnina();
            pn.Show();
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zakupac ez = new Zakupac();
            ez.Show();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PregledZakupaca pz = new PregledZakupaca();
            pz.Show();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojiPodaci mp = new MojiPodaci(korisnickoIme1);
            mp.Show();
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void vrsteRashodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VrsteRashoda vr = new VrsteRashoda();
            vr.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupRestore b = new BackupRestore();
            b.Show();
        }

        private void naplacivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Naplacivanje n = new Naplacivanje();
            n.Show();
        }
    }
}

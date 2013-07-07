using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing; // za sliku

namespace DBConnection
{
    public class DioNekretnine
    {
        private double iznosNajma;
        private string sifra, naziv, status, biljeske;
        private Bitmap slika;

        public DioNekretnine() { }

        public DioNekretnine(string sifra, string naziv, double iznosNajma, string status, string biljeske) 
        {
            this.naziv = naziv;
            this.status = status;
            this.biljeske = biljeske;
        }

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        public double IznosNajma
        {
            get { return iznosNajma; }
            set { iznosNajma = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Biljeske
        {
            get { return biljeske; }
            set { biljeske = value; }
        }

        public Bitmap Slika
        {
            get { return slika; }
            set { slika = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing; // za sliku

namespace DBConnection
{
    public class DioNekretnine
    {
        private int brojKvadrata;
        private double iznosNajma;
        private string sifra, vrstaNekretnine, naziv, status, biljeske;
        private Bitmap slika;

        public DioNekretnine() { }

        public DioNekretnine(string sifra, string naziv, string vrstaNekretnine, string status, string biljeske) 
        {
            this.sifra = sifra;
            this.naziv = naziv;
            this.vrstaNekretnine = vrstaNekretnine;
            this.status = status;
            this.biljeske = biljeske;
        }

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string VrstaNekretnine
        {
            get { return vrstaNekretnine; }
            set { vrstaNekretnine = value; }
        }

        public int BrojKvadrata
        {
            get { return brojKvadrata; }
            set { brojKvadrata = value; }
        }

        public double IznosNajma
        {
            get { return iznosNajma; }
            set { iznosNajma = value; }
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

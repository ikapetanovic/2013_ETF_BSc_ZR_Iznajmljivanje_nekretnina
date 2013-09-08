using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing; // za sliku

namespace DBConnection
{
    public class Nekretnina
    {
        private string naziv, adresa, lokacija, grad, biljeske;
        private int id, brojKvadrata, godinaIzgradnje;
        private double nabavnaCijena;
        private Bitmap slika;

        public Nekretnina() { }

        public Nekretnina(string naziv, string adresa, string lokacija, string grad, string biljeske)
        {            
            this.naziv = naziv;
            this.adresa = adresa;
            this.lokacija = lokacija;
            this.grad = grad;
            this.biljeske = biljeske;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Lokacija
        {
            get { return lokacija; }
            set { lokacija = value; }
        }

        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }

        public int BrojKvadrata
        {
            get { return brojKvadrata; }
            set { brojKvadrata = value; }
        }

        public int GodinaIzgradnje
        {
            get { return godinaIzgradnje; }
            set { godinaIzgradnje = value; }
        }

        public double NabavnaCijena
        {
            get { return nabavnaCijena; }
            set { nabavnaCijena = value; }
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class FizickoLice : Zakupac
    {
        private string ime, prezime, licnaKarta, jmbg;

        public FizickoLice() { }

        public FizickoLice(string brojTelefona, string email, string adresa, string grad, string ime, string prezime, string licnaKarta, string jmbg) : base (brojTelefona, email, adresa, grad)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.licnaKarta = licnaKarta;
            this.jmbg = jmbg;
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string LicnaKarta
        {
            get { return licnaKarta; }
            set { licnaKarta = value; }
        }

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }        

    }
}

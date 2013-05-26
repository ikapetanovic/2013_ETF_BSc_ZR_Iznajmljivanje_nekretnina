using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Korisnik
    {
        private string ime, prezime, fiksniTelefon, mobilniTelefon, email, adresa, grad, korisnickoIme, lozinka;
        
        public Korisnik() { }

        public Korisnik(string ime, string prezime, string fiksniTelefon, string mobilniTelefon, string email, string adresa, string grad, string korisnickoIme, string lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.fiksniTelefon = fiksniTelefon;
            this.mobilniTelefon = mobilniTelefon;
            this.email = email;
            this.adresa = adresa;
            this.grad = grad;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
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

        public string FiksniTelefon
        {
            get { return fiksniTelefon; }
            set { fiksniTelefon = value; }
        }

        public string MobilniTelefon
        {
            get { return mobilniTelefon; }
            set { mobilniTelefon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }

        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }       

        
    }

    
}

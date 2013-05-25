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

        public Korisnik(string i, string p, string ft, string mt, string e, string a, string g, string ki, string l)
        {
            ime = i;
            prezime = p;
            fiksniTelefon = ft;
            mobilniTelefon = mt;
            email = e;
            adresa = a;
            grad = g; 
            korisnickoIme = ki;
            lozinka = l;
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

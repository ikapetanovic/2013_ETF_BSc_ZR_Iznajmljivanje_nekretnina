using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Zakupac
    {
        private string brojTelefona, email, adresa, grad;

        public Zakupac() { }

        public Zakupac(string brojTelefona, string email, string adresa, string grad)
        {
            this.brojTelefona = brojTelefona;
            this.email = email;
            this.adresa = adresa;
            this.grad = grad;
        }

        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Zakupac
    {
        private string brojTelefona, email, adresa, grad, biljeske;
        private int id;

        public Zakupac() { }

        public Zakupac(string brojTelefona, string email, string adresa, string grad, string biljeske)
        {
            this.brojTelefona = brojTelefona;
            this.email = email;
            this.adresa = adresa;
            this.grad = grad;
            this.biljeske = biljeske;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public string Biljeske
        {
            get { return biljeske; }
            set { biljeske = value; }
        }

    }
}

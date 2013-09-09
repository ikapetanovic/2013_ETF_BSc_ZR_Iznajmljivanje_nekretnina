using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Student : FizickoLice
    {
        private string fakultet, kucniTelefon, roditelj;
        private int godinaStudija;

        public Student() { }

        public Student(string brojTelefona, string email, string adresa, string grad, string ime, string prezime, string licnaKarta, string jmbg, string fakultet, int godinaStudija, string kucniTelefon, string roditelj) : base (brojTelefona, email, adresa, grad, ime, prezime, licnaKarta, jmbg)
        {
            this.fakultet = fakultet;
            this.godinaStudija = godinaStudija;
            this.kucniTelefon = kucniTelefon;
            this.roditelj = roditelj;
        }

        public string Fakultet
        {
            get { return fakultet; }
            set { fakultet = value; }
        }

        public int GodinaStudija
        {
            get { return godinaStudija; }
            set { godinaStudija = value; }
        }

        public string KucniTelefon
        {
            get { return kucniTelefon; }
            set { kucniTelefon = value; }
        }

        public string Roditelj
        {
            get { return roditelj; }
            set { roditelj = value; }
        }
        
    }
}

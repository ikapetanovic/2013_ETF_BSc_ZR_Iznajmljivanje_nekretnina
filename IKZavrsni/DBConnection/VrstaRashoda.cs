using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class VrstaRashoda
    {

        private string naziv;
        private double cijena;
        
        public VrstaRashoda() { }

        public VrstaRashoda(string naziv, double cijena)
        {
            this.naziv = naziv;
            this.cijena = cijena;
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

    }
}

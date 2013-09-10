using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class VrstaRashoda
    {

        private int id;
        private string naziv;
        
        public VrstaRashoda() { }

        public VrstaRashoda(string naziv)
        {
            this.naziv = naziv;
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
    }
}

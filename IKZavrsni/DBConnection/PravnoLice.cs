using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class PravnoLice : Zakupac
    {
        private string pid, nazivFirme, ovlastenaOsoba;

        public PravnoLice() { }

        public PravnoLice(string brojTelefona, string email, string adresa, string grad, string pid, string nazivFirme, string ovlastenaOsoba) : base (brojTelefona, email, adresa, grad)
        {
            this.pid = pid;
            this.nazivFirme = nazivFirme;
            this.ovlastenaOsoba = ovlastenaOsoba;
        }

        public string Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        public string NazivFirme
        {
            get { return nazivFirme; }
            set { nazivFirme = value; }
        }

        public string OvlastenaOsoba
        {
            get { return ovlastenaOsoba; }
            set { ovlastenaOsoba = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class PravnoLice : Zakupac
    {
        private string pid, nazivPravnogLica, ovlastenaOsoba;

        public PravnoLice() { }

        public PravnoLice(string brojTelefona, string email, string adresa, string grad, string biljeske, string pid, string nazivPravnogLica, string ovlastenaOsoba)
            : base(brojTelefona, email, adresa, grad, biljeske)
        {
            this.pid = pid;
            this.nazivPravnogLica = nazivPravnogLica;
            this.ovlastenaOsoba = ovlastenaOsoba;
        }

        public string Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        public string NazivPravnogLica
        {
            get { return nazivPravnogLica; }
            set { nazivPravnogLica = value; }
        }

        public string OvlastenaOsoba
        {
            get { return ovlastenaOsoba; }
            set { ovlastenaOsoba = value; }
        }

    }
}

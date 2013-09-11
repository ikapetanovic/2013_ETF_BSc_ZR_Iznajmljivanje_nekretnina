using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Naplacivanje
    {
        private int id, idZakupca;
        private double iznosZaNaplatu;
        private DateTime datumOd, datumDo;
        private string sifraDijelaNekretnine, nazivDijelaNekretnine;

        public Naplacivanje() { }

        public Naplacivanje(int id, string sifraDijelaNekretnine, string nazivDijelaNekretnine, int idZakupca, double iznosZaNaplatu)
        {
            this.id = id;
            this.sifraDijelaNekretnine = sifraDijelaNekretnine;
            this.idZakupca = idZakupca;
            this.iznosZaNaplatu = iznosZaNaplatu;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdZakupca
        {
            get { return idZakupca; }
            set { idZakupca = value; }
        }

        public string SifraDijelaNekretnine
        {
            get { return sifraDijelaNekretnine; }
            set { sifraDijelaNekretnine = value; }
        }

        public string NazivDijelaNekretnine
        {
            get { return nazivDijelaNekretnine; }
            set { nazivDijelaNekretnine = value; }
        }

        public double IznosZaNaplatu
        {
            get { return iznosZaNaplatu; }
            set { iznosZaNaplatu = value; }
        }

        public DateTime DatumOd
        {
            get { return datumOd; }
            set { datumOd = value; }
        }

        public DateTime DatumDo
        {
            get { return datumDo; }
            set { datumDo = value; }
        }
    }
}

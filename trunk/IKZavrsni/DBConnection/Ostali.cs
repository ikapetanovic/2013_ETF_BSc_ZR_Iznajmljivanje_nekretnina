using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Ostali : FizickoLice
    {
        private string nazivFirme, adresaFirme, radnoMjesto;

        public Ostali() { }

        public Ostali(string brojTelefona, string email, string adresa, string grad, string ime, string prezime, string licnaKarta, string jmbg, string nazivFirme, string adresaFirme, string radnoMjesto)
            : base(brojTelefona, email, adresa, grad, ime, prezime, licnaKarta, jmbg)
        {
            this.nazivFirme = nazivFirme;
            this.adresaFirme = adresaFirme;
            this.radnoMjesto = radnoMjesto;
        }

        public string NazivFirme
        {
            get { return nazivFirme; }
            set { nazivFirme = value; }
        }

        public string AdresaFirme
        {
            get { return adresaFirme; }
            set { adresaFirme = value; }
        }

        public string RadnoMjesto
        {
            get { return radnoMjesto; }
            set { radnoMjesto = value; }
        }
    }
}

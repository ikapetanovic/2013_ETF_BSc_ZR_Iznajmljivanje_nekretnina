using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Iznajmljivanje
    {
        private DateTime pocinjeOd, zavrsavaDo;
        private int id, zakupacId;
        private string dioNekretnineId;

        public Iznajmljivanje() { }

        public Iznajmljivanje(int zakupacId, string dioNekretnineId, DateTime pocinjeOd, DateTime zavrsavaDo)
        {
            this.zakupacId = zakupacId;
            this.dioNekretnineId = dioNekretnineId;
            this.pocinjeOd = pocinjeOd;
            this.zavrsavaDo = zavrsavaDo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int ZakupacId
        {
            get { return zakupacId; }
            set { zakupacId = value; }
        }

        public string DioNekretnineId
        {
            get { return dioNekretnineId; }
            set { dioNekretnineId = value; }
        }

        public DateTime PocinjeOd
        {
            get { return pocinjeOd; }
            set { pocinjeOd = value; }
        }

        public DateTime ZavrsavaDo
        {
            get { return zavrsavaDo; }
            set { zavrsavaDo = value; }
        }

    }
}

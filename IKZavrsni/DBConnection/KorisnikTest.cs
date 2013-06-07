using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace DBConnection
{
    [TestFixture]
    public class KorisnikTest
    {
        Korisnik k;

        [SetUp]
        public void Postavi()
        {
            k = new Korisnik("Ime", "Prezime", "(033)123-456", "(061)123-456", "iprezime@mail.com", "Adresa br. 1", "Grad", "iprezime", "lozinka");
        }

        [TearDown]
        public void Brisi()
        {
            k = null;
        }

        [Test]
        public void ImeTest()
        {
            Assert.AreEqual("Ime", k.Ime);
        }

        [Test]
        public void PrezimeTest()
        {
            Assert.AreEqual("Prezime", k.Prezime);
        }

        [Test]
        public void FiksniTelefonTest()
        {
            Assert.AreEqual("(033)123-456", k.FiksniTelefon);
        }

        [Test]
        public void MobilniTelefonTest()
        {
            Assert.AreEqual("(061)123-456", k.MobilniTelefon);
        }

        [Test]
        public void EmailTest()
        {
            Assert.AreEqual("iprezime@mail.com", k.Email);
        }

        [Test]
        public void AdresaTest()
        {
            Assert.AreEqual("Adresa br. 1", k.Adresa);
        }

        [Test]
        public void GradTest()
        {
            Assert.AreEqual("Grad", k.Grad);
        }

        [Test]
        public void KorisnickoImeTest()
        {
            Assert.AreEqual("iprezime", k.KorisnickoIme);
        }

        [Test]
        public void LozinkaImeTest()
        {
            Assert.AreEqual("lozinka", k.Lozinka);
        }


    }
}

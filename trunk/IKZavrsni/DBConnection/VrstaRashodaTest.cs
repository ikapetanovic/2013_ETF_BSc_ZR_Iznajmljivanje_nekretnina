using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace DBConnection
{
    [TestFixture]
    public class VrstaRashodaTest
    {
        VrstaRashoda vr;

        [SetUp]
        public void Postavi()
        {
            vr = new VrstaRashoda("Voda", 0.25);
        }

        [TearDown]
        public void Brisi()
        {
            vr = null;
        }

        [Test]
        public void NazivTest()
        {
            Assert.AreEqual("Voda", vr.Naziv);
        }

        [Test]
        public void CijenaTest()
        {
            Assert.AreEqual(0.25, vr.Cijena);
        }


    }
}

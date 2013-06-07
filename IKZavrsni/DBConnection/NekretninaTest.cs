using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace DBConnection
{
    [TestFixture]
    public class NekretninaTest
    {
        Nekretnina n;

        [SetUp]
        public void Postavi()
        {
        }

        [TearDown]
        public void Brisi()
        {
            n = null;
        }

        [Test]
        public void VrstaTest()
        {
        }

    }
}

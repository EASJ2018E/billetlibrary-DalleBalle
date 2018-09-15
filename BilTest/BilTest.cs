using System;
using BilletOpg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletOpgTest
{
    [TestClass]
    public class BilTest
    {
        Bil _nyBil;
        
        [TestInitialize]
        public void Initialize()
        {
            _nyBil = new Bil("AB12345", new DateTime(), false);
        }
        
        [TestMethod]
        public void RigtigPris()
        {
            Assert.AreEqual(240, _nyBil.Pris());
        }

        [TestMethod]
        public void RigtigKøretøj()
        {
            Assert.AreEqual("Bil", _nyBil.Køretøj());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ForLangNummerplade()
        {
            new Bil("ABC12345", new DateTime(), false);
        }

        [TestMethod]
        public void KorrektNummerplade()
        {
            Assert.AreEqual("AB12345", _nyBil.Nummerplade);
        }

        [TestMethod]
        public void PrisMedBrobizz()
        {
            Bil brobizzBil = new Bil("AB12345", new DateTime(), true);

            Assert.AreEqual(228, brobizzBil.Pris());
        }
    }
}

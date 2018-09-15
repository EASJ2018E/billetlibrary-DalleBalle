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
            _nyBil = new Bil("AB12345", new DateTime());
        }
        
        [TestMethod]
        public void RigtigPris()
        {
            Assert.AreEqual(240, _nyBil.Pris());
        }

        [TestMethod]
        public void RigtigK�ret�j()
        {
            Assert.AreEqual("Bil", _nyBil.K�ret�j());
        }
    }
}

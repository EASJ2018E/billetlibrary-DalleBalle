using System;
using BilletOpg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletOpgTest
{
    [TestClass]
    public class MCTest
    {
        MC _nyMC;
        
        [TestInitialize]
        public void Initialize()
        {
            _nyMC = new MC("AB12345", new DateTime());
        }
        
        [TestMethod]
        public void RigtigPris()
        {
            Assert.AreEqual(125, _nyMC.Pris());
        }

        [TestMethod]
        public void RigtigKøretøj()
        {
            Assert.AreEqual("MC", _nyMC.Køretøj());
        }
    }
}

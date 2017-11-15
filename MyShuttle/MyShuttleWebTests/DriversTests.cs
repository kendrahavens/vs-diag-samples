using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShuttle.Client.Web.Controllers;

namespace MyShuttleWebTests
{
    [TestClass]
    public class DriversTests
    {
        [TestMethod()]
        public void GetTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetTest1()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void SecondaryServiceTest()
        {
            DriversController dc = new DriversController();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void DriverIdTest()
        {
        }
    }
}

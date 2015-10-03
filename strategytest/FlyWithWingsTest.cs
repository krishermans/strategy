using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace strategy
{
    [TestClass]
    public class FlyWithWingsTest
    {
        private FlyBehavior flyer;
        private ConsoleMock console;

        [TestInitialize]
        public void SetUp()
        {
            console = new ConsoleMock();
        }
        
        [TestMethod]
        public void TestFly()
        {
            flyer = new FlyWithWings();
            flyer.Fly();
            Assert.AreEqual("I'm flying!!", console.Output());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace strategy
{
    [TestClass]
    public class FlyNoWayTest
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
            flyer = new FlyNoWay();
            flyer.Fly();
            Assert.AreEqual("I can't fly", console.Output());
        }
    }
}

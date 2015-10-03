using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace strategy
{
    [TestClass]
    public class MallardDuckTest
    {
        private MallardDuck duck = null;
        private ConsoleMock console;

        [TestInitialize]
        public void SetUp()
        {
            console = new ConsoleMock();
            duck = new MallardDuck();
        }

        [TestMethod]
        public void TestDisplay()
        {
            duck.Display();
            Assert.AreEqual("I'm a real Mallard duck", console.Output());
        }

        [TestMethod]
        public void TestDuckSimulator()
        {
            duck.PerformQuack();
            Assert.AreEqual("Quack", console.Output());
            duck.PerformFly();
            Assert.AreEqual("I'm flying!!", console.Output());
        }
    }
}

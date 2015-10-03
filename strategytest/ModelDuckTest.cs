using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace strategy
{
    [TestClass]
    public class ModelDuckTest
    {
        private ModelDuck duck = null;
        private ConsoleMock console;

        [TestInitialize]
        public void SetUp()
        {
            console = new ConsoleMock();
            duck = new ModelDuck();
        }

        [TestMethod]
        public void TestMiniDuckSimulator()
        {
            duck.PerformFly();
            Assert.AreEqual("I can't fly", console.Output());

            duck.FlyBehavior = new FlyRocketPowered();
            duck.PerformFly();
            Assert.AreEqual("I'm flying with a rocket!", console.Output());
        }
    }
}

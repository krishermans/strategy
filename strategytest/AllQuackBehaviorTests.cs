using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace strategy
{
    [TestClass]
    public class AllQuackBehaviorTests
    {
        private QuackBehavior quacker = null;
        private ConsoleMock console = null;

        [TestInitialize]
        public void SetUp()
        {
            console = new ConsoleMock();
        }

        [TestMethod]
        public void TestQuack()
        {
            quacker = new SimpleQuack();
            quacker.Quack();

            Assert.AreEqual("Quack", console.Output());
        }

        [TestMethod]
        public void TestMuteQuack()
        {
            quacker = new MuteQuack();
            quacker.Quack();

            Assert.AreEqual("<< Silence >>", console.Output());
        }

        [TestMethod]
        public void TestSqueak()
        {
            quacker = new Squeak();
            quacker.Quack();

            Assert.AreEqual("Squeak", console.Output());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachine3.Tests
{
    [TestClass]
    public class MachineTests
    {
        private Machine machine;

        [TestInitialize]
        public void TestInitialize()
        {
            this.machine = new Machine();
        }

        [TestMethod]
        [TestCategory("InitialState")]
        public void InitialStateTest()
        {
            Assert.AreEqual(1, machine.State);
        }

        [TestMethod]
        [TestCategory("Commands")]
        public void CommandATest()
        {
            machine.ChangeState(1);
            Assert.AreEqual(1, machine.State);
        }

        [TestMethod]
        [TestCategory("Commands")]
        public void CommandBTest()
        {
            machine.ChangeState(2);
            Assert.AreEqual(2, machine.State);
        }

        [TestMethod]
        [TestCategory("Exceptions")]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCommandTest()
        {
            machine.ChangeState(3);
        }
    }
}

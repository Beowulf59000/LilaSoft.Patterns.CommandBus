using System;
using LilaSoft.Patterns.CommandBus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandBus.UnitTests
{
    public class IntegrationConcreteCommand : IntegrationCommand { }

    [TestClass]
    public class IntegrationCommandTest
    {
        [TestMethod]
        public void IntegrationCommand_ShouldInitializeProperties()
        {
            IntegrationCommand command = new IntegrationConcreteCommand();
            Assert.IsNotNull(command.Id);
            Assert.AreEqual(DateTime.UtcNow.Date, command.Sent.Date);
        }
    }
}

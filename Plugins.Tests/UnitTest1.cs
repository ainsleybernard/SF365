using System;
using Microsoft.Crm.Sdk.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using SF365.Plugins;

namespace Plugins.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Unit Test")]
        public void TestMethod1()
        {
            using (var pipeline = new PluginPipeline(FakeMessageNames.Create, FakeStages.PreOperation, new Microsoft.Xrm.Sdk.Entity("contact")))
            {
                var plugin = new AccountPlugin();

                try
                {
                    pipeline.Execute(plugin);
                    Assert.Fail("Execption not thrown");

                }
                catch (InvalidPluginExecutionException ex)
                {
                    Assert.IsTrue(ex.Message.Contains("Working on it"));
                }
            }
        }
    }
}

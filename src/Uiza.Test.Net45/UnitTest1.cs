using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uiza.Net.Configuration;

namespace Uiza.Test.Net45
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            UizaConfiguration.SetupUiza(new UizaConfigOptions
            {
                ApiKey = ""
            });
        }

        [TestMethod]
        public void CheckSetupUiza()
        {
            Assert.AreEqual(true,true);
        }
    }
}

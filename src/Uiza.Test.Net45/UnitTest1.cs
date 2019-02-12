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
                ApiKey = "uap-4f892058d35e46dd8a3a660481583b79-6a1319cb"
            });
        }

        [TestMethod]
        public void CheckSetupUiza()
        {
            Assert.AreEqual(true,true);
        }
    }
}

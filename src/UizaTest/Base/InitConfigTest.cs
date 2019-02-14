using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Configuration;

namespace UizaTest
{
    /// <summary>
    /// 
    /// </summary>
    public class InitConfigTest : IDisposable
    {
        public InitConfigTest()
        {
            CreateConfig();
        }

        public void Dispose()
        {
            ClearConfig();
        }

        protected void ClearConfig()
        {
            UizaConfiguration.SetupUiza(new UizaConfigOptions
            {
                ApiKey = "",
                ApiBase = ""
            });
        }

        protected void CreateConfig()
        {
            UizaConfiguration.SetupUiza(new UizaConfigOptions
            {
                ApiKey = "uap-a2aaa7b2aea746ec89e67ad2f8f9ebbf-fdf5bdca",
                ApiBase = "https://apiwrapper.uiza.co"
            });
        }
    }
}

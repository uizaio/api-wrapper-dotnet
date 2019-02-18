using System;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;
using Uiza.Net.Services;
using Uiza.Net.UizaHandleException;

namespace Uiza.Net45.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UizaConfiguration.SetupUiza(new UizaConfigOptions
                {
                    ApiKey = "",
                    ApiBase = "https://apiwrapper.uiza.co"
                });
                var result = UizaServices.Entity.Create(new CreateEntityParameter()
                {
                    //Name = "Sample Video",
                    InputType = EntityInputTypes.S3Uiza,
                    URL = ""
                });

                Console.WriteLine("Success");
                Console.ReadLine();
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

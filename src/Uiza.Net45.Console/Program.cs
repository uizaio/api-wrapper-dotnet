using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uiza.Net.Configuration;
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
                    ApiKey = "uap-4f892058d35e46dd8a3a660481583b79-6a1319cb"
                });
                var service = new CategoryService();
                var result = service.Create(new CreateCategoryParameter()
                {
                    Description = "Category Description",
                    Icon = "https://exemple.com/icon.png",
                    Name = Guid.NewGuid().ToString(),
                    OrderNumber = 1,
                    Type = "folder"
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

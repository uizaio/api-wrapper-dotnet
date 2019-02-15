using Moq;
using Uiza.Net.Services;

namespace UizaTest
{
    public class UizaTestBase<T> where T : class, IBaseServices
    {
        public Mock<T> mockService;

        protected UizaTestBase()
        {
            mockService = new Mock<T>() { CallBase = true };
        }
    }
}
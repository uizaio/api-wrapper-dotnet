using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Services;
using Xunit;

namespace UizaTest
{
    public class UizaTestBase<T> where T : Service
    {
        protected Mock<T> mockService;
        protected UizaTestBase()
        {
            mockService = new Mock<T>() { CallBase = true };
        }
    }
}

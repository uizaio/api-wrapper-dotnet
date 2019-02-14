using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Services;
using Uiza.Net.UizaHandleException;
using UizaTest.MockData;
using Xunit;

namespace UizaTest.Services
{
    public class EntityServiceTest : UizaTestBase
    {
        private readonly EntityService service;
        private string entityId;

        public EntityServiceTest()
        {
            this.service = new EntityService();
        }


        [Fact]
        public void CreateSuccess()
        {
            var customer = service.Create(EntityData.CreateValidEntityParameter());
            Assert.NotNull(customer.Data.id);
        }

        [Fact]
        public void CreateFailWithValidation()
        {
            Assert.Throws<UizaException>(() => this.service.Create(EntityData.CreateMissingPropertyParameter()));
        }

        [Fact]
        public void CreateFailWithAPIResponse()
        {
            Assert.Throws<UizaException>(() => this.service.Create(EntityData.CreateInValidEntityParameter()));
        }
    }
}

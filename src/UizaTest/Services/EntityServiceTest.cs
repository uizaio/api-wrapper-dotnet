using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;
using UizaTest.MockData;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    public class EntityServiceTest : UizaTestBase<EntityService>
    {
        [Fact]
        public void CreateSuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateEntityParameter>())).Returns(EntityResponse.CreateSuccessResponse());
            var result = mockService.Object.Create(EntityMockParameter.CreateValidEntityParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void CreateFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateEntityParameter>())).Throws(EntityResponse.CreateErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(EntityMockParameter.CreateInValidEntityParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }
    }
}

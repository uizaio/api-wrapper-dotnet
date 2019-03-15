using Moq;
using Uiza.Net.Parameters;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
using UizaTest.MockParameter;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    public class AnalyticServiceTest : UizaTestBase<IAnalyticService>
    {
        [Fact]
        public void GetTotalLineSuccess()
        {
            mockService.Setup(_ => _.GetTotalLine(It.IsAny<TotalLineParameter>())).Returns(BaseMockResponse.SuccessResponse);
            var result = mockService.Object.GetTotalLine(AnalyticMockParameter.GetTotalLineSuccessParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTotalLineFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetTotalLine(It.IsAny<TotalLineParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetTotalLine(AnalyticMockParameter.GetTotalLineFailParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetLineSuccess()
        {
            mockService.Setup(_ => _.GetLine(It.IsAny<LineParameter>())).Returns(BaseMockResponse.SuccessResponse);
            var result = mockService.Object.GetLine(AnalyticMockParameter.GetLineSuccessParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void GetLineFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetLine(It.IsAny<LineParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetLine(AnalyticMockParameter.GetLineFailParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetTypeSuccess()
        {
            mockService.Setup(_ => _.GetType(It.IsAny<TypeParameter>())).Returns(BaseMockResponse.SuccessResponse);
            var result = mockService.Object.GetType(AnalyticMockParameter.GetTypeSuccessParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTypeFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetType(It.IsAny<TypeParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetType(AnalyticMockParameter.GetTypeFailParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
using Moq;
using Uiza.Net.Enum;
using Uiza.Net.Parameters;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    public class AnalyticServiceTest : UizaTestBase<IAnalyticService>
    {
        [Fact]
        public void GetTotalLineSuccess()
        {
            mockService.Setup(_ => _.GetTotalLine(It.IsAny<AnalyticTotalLineParameter>())).Returns(BaseMockResponse.SuccessResponse);
            var param = new AnalyticTotalLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                Metric = MetricType.RebufferCount
            };
            var result = mockService.Object.GetTotalLine(param);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTotalLineFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetTotalLine(It.IsAny<AnalyticTotalLineParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var param = new AnalyticTotalLineParameter()
                {
                    StartDate = @"2018-11-01 20:00",
                    Metric = MetricType.RebufferCount
                };
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetTotalLine(param));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetLineSuccess()
        {
            mockService.Setup(_ => _.GetLine(It.IsAny<AnalyticLineParameter>())).Returns(BaseMockResponse.SuccessResponse);
            var param = new AnalyticLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00"
            };
            var result = mockService.Object.GetLine(param);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetLineFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetLine(It.IsAny<AnalyticLineParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var param = new AnalyticLineParameter()
                {
                    StartDate = @"2018-11-01 20:00"
                };
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetLine(param));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetTypeSuccess()
        {
            mockService.Setup(_ => _.GetType(It.IsAny<AnalyticTypeParameter>())).Returns(BaseMockResponse.SuccessResponse);
            var param = new AnalyticTypeParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                TypeFilter = MetricTypeFilter.Country
            };
            var result = mockService.Object.GetType(param);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTypeFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetType(It.IsAny<AnalyticTypeParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var param = new AnalyticTypeParameter()
                {
                    StartDate = @"2018-11-01 20:00",
                    EndDate = @"2018-11-19 20:00",
                };
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetType(param));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
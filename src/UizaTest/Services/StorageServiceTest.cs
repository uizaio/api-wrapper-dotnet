using Moq;
using Uiza.Net.Parameters;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;
using UizaTest.MockParameter;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    /// <summary>
    ///
    /// </summary>
    public class StorageServiceTest : UizaTestBase<IStorageService>
    {
        [Fact]
        public void CreateStorageSuccess()
        {
            mockService.Setup(_ => _.Add(It.IsAny<CreateStorageParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Add(StorageMockParameter.CreateValidStorageParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void CreateStorageFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Add(It.IsAny<CreateStorageParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Add(StorageMockParameter.CreateInValidStorageParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void RetrieveStorageSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Retrieve("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void RetrieveFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void DeleteStorageSuccess()
        {
            mockService.Setup(_ => _.Remove(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Remove("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void DeleteStorageFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Remove(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Remove(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void UpdateStorageSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateStorageParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(StorageMockParameter.CreateValidUpdateStorageParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void UpdateStorageFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateStorageParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(StorageMockParameter.CreateInValidUpdateStorageParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }
    }
}
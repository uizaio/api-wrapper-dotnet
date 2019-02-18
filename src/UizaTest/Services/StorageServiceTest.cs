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
            mockService.Setup(_ => _.Create(It.IsAny<CreateStorageParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(StorageMockParameter.CreateValidStorageParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void CreateStorageFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateStorageParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(StorageMockParameter.CreateInValidStorageParameter()));
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
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Delete("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void DeleteStorageFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Delete(""));
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
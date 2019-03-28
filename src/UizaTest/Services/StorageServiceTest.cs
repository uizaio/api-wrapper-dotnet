﻿using Moq;
using Uiza.Net.Parameters;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
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
            mockService.Setup(_ => _.Add(It.IsAny<AddStorageParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Add(StorageMockParameter.CreateValidStorageParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateStorageFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Add(It.IsAny<AddStorageParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Add(StorageMockParameter.CreateInValidStorageParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void RetrieveStorageSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<RetriveStorageParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Retrieve(new RetriveStorageParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void RetrieveFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Retrieve(It.IsAny<RetriveStorageParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(new RetriveStorageParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void DeleteStorageSuccess()
        {
            mockService.Setup(_ => _.Remove(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Remove("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteStorageFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Remove(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Remove(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void UpdateStorageSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateStorageParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(StorageMockParameter.CreateValidUpdateStorageParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateStorageFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Update(It.IsAny<UpdateStorageParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(StorageMockParameter.CreateInValidUpdateStorageParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
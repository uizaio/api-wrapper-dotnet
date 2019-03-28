﻿using Moq;
using System;
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
    public class LiveServiceTest : UizaTestBase<ILiveService>
    {
        [Fact]
        public void CreatSuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateLiveParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(LiveMockParameter.CreateLiveParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Create(It.IsAny<CreateLiveParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(LiveMockParameter.CreateLiveParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void RetrieveSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<GetLiveParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Retrieve(new GetLiveParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void RetrieveFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Retrieve(It.IsAny<GetLiveParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(new GetLiveParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void UpdateSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateLiveParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(LiveMockParameter.UpdateLiveParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Update(It.IsAny<UpdateLiveParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(LiveMockParameter.UpdateLiveParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void StartSuccess()
        {
            mockService.Setup(_ => _.StartFeed(It.IsAny<StartFeedParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.StartFeed(new StartFeedParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void StartFeedFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.StartFeed(It.IsAny<StartFeedParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.StartFeed(new StartFeedParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetViewSuccess()
        {
            mockService.Setup(_ => _.GetView(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.GetView(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void GetViewFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetView(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetView(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void StopFeedSuccess()
        {
            mockService.Setup(_ => _.StopFeed(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.StopFeed(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void StopFeedFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.StopFeed(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.StopFeed(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ListSuccess()
        {
            mockService.Setup(_ => _.ListRecorded(It.IsAny<string>())).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.ListRecorded(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void ListFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.ListRecorded(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.ListRecorded(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void DeleteSuccess()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Delete(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Delete(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Delete(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ConvertToVODSuccess()
        {
            mockService.Setup(_ => _.ConvertToVOD(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.ConvertToVOD(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void ConvertToVODFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.ConvertToVOD(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.ConvertToVOD(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
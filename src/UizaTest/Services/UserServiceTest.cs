using Moq;
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
    public class UserServiceTest : UizaTestBase<IUserService>
    {
        [Fact]
        public void RetriveSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Retrieve(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void RetriveFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ListSuccess()
        {
            mockService.Setup(_ => _.List()).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.List();
            Assert.NotNull(result);
        }

        [Fact]
        public void ListFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.List()).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.List());
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void UpdateSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateUserParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(UserMockParamter.UpdateUserParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Update(It.IsAny<UpdateUserParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(UserMockParamter.UpdateUserParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ChangePasswordSuccess()
        {
            mockService.Setup(_ => _.ChangePassword(It.IsAny<ChangePasswordParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.ChangePassword(UserMockParamter.ChangePasswordParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void ChangePasswordFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.ChangePassword(It.IsAny<ChangePasswordParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.ChangePassword(UserMockParamter.ChangePasswordParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void LogoutSuccess()
        {
            mockService.Setup(_ => _.Logout()).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Logout();
            Assert.NotNull(result);
        }

        [Fact]
        public void LogoutFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Logout()).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Logout());
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
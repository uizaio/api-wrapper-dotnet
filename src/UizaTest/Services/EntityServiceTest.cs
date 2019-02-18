using Moq;
using Uiza.Net.Parameters;
using Uiza.Net.Services;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;
using UizaTest.MockData;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    public class EntityServiceTest : UizaTestBase<IEntityService>
    {
        [Fact]
        public void CreateSuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateEntityParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(EntityMockParameter.CreateValidEntityParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void CreateFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateEntityParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(EntityMockParameter.CreateInValidEntityParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void RetrieveSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Returns(EntityResponse.RetrieveSuccessResponse());
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
        public void ListEntitiesSuccess()
        {
            mockService.Setup(_ => _.List(It.IsAny<RetrieveListEntitiesParameter>())).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.List(EntityMockParameter.ListValidEntityParameter());
            Assert.Equal(2, result.Data.Count);
        }

        [Fact]
        public void UpdateSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateEntityParameter>())).Returns(EntityResponse.UpdateSuccessResponse());
            var result = mockService.Object.Update(EntityMockParameter.UpdateValidEntityParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void UpdateFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateEntityParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(EntityMockParameter.UpdateInValidEntityParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void DeleteSuccess()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Returns(EntityResponse.DeleteSuccessResponse());
            var result = mockService.Object.Delete("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void DeleteFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Delete(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void SearchSuccess()
        {
            mockService.Setup(_ => _.SearchEntity(It.IsAny<string>())).Returns(EntityResponse.SearchSuccessResponse());
            var result = mockService.Object.SearchEntity("Sample");
            Assert.Equal(2, result.Data.Count);
        }

        [Fact]
        public void SearchFailWithAPIResponse()
        {
            mockService.Setup(_ => _.SearchEntity(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.SearchEntity(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void PublishEntitySuccess()
        {
            mockService.Setup(_ => _.PublishEntity(It.IsAny<string>())).Returns(EntityResponse.RetrieveSuccessResponse());
            var result = mockService.Object.PublishEntity("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void PublishEntityFailWithAPIResponse()
        {
            mockService.Setup(_ => _.PublishEntity(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.PublishEntity(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void GetStatusPublishSuccess()
        {
            mockService.Setup(_ => _.GetEntityStatusPublish(It.IsAny<string>())).Returns(EntityResponse.GetStatusPublishSuccessResponse());
            var result = mockService.Object.GetEntityStatusPublish("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.status);
        }

        [Fact]
        public void GetStatusPublishFailWithAPIResponse()
        {
            mockService.Setup(_ => _.GetEntityStatusPublish(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.GetEntityStatusPublish(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void GetAWSUploadKeySuccess()
        {
            mockService.Setup(_ => _.GetEntityAWSUploadKey()).Returns(EntityResponse.GetAWSUploadKeySuccessResponse());
            var result = mockService.Object.GetEntityAWSUploadKey();
            Assert.NotNull(result.Data.temp_expire_at);
        }
    }
}
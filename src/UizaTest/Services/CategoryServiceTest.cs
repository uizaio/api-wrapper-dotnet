﻿using Moq;
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
    public class CategoryServiceTest : UizaTestBase<ICategoryService>
    {
        [Fact]
        public void CreateCategorySuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateCategoryParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(CategoryMockParameter.CreateValidCategoryParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void CreateCategoryFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateCategoryParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(CategoryMockParameter.CreateInValidCategoryParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void RetrieveCategorySuccess()
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
        public void CreateCategoryRelationSuccess()
        {
            mockService.Setup(_ => _.CreateCategoryRelation(It.IsAny<CategoryRelationParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.CreateCategoryRelation(CategoryMockParameter.CreateValidCategoryRelationParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void CreateCategoryRelationFailWithAPIResponse()
        {
            mockService.Setup(_ => _.CreateCategoryRelation(It.IsAny<CategoryRelationParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.CreateCategoryRelation(CategoryMockParameter.CreateInValidCategoryRelationParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void DeleteCategoryRelationSuccess()
        {
            mockService.Setup(_ => _.DeleteCategoryRelation(It.IsAny<CategoryRelationParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.DeleteCategoryRelation(CategoryMockParameter.CreateValidCategoryRelationParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void DeleteCategoryRelationFailWithAPIResponse()
        {
            mockService.Setup(_ => _.DeleteCategoryRelation(It.IsAny<CategoryRelationParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.DeleteCategoryRelation(CategoryMockParameter.CreateInValidCategoryRelationParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void DeleteCategorySuccess()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Delete("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void DeleteCategoryFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Delete(""));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }

        [Fact]
        public void ListCategorySuccess()
        {
            mockService.Setup(_ => _.List(It.IsAny<BaseParameter>())).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.List(new BaseParameter());
            Assert.Equal(2, (int)result.MetaData.total);
        }


        [Fact]
        public void UpdateCategorySuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateCategoryParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(CategoryMockParameter.CreateValidUpdateCategoryParameter());
            Assert.NotNull(result.Data.id);
        }

        [Fact]
        public void UpdateCategoryFailWithAPIResponse()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateCategoryParameter>())).Throws(BaseMockResponse.ErrorResponse());
            var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(CategoryMockParameter.CreateInValidUpdateCategoryParameter()));
            Assert.Equal((int)ResponseCodeEnums.Unprocessable, ex.UizaInnerException.Code);
        }
    }
}
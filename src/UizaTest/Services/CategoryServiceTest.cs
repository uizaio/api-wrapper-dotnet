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
    public class CategoryServiceTest : UizaTestBase<ICategoryService>
    {
        [Fact]
        public void CreateCategorySuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateCategoryParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(CategoryMockParameter.CreateValidCategoryParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateCategoryFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Create(It.IsAny<CreateCategoryParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(CategoryMockParameter.CreateInValidCategoryParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void RetrieveCategorySuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<RetriveCategoryParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Retrieve(new RetriveCategoryParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void RetrieveFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Retrieve(It.IsAny<RetriveCategoryParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(new RetriveCategoryParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void CreateCategoryRelationSuccess()
        {
            mockService.Setup(_ => _.CreateRelation(It.IsAny<CategoryRelationParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.CreateRelation(CategoryMockParameter.CreateValidCategoryRelationParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateCategoryRelationFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.CreateRelation(It.IsAny<CategoryRelationParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.CreateRelation(CategoryMockParameter.CreateInValidCategoryRelationParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void DeleteCategoryRelationSuccess()
        {
            mockService.Setup(_ => _.DeleteRelation(It.IsAny<CategoryRelationParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.DeleteRelation(CategoryMockParameter.CreateValidCategoryRelationParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteCategoryRelationFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.DeleteRelation(It.IsAny<CategoryRelationParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.DeleteRelation(CategoryMockParameter.CreateInValidCategoryRelationParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void DeleteCategorySuccess()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Delete(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteCategoryFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Delete(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Delete(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ListCategorySuccess()
        {
            mockService.Setup(_ => _.List()).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.List();
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateCategorySuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateCategoryParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(CategoryMockParameter.CreateValidUpdateCategoryParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateCategoryFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Update(It.IsAny<UpdateCategoryParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(CategoryMockParameter.CreateInValidUpdateCategoryParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
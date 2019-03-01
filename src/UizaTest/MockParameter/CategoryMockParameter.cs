using System;
using System.Collections.Generic;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class CategoryMockParameter
    {
        public static CreateCategoryParameter CreateValidCategoryParameter()
        {
            return new CreateCategoryParameter()
            {
                Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
                Type = CategoryTypes.Folder
            };
        }

        public static CreateCategoryParameter CreateInValidCategoryParameter()
        {
            return new CreateCategoryParameter()
            {
            };
        }

        public static UpdateCategoryParameter CreateValidUpdateCategoryParameter()
        {
            return new UpdateCategoryParameter()
            {
                Id = Guid.NewGuid().ToString(),
                Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
                Type = CategoryTypes.Folder
            };
        }

        public static UpdateCategoryParameter CreateInValidUpdateCategoryParameter()
        {
            return new UpdateCategoryParameter()
            {
                Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
                Type = CategoryTypes.Folder
            };
        }

        public static CategoryRelationParameter CreateValidCategoryRelationParameter()
        {
            return new CategoryRelationParameter()
            {
                EntityId = Guid.NewGuid().ToString(),
                MetadataIds = new List<string>() {
                    Guid.NewGuid().ToString(),
                    Guid.NewGuid().ToString(),
               }
            };
        }

        public static CategoryRelationParameter CreateInValidCategoryRelationParameter()
        {
            return new CategoryRelationParameter()
            {
            };
        }
    }
}
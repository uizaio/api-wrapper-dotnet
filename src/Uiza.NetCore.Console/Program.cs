using System;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;
using Uiza.Net.Services;
using Uiza.Net.UizaHandleException;

namespace Uiza.NetCore.ConsoleTest
{
    internal class Program
    {
        private static void TestCatology()
        {
            var service = new CategoryService();
            var result = service.Create(new CreateCategoryParameter()
            {
                Description = "Category Description",
                Icon = "https://exemple.com/icon.png",
                Name = Guid.NewGuid().ToString(),
                OrderNumber = 1,
                Type = "folder"
            });

            Console.WriteLine(string.Format("Create New Category Id = {0} Success", result.Data.id));

            var getResultRetrieveCategory = service.Retrieve(result.Data.id);
            Console.WriteLine(string.Format("Get Category Id = {0} Success", getResultRetrieveCategory.Data.id));

            var getResultRetrieveCategoryList = service.List(new RetrieveListParameter());
            Console.WriteLine(string.Format("Success Get RetrieveCategoryList, total record {0}", getResultRetrieveCategoryList.MetaData.result));

            var resultUpdateCategory = service.Update(new UpdateCategoryParameter()
            {
                Id = result.Data.id,
                Description = "Category Description Update",
                Icon = "https://exemple.com/icon.png",
                Name = Guid.NewGuid().ToString(),
                OrderNumber = 2,
                Type = "folder"
            });

            Console.WriteLine(string.Format("Update Category Id = {0} Success", getResultRetrieveCategory.Data.id));

            var deleteCategory = service.Delete(result.Data.id);
            Console.WriteLine(string.Format("Delete Category Id = {0} Success", getResultRetrieveCategory.Data.id));

            Console.WriteLine("Success");
            Console.ReadLine();
        }

        private static void TestEntity()
        {
            try
            {
                var service = new EntityService();
                var result = service.Create(new CreateEntityParameter()
                {
                    Name = "Sample Video",
                    InputType = EntityInputTypes.S3Uiza,
                    URL = ""
                });
                Console.WriteLine(string.Format("Create New Entity Id = {0} Success", result.Data.id));

                var getResultRetrieveCategory = service.Retrieve((string)result.Data.id);
                Console.WriteLine(string.Format("Get Entity Id = {0} Success", getResultRetrieveCategory.Data.id));

                var getResultRetrieveCategoryList = service.List(new RetrieveListEntitiesParameter() { publishToCdn = EntityPublishStatus.Success });
                Console.WriteLine(string.Format("Success Get EntitiesList, total record {0}", getResultRetrieveCategoryList.MetaData.result));

                var resultUpdateCategory = service.Update(new UpdateEntityParameter()
                {
                    Id = result.Data.id,
                    Name = "Sample update",
                    Description = "Description update",
                    ShortDescription = "ShortDescription update",
                    Poster = "/example.com/updatePoster",
                    Thumbnail = "/example.com/updateThumbnail"
                });

                var getAwsUploadKey = service.GetEntityAWSUploadKey();
                Console.WriteLine(string.Format("Get AWS Upload Key Success : temp_access_id = {0} ", getAwsUploadKey.Data.temp_access_id));

                var publishEntity = service.PublishEntity((string)result.Data.id);
                Console.WriteLine(string.Format("Publish Entity Success : entityId = {0} ", publishEntity.Data.entityId));

                var getStatusPublish = service.GetEntityStatusPublish((string)result.Data.id);
                Console.WriteLine(string.Format("Get Status Publish Success : temp_access_id = {0} ", getStatusPublish.Data.status));

                var searchEntity = service.SearchEntity("Sample");
                Console.WriteLine(string.Format("Search Success, , total record {0}", searchEntity.Data.Count));

                var deleteEntity = service.Delete((string)result.Data.id);
                Console.WriteLine(string.Format("Delete Entity Id = {0} Success", deleteEntity.Data.id));
                Console.ReadLine();
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void Main(string[] args)
        {
            try
            {
                UizaConfiguration.SetupUiza(new UizaConfigOptions
                {
                    ApiKey = "",
                    ApiBase = "https://apiwrapper.uiza.co"
                });
                TestEntity();
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
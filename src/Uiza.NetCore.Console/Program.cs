using System;
using System.Collections.Generic;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;
using Uiza.Net.Services;
using Uiza.Net.UizaHandleException;

namespace Uiza.NetCore.ConsoleTest
{
    internal class Program
    {
        private static void TestAnalytic()
        {
            LogActivity("Analytic");
            try
            {
                var getTotalLine = UizaServices.Analytic.GetTotalLine(new AnalyticTotalLineParameter()
                {
                    StartDate = @"2019-02-28 20:00",
                    EndDate = @"2019-03-01 20:00",
                    Metric = MetricType.RebufferCount
                });
                Console.WriteLine(string.Format("Get Total Line Success, total record {0}", getTotalLine.Data.Count));

                var getType = UizaServices.Analytic.GetType(new AnalyticTypeParameter()
                {
                    StartDate = @"2019-01-01",
                    EndDate = @"2019-03-01",
                    TypeFilter = TypeFilter.Country
                });
                Console.WriteLine(string.Format("Get Type Success, total record {0}", getType.Data.Count));

                var getLine = UizaServices.Analytic.GetLine(new AnalyticLineParameter()
                {
                    StartDate = @"2019-01-01",
                    EndDate = @"2019-03-01",
                    Type = LineType.RebufferCount
                });
                Console.WriteLine(string.Format("Get Line Success, total record {0}", getLine.Data.Count));
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }

            LogActivity("Analytic", true);
        }

        private static void TestCallback()
        {
            LogActivity("Call back");
            try
            {
                var createResult = UizaServices.Callback.Create(new CreateCallbackParameter()
                {
                    Url = "https://callback-url.uiza.co",
                    Method = CallbackMethodTypes.Post,
                });

                Console.WriteLine(string.Format("Create New Callback Id = {0} Success", createResult.Data.id));

                var resultUpdate = UizaServices.Callback.Update(new UpdateCallbackParameter()
                {
                    Id = createResult.Data.id,
                    Url = "https://callback-url.uiza.co/update",
                    Method = CallbackMethodTypes.Post
                });

                Console.WriteLine(string.Format("Update Callback Id = {0} Success", resultUpdate.Data.id));

                var retrieveResult = UizaServices.Callback.Retrieve((string)createResult.Data.id);
                Console.WriteLine(string.Format("Get Callback Id = {0} Success", retrieveResult.Data.id));

                var resultDelete = UizaServices.Callback.Delete((string)createResult.Data.id);
                Console.WriteLine(string.Format("Delete Callback Id = {0} Success", resultUpdate.Data.id));
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }

            LogActivity("Call back", true);
        }

        private static void TestLiveStreaming()
        {
            LogActivity("Live Streaming");
            try
            {
                var createResult = UizaServices.Live.Create(new CreateLiveParameter()
                {
                    Name = Guid.NewGuid().ToString(),
                    Mode = "push",
                    Description = Guid.NewGuid().ToString(),
                    Encode = EncodeTypes.Encode,
                   // Dvr = DvrTypes.ActiveFeatureRecord,
                    LinkStream = new List<string>() { "https://playlist.m3u8" },
                    Poster = "//image1.jpeg",
                    Thumbnail = "//image1.jpeg",
                    ResourceMode = ResourceModes.Single
                });

                Console.WriteLine(string.Format("Create New Category Id = {0} Success", createResult.Data.id));

                var resultUpdate = UizaServices.Live.Update(new UpdateLiveParameter()
                {
                    Id = createResult.Data.id,
                    Name = Guid.NewGuid().ToString(),
                    Mode = "pull",
                    Encode = EncodeTypes.Encode,
                    Dvr = DvrTypes.ActiveFeatureRecord,
                    ResourceMode = ResourceModes.Single
                });

                Console.WriteLine(string.Format("Update Category Id = {0} Success", resultUpdate.Data.id));

                var retrieveResult = UizaServices.Live.Retrieve(new GetLiveParameter()
                {
                    Id = (string)createResult.Data.id
                }
                );
                Console.WriteLine(string.Format("Get Category Id = {0} Success", retrieveResult.Data.id));

                var listResult = UizaServices.Live.ListRecorded((string)retrieveResult.Data.id);
                Console.WriteLine(string.Format("Success Get List All Recorded Files, total record {0}", listResult.MetaData != null ? listResult.MetaData.total : 0));

                var startLiveFeedResult = UizaServices.Live.StartFeed(new StartFeedParameter() { Id = (string)createResult.Data.id });
                Console.WriteLine(string.Format("Start Live Feed Success", retrieveResult.Data.id));

                var getViewOfLiveFeedResult = UizaServices.Live.GetView((string)createResult.Data.id);
                Console.WriteLine(string.Format("Get View Live Feed Success", getViewOfLiveFeedResult.Data.id));

                var convertIntoVODResult = UizaServices.Live.GetView((string)createResult.Data.id);
                Console.WriteLine(string.Format("Convert VOD Success", convertIntoVODResult.Data.id));

                var stopALiveFeedResult = UizaServices.Live.StopFeed((string)createResult.Data.id);
                Console.WriteLine(string.Format("Stop A Live Feed Success", stopALiveFeedResult.Data.entityId));

                var deleteRecordFileResult = UizaServices.Live.Delete((string)createResult.Data.id);
                Console.WriteLine(string.Format("Delete Live Feed Success", deleteRecordFileResult.Data.id));
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }
            LogActivity("Live Streaming", true);
        }

        private static void TestCategory()
        {
            LogActivity("Category");
            try
            {
                var createResult = UizaServices.Category.Create(new CreateCategoryParameter()
                {
                    Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
                    Type = CategoryTypes.Folder
                });

                Console.WriteLine(string.Format("Create New Category Id = {0} Success", createResult.Data.id));

                var resultUpdate = UizaServices.Category.Update(new UpdateCategoryParameter()
                {
                    Id = createResult.Data.id,
                    Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
                    Type = CategoryTypes.PlayList
                });

                Console.WriteLine(string.Format("Update Category Id = {0} Success", resultUpdate.Data.id));

                var retrieveResult = UizaServices.Category.Retrieve(new RetriveCategoryParameter()
                {
                    Id = (string)createResult.Data.id,
                });
                Console.WriteLine(string.Format("Get Category Id = {0} Success", retrieveResult.Data.id));

                var listResult = UizaServices.Category.List(new BaseParameter());
                Console.WriteLine(string.Format("Success Get List Category, total record {0}", listResult.MetaData.result));

                var listMetadata = new List<string>()
                    {
                        Guid.NewGuid().ToString(),
                        Guid.NewGuid().ToString(),
                        Guid.NewGuid().ToString(),
                    };

                var entity = UizaServices.Entity.Create(new CreateEntityParameter()
                {
                    Name = "Sample Video",
                    InputType = EntityInputTypes.S3Uiza,
                    URL = ""
                });

                var createCategoryRelationResult = UizaServices.Category.CreateRelation(new CategoryRelationParameter()
                {
                    EntityId = entity.Data.id,
                    MetadataIds = listMetadata
                });
                Console.WriteLine(string.Format("Create Success Category Relation, total record {0}", createCategoryRelationResult.MetaData.result));

                var deleteCategoryRelationResult = UizaServices.Category.DeleteRelation(new CategoryRelationParameter()
                {
                    EntityId = entity.Data.id,
                    MetadataIds = listMetadata
                });
                Console.WriteLine(string.Format("Delete Success Category Relation, total record {0}", deleteCategoryRelationResult.MetaData.result));

                var resultDelete = UizaServices.Category.Delete((string)createResult.Data.id);
                Console.WriteLine(string.Format("Delete Category Id = {0} Success", resultUpdate.Data.id));

                UizaServices.Entity.Delete((string)entity.Data.id);
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }

            LogActivity("Category", true);
        }

        private static void TestEntity()
        {
            LogActivity("Entity");
            try
            {
                var result = UizaServices.Entity.Create(new CreateEntityParameter()
                {
                    Name = Guid.NewGuid().ToString(),
                    InputType = EntityInputTypes.S3Uiza,
                    URL = "https://www.youtube.com/watch?v=FjHGZj2IjBk"
                });
                Console.WriteLine(string.Format("Create New Entity Success", result.Data.id));

                var getResultRetrieveCategory = UizaServices.Entity.Retrieve((string)result.Data.id);
                Console.WriteLine(string.Format("Get Entity Id = {0} Success", getResultRetrieveCategory.Data.id));

                var getResultRetrieveCategoryList = UizaServices.Entity.List();
                Console.WriteLine(string.Format("Success Get EntitiesList, total record {0}", getResultRetrieveCategoryList.MetaData.result));

                var resultUpdateCategory = UizaServices.Entity.Update(new UpdateEntityParameter()
                {
                    Id = result.Data.id,
                    Name = "Sample update",
                    Description = "Description update",
                    ShortDescription = "ShortDescription update",
                    Poster = "/example.com/updatePoster",
                    Thumbnail = "/example.com/updateThumbnail"
                });

                var getAwsUploadKey = UizaServices.Entity.GetAWSUploadKey();
                Console.WriteLine(string.Format("Get AWS Upload Key Success : temp_access_id = {0} ", getAwsUploadKey.Data.temp_access_id));

                var publishEntity = UizaServices.Entity.Publish((string)result.Data.id);
                Console.WriteLine(string.Format("Publish Entity Success : entityId = {0} ", publishEntity.Data.entityId));

                var getStatusPublish = UizaServices.Entity.GetStatusPublish((string)result.Data.id);
                Console.WriteLine(string.Format("Get Status Publish Success : temp_access_id = {0} ", getStatusPublish.Data.status));

                var deleteEntity = UizaServices.Entity.Delete((string)result.Data.id);
                Console.WriteLine(string.Format("Delete Entity Id = {0} Success", deleteEntity.Data.id));
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }

            LogActivity("Entity", true);
        }

        private static void TestStorage()
        {
            LogActivity("Storage");
            try
            {
                var result = UizaServices.Storage.Add(new AddStorageParameter()
                {
                    Name = "FTP Uiza",
                    Host = "ftp-example.uiza.io",
                    Description = "FTP of Uiza, use for transcode",
                    StorageType = StorageInputTypes.Ftp,
                    UserName = "uiza",
                    Password = "=59x@LPsd+w7qW",
                    Port = 21
                });
                Console.WriteLine(string.Format("Add New Storage Id = {0} Success", result.Data.id));

                var getResultRetrieveStorage = UizaServices.Storage.Retrieve(new RetriveStorageParameter()
                {
                    Id = (string)result.Data.id
                });

                Console.WriteLine(string.Format("Get Storage Id = {0} Success", getResultRetrieveStorage.Data.id));

                var resultUpdateStorage = UizaServices.Storage.Update(new UpdateStorageParameter()
                {
                    Id = result.Data.id,
                    Name = "FTP Uiza Update",
                    Host = "ftp-example.uiza.io",
                    Description = "FTP of Uiza, use for transcode Update",
                    StorageType = StorageInputTypes.S3,
                    UserName = "uizaUpdate",
                    Password = "=59x@LPsd+w7qW",
                    Port = 22
                });
                Console.WriteLine(string.Format("Update Storage Id = {0} Success", resultUpdateStorage.Data.id));

                var deleteStorage = UizaServices.Storage.Remove((string)result.Data.id);
                Console.WriteLine(string.Format("Remove Storage Id = {0} Success", deleteStorage.Data.id));
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }
            LogActivity("Storage", true);
        }

        private static void TestUser()
        {
            LogActivity("User");
            try
            {
                var curentPW = Guid.NewGuid().ToString();
                var result = UizaServices.User.Create(new CreatUserParameter()
                {
                    Status = UserStatus.Active,
                    UserName = Guid.NewGuid().ToString(),
                    Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
                    PassWord = curentPW,
                    FullName = Guid.NewGuid().ToString(),
                    Avatar = "https://static.uiza.io/uiza_logo_128.png"
                });
                Console.WriteLine(string.Format("Create New User Id = {0} Success", result.Data.id));

                var retrieveResult = UizaServices.User.Retrieve((string)result.Data.id);
                Console.WriteLine(string.Format("Get User Id = {0} Success", retrieveResult.Data.id));

                var listResult = UizaServices.User.List();
                Console.WriteLine(string.Format("List User Success, total record {0}", listResult.Data.Count));

                var updateResult = UizaServices.User.Update(new UpdateUserParameter()
                {
                    Id = (string)result.Data.id,
                    Status = UserStatus.Active,
                    UserName = Guid.NewGuid().ToString(),
                    Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
                    PassWord = Guid.NewGuid().ToString()
                });

                Console.WriteLine(string.Format("Update User Id = {0} Success", updateResult.Data.id));

                var changePWResult = UizaServices.User.ChangePassword(new ChangePasswordParameter()
                {
                    Id = (string)result.Data.id,
                    NewPassword = Guid.NewGuid().ToString(),
                    OldPassWord = curentPW,
                });

                Console.WriteLine(string.Format("Change Password User Id = {0} Success", result.Data.id));

                var deleteResult = UizaServices.User.Delete((string)result.Data.id);
                Console.WriteLine(string.Format("Delete User Id = {0} Success", result.Data.id));

                var logOutResult = UizaServices.User.Logout();
                Console.WriteLine("Logout Success");
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
            }
            LogActivity("User", true);
        }

        private static void Main(string[] args)
        {
            try
            {
                UizaConfiguration.SetupUiza(new UizaConfigOptions
                {
                    ApiKey = "",
                    AppId = ""
                });
                TestEntity();
                TestCategory();
                TestStorage();
                TestLiveStreaming();
                //TestAnalytic();
                //TestUser();
                Console.ReadLine();
            }
            catch (UizaException ex)
            {
                var result = ex.UizaInnerException.Error;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void LogActivity(string apiName, bool isEnd = false)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("--------------------------{0} Run {1} ---------------------", isEnd ? "End" : "Start", apiName));
            Console.WriteLine();
        }
    }
}
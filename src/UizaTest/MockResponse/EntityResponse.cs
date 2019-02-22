using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Uiza.Net.Response;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;

namespace UizaTest.MockResponse
{
    public static class EntityResponse 
    {
       
        public static UizaData RetrieveSuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaData UpdateSuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaData DeleteSuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaData SearchSuccessResponse()
        {
            return BaseMockResponse.ListSuccessResponse();
        }

        public static UizaData PublishEntitySuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaData GetStatusPublishSuccessResponse()
        {
            dynamic data = new JObject();
            data.status = "processing";

            return new UizaData() { Data = data };
        }

        public static UizaData GetAWSUploadKeySuccessResponse()
        {
            dynamic data = new JObject();
            data.temp_expire_at = "1533658598";

            return new UizaData() { Data = data };
        }
    }
}
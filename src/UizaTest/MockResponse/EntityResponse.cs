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
        public static UizaData CreateSuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaException CreateErrorResponse()
        {
            return new UizaException()
            {
                UizaInnerException = new UizaExceptionResponse()
                {
                    Code = (int)ResponseCodeEnums.Unprocessable
                }
            };
        }

        public static UizaData RetrieveSuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaData ListSuccessResponse()
        {
            dynamic firstEntity = new JObject();
            firstEntity.id = Guid.NewGuid().ToString();
            dynamic seconrdEntity = new JObject();
            seconrdEntity.id = Guid.NewGuid().ToString();

            List<dynamic> arrData = new List<dynamic>
            {
               firstEntity,
               seconrdEntity
            };

            return new UizaData() { Data = arrData };
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
            return ListSuccessResponse();
        }

        public static UizaException ErrorResponse()
        {
            return new UizaException()
            {
                UizaInnerException = new UizaExceptionResponse()
                {
                    Code = (int)ResponseCodeEnums.Unprocessable
                }
            };
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
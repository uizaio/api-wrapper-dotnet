using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Uiza.Net.Response;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;

namespace UizaTest.MockResponse
{
    public class BaseMockResponse
    {
        public static UizaData SuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
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

        public static UizaData ListSuccessResponse()
        {
            dynamic firstObj = new JObject();
            firstObj.id = Guid.NewGuid().ToString();
            dynamic seconrdObj = new JObject();
            seconrdObj.id = Guid.NewGuid().ToString();
            dynamic metaData = new JObject();
            metaData.total = 2;
            return new UizaData()
            {
                Data = new List<dynamic>
                {
                   firstObj,
                   seconrdObj
                },

                MetaData = metaData
            };
        }

    }
}

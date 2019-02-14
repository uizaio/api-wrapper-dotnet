using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Response;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;

namespace UizaTest.MockResponse
{
    public static class EntityResponse
    {
        public static UizaData CreateSuccessResponse()
        {
            dynamic user = new JObject();
            user.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = user };
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
    }
}

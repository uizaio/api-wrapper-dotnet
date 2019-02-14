using System;
using System.Collections.Generic;
using System.Text;

namespace UizaTest.Enums
{
    public enum ResponseCodeEnums
    {
        Ok = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        Unprocessable = 422,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}

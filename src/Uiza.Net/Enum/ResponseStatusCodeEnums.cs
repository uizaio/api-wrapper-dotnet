using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Enum
{
    /// <summary>
    /// 
    /// </summary>
    internal enum ResponseStatusCode
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

using Uiza.Net.Enums;
using static Uiza.Net.Constants;

namespace Uiza.Net.Extension
{
    /// <summary>
    ///
    /// </summary>
    internal static class GetResponseErrorMessageExtension
    {
        internal static string GetErrorMessage(this int errorCode)
        {
            switch (errorCode)
            {
                case (int)ResponseStatusCode.BadRequest:
                    return ResponseStatusMessages.BAD_REQUEST;

                case (int)ResponseStatusCode.InternalServerError:
                    return ResponseStatusMessages.INTERNAL_SERVER;

                case (int)ResponseStatusCode.NotFound:
                    return ResponseStatusMessages.NOT_FOUND;

                case (int)ResponseStatusCode.ServiceUnavailable:
                    return ResponseStatusMessages.SERVICE_UNAVAILABLE;

                case (int)ResponseStatusCode.Unauthorized:
                    return ResponseStatusMessages.UNAUTHORIZED;

                case (int)ResponseStatusCode.Unprocessable:
                    return ResponseStatusMessages.UNPROCESSABLE;

                default:
                    return string.Empty;
            }
        }
    }
}
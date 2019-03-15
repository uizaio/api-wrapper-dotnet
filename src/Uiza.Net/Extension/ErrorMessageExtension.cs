using Uiza.Net.Enums;
using static Uiza.Net.Constants;

namespace Uiza.Net.Extension
{
    /// <summary>
    ///
    /// </summary>
    internal static class ErrorMessageExtension
    {
        internal static string GetByStatusCode(this int statusCode)
        {
            switch (statusCode)
            {
                case (int)ResponseStatusCode.BadRequest:
                    return ResponseStatusErrors.BAD_REQUEST;

                case (int)ResponseStatusCode.InternalServerError:
                    return ResponseStatusErrors.INTERNAL_SERVER;

                case (int)ResponseStatusCode.NotFound:
                    return ResponseStatusErrors.NOT_FOUND;

                case (int)ResponseStatusCode.ServiceUnavailable:
                    return ResponseStatusErrors.SERVICE_UNAVAILABLE;

                case (int)ResponseStatusCode.Unauthorized:
                    return ResponseStatusErrors.UNAUTHORIZED;

                case (int)ResponseStatusCode.Unprocessable:
                    return ResponseStatusErrors.UNPROCESSABLE;

                default:
                    return string.Empty;
            }
        }
    }
}
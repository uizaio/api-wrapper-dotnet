using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static partial class Constants
    {
        internal struct ResponseStatusMessages
        {
            public const string BAD_REQUEST = "The request was unacceptable, often due to missing a required parameter.";
            public const string UNAUTHORIZED = "No valid API key provided.";
            public const string NOT_FOUND = "The requested resource doesn't exist.";
            public const string UNPROCESSABLE = "The syntax of the request is correct (often cause of wrong parameter).";
            public const string INTERNAL_SERVER = "We had a problem with our server. Try again later.";
            public const string SERVICE_UNAVAILABLE = "The server is overloaded or down for maintenance.";
            public const string CLIENT = "The error seems to have been caused by the client.";
            public const string SERVER = "The server is aware that it has encountered an error.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static class Constants
    {
        internal static string DefaultBaseUrl => "https://veep.uiza.co";
        internal static string DefaultApiRoute => "api/public/v3";

        internal struct ApiAction
        {
            public const string Category = "media/metadata";
            public const string CategoryRelation = "media/entity/related/metadata";
        }
    }
}

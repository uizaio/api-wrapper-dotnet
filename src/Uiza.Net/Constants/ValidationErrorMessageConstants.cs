using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static partial class Constants
    {
        internal struct ErrorMessages
        {
            public const string REQUIRED = "{0} must be present";
            public const string INPUT_TYPE_REQUIRED = "InputType must be present and must be in [http, s3, ftp, s3-uiza]";
            public const string PUBLISH_TO_CDN = "PublishToCdn must be in [queue, not-ready, success, failed]";
            public const string STORAGE_REQUIRED = "Type must be present and must be in [S3, FTP]";
            public const string STORAGE_TYPE_REQUIRED = "Type must be present and must be in [S3, FTP]";
            public const string CATEGORY_TYPE_REQUIRED = "Type must be present and must be in [ folder, playlist, tag ]";
        }
    }
}

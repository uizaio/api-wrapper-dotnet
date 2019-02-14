namespace Uiza.Net
{
    /// <summary>
    ///
    /// </summary>
    internal static class Constants
    {
        internal static string DefaultApiRoute => "api/public/v3";

        internal struct ApiAction
        {
            public const string Category = "media/metadata";
            public const string Entity = "media/entity";
            public const string CategoryRelation = "media/entity/related/metadata";
            public const string AwsUploadKey = "admin/app/config/aws";
            public const string EntityStatusPublish = "media/entity/publish/status";
            public const string EntityPublish = "media/entity/publish";
            public const string EntitySearch = "media/entity/search";
        }

        internal struct ErrorMessages
        {
            public const string Required = "{0} must be present";
            public const string InputTypeRequired = "InputType must be present and must be in [http, s3, ftp, s3-uiza]";
            public const string PublishToCdn = "PublishToCdn must be in [queue, not-ready, success, failed]";
            public const string StorageRequired = "Type must be present and must be in [S3, FTP]";
            public const string StorageTypeRequired = "Type must be present and must be in [S3, FTP]";
            public const string CategoryTypeRequired = "Type must be present and must be in [ folder, playlist, tag ]";
        }
    }
}
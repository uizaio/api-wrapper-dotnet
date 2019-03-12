namespace Uiza.Net
{
    internal static class DescriptionLinkConstants
    {
        internal const string BASE_DESCRIPTION_LINK = "http://dev-ap-southeast-1-api.uizadev.io/docs/";
        public const string AUTHENTICATION = "authentication";

        internal struct ENTITY
        {
            public const string CREATE = "api-Media-create_entity";
            public const string RETRIEVE = "api-Media-get_entity";
            public const string LIST = "api-Media-get_entity";
            public const string UPDATE = "api-Media-update_entity";
            public const string DELETE = "api-Media-delete_entity";
            public const string PUBLISH_ENTITY_TO_CDN = "api-Media-post_transcode_standard";
            public const string GET_STATUS_PUBLISH = "api-Media-get_publish_cdn_status";
            public const string GET_AWS_UPLOAD_KEY = "api-App-get_aws_key";
        }

        internal struct CATEGORY
        {
            public const string CREATE = "api-Media_Metadata-create_metadata";
            public const string RETRIEVE = "api-Media_Metadata-get_metadata";
            public const string LIST = "api-Media_Metadata-get_metadata";
            public const string UPDATE = "api-Media_Metadata-update_metadata";
            public const string DELETE = "api-Media_Metadata-delete_metadata";
            public const string CREATE_CATEGORY_RELATION = "api-Media_Metadata-create_n_metadata_for_one_entiy";
            public const string DELETE_CATEGORY_RELATION = "api-Media_Metadata-delete_n_metadata_for_one_entiy";
        }

        internal struct STORAGE
        {
            public const string ADD = "add-a-storage";
            public const string RETRIEVE = "retrieve-a-storage";
            public const string UPDATE = "update-storage";
            public const string REMOVE = "remove-storage";
        }

        internal struct CALLBACK
        {
            public const string CREATE = "create-a-callback";
            public const string RETRIEVE = "retrieve-a-callback";
            public const string UPDATE = "update-a-callback";
            public const string DELETE = "delete-a-callback";
        }

        internal struct LIVE_STREAMING
        {
            public const string CREATE = "create-a-live-event";
            public const string RETRIEVE = "retrieve-a-live-event";
            public const string UPDATE = "update-a-live-event";
            public const string START_A_LIVE_FEED = "start-a-live-feed";
            public const string GET_VIEW = "get-view-of-live-feed";
            public const string STOP_A_LIVE_FEED = "stop-a-live-feed";
            public const string LIST_ALL_RECORDED_FILES = "list-all-recorded-files";
            public const string DELETE_A_RECORD_FILE = "delete-a-record-file";
            public const string CONVERT_INTO_VOD = "convert-into-vod";
        }

        internal struct ANALYTIC
        {
            public const string ANALYTIC_METRICS = "analytic-metrics";
            public const string TOTAL_LINE = "total-line";
            public const string TYPE = "type";
            public const string LINE = "line";
        }

        internal struct USER
        {
            public const string CREATE = "create-an-user";
            public const string RETRIEVE = "retrieve-an-user";
            public const string LIST = "list-all-users";
            public const string UPDATE = "update-an-user";
            public const string DELETE = "delete-an-user";
            public const string CHANGE_PASSWORD = "update-password";
            public const string LOGOUT = "log-out";
        }
    }
}
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
            public const string SEARCH = "search-entity";
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
            public const string ADD = "api-Media_Storage-create_storage";
            public const string RETRIEVE = "api-Media_Storage-list_storage";
            public const string UPDATE = "api-Media_Storage-update_storage";
            public const string REMOVE = "api-Media_Storage-delete_storage";
        }

        internal struct CALLBACK
        {
            public const string CREATE = "";
            public const string RETRIEVE = "";
            public const string UPDATE = "";
            public const string DELETE = "";
        }

        internal struct LIVE_STREAMING
        {
            public const string CREATE = "api-Live-post_live_entity";
            public const string RETRIEVE = "api-Live-get_live_entity";
            public const string UPDATE = "api-Live-put_live_entity";
            public const string START_A_LIVE_FEED = "api-Live_Feed-post_live_feed_start";
            public const string GET_VIEW = "api-Live_Tracking-get_live_currentview";
            public const string STOP_A_LIVE_FEED = "api-Live_Feed-put_live_feed_stop";
            public const string LIST_ALL_RECORDED_FILES = "api-Live-get_live_entity_dvr";
            public const string DELETE_A_RECORD_FILE = "api-Live-delete_live_entity_dvr";
            public const string CONVERT_INTO_VOD = "api-Live-post_convert_to_vod";
        }

        internal struct ANALYTIC
        {
            public const string ANALYTIC_METRICS = "";
            public const string TOTAL_LINE = "";
            public const string TYPE = "";
            public const string LINE = "";
        }

        internal struct USER
        {
            public const string CREATE = "";
            public const string RETRIEVE = "";
            public const string LIST = "";
            public const string UPDATE = "";
            public const string DELETE = "";
            public const string CHANGE_PASSWORD = "";
            public const string LOGOUT = "";
        }
    }
}
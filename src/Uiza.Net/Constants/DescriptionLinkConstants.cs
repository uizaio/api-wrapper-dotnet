namespace Uiza.Net
{
    internal static class DescriptionLinkConstants
    {
        internal const string BASE_DESCRIPTION_LINK = "https://docs.uiza.io/v4/";
        internal const string AUTHENTICATION = "authentication";

        internal struct ENTITY
        {
            internal const string CREATE = "create-entity";
            internal const string RETRIEVE = "retrieve-an-entity";
            internal const string LIST = "list-entities";
            internal const string UPDATE = "update-an-entity";
            internal const string DELETE = "delete-an-entity";
            internal const string PUBLISH_ENTITY_TO_CDN = "publish-entity-to-cdn";
            internal const string GET_STATUS_PUBLISH = "get-publish-status";
            internal const string GET_AWS_UPLOAD_KEY = "get-aws-upload-key";
            internal const string SEARCH = "search-entity";
        }

        internal struct CATEGORY
        {
            internal const string CREATE = "create-category";
            internal const string RETRIEVE = "retrieve-category";
            internal const string LIST = "list-categories";
            internal const string UPDATE = "update-a-category";
            internal const string DELETE = "delete-a-category";
            internal const string CREATE_CATEGORY_RELATION = "create-category-relation";
            internal const string DELETE_CATEGORY_RELATION = "delete-category-relation";
        }

        internal struct STORAGE
        {
            internal const string ADD = "add-a-storage";
            internal const string RETRIEVE = "retrieve-a-storage";
            internal const string UPDATE = "update-storage";
            internal const string REMOVE = "delete-a-storage";
        }

        internal struct CALLBACK
        {
            internal const string CREATE = "create-a-callback";
            internal const string RETRIEVE = "retrieve-a-callback";
            internal const string UPDATE = "update-a-callback";
            internal const string DELETE = "delete-a-callback";
        }

        internal struct LIVE_STREAMING
        {
            internal const string CREATE = "create-a-live-event";
            internal const string RETRIEVE = "retrieve-a-live-event";
            internal const string UPDATE = "update-a-live-event";
            internal const string START_A_LIVE_FEED = "start-a-live-feed";
            internal const string GET_VIEW = "retrieve-views";
            internal const string STOP_A_LIVE_FEED = "stop-a-live-feed";
            internal const string LIST_ALL_RECORDED_FILES = "list-recorded-files";
            internal const string DELETE_A_RECORD_FILE = "delete-a-record-file";
            internal const string CONVERT_INTO_VOD = "convert-into-vod";
        }

        internal struct USER
        {
            internal const string CREATE = "";
            internal const string RETRIEVE = "";
            internal const string LIST = "";
            internal const string UPDATE = "";
            internal const string DELETE = "";
            internal const string CHANGE_PASSWORD = "";
            internal const string LOGOUT = "";
        }
    }
}
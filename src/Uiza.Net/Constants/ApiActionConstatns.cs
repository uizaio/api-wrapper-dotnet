using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static partial class Constants
    {
        internal struct ApiAction
        {
            public const string CATEGORY = "media/metadata";
            public const string ENTITY = "media/entity";
            public const string STORAGE = "media/storage";
            public const string CATEGORY_RELATION = "media/entity/related/metadata";
            public const string AWS_UPLOAD_KEY = "admin/app/config/aws";
            public const string ENTITY_STATUS_PUBLISH = "media/entity/publish/status";
            public const string ENTITY_PUBLISH = "media/entity/publish";
            public const string ENTITY_SEARCH = "media/entity/search";
            public const string CALLBACK = "media/entity/callback";
            public const string LIVE_STREAMING = "live/entity";
            public const string LIVE_STREAMING_FEED = "live/entity/feed";
            public const string LIVE_STREAMING_GET_VIEW = "live/entity/tracking/current-view";
            public const string LIVE_STREAMING_RECORDED = "live/entity/dvr";
            public const string LIVE_STREAMING_CONVERT_VOD = "live/entity/dvr/convert-to-vod";
            public const string ANALYTIC_TOTAL_LINE = "analytic/entity/video-quality/total-line-v2";
            public const string ANALYTIC_TYPE = "analytic/entity/video-quality/type";
            public const string ANALYTIC_LINE = "analytic/entity/video-quality/line";
            public const string USER = "admin/user";
            public const string USER_CHANGE_PASSWORD = "admin/user/changepassword";
            public const string USER_LOGOUT = "admin/user/logout";
        }
    }
}

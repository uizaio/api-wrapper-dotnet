using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static partial class Constants
    {
        internal struct ApiAction
        {
            //CATEGORY
            public const string CATEGORY = "media/metadata";
            public const string CATEGORY_RELATION = "media/entity/related/metadata";

            //ENTITY
            public const string ENTITY = "media/entity";
            public const string AWS_UPLOAD_KEY = "admin/app/config/aws";
            public const string ENTITY_STATUS_PUBLISH = "media/entity/publish/status";
            public const string ENTITY_PUBLISH = "media/entity/publish";
            public const string ENTITY_SEARCH = "media/entity/search";

            //STORAGE
            public const string STORAGE = "media/storage";

            //CALLBACK
            public const string CALLBACK = "media/entity/callback";

            //LIVE
            public const string LIVE = "live/entity";
            public const string LIVE_FEED = "live/entity/feed";
            public const string LIVE_GET_VIEW = "live/entity/tracking/current-view";
            public const string LIVE_DVR = "live/entity/dvr";
            public const string LIVE_VOD = "live/entity/dvr/convert-to-vod";

            //ANALYTIC
            public const string ANALYTIC_TOTAL_LINE = "analytic/entity/video-quality/total-line-v2";
            public const string ANALYTIC_TYPE = "analytic/entity/video-quality/type";
            public const string ANALYTIC_LINE = "analytic/entity/video-quality/line";

            //USER
            public const string USER = "admin/user";
            public const string USER_CHANGE_PASSWORD = "admin/user/changepassword";
            public const string USER_LOGOUT = "admin/user/logout";
        }
    }
}

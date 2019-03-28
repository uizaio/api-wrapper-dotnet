﻿using Newtonsoft.Json;
using System.Collections.Generic;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateLiveParameter : RetrieveItemParameter
    {
        /// <summary>
        /// The event name (limit 100 characters)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the live stream
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Type of event can be pull or push
        /// Pull: We has supported RTMP, HLS and direct Live Youtube link. 
        /// Uiza pull feed from pull link and broadcast it using Uiza's SDK. 
        /// Push: Uiza give you a Publish endpoint, you can push feed into the endpoint and Uiza will broadcast it using Uiza's SDK.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Resource mode ( single = only 1 feed and output), redundant = more than 1 feed and output to backup)
        /// </summary>
        [JsonProperty("resourceMode")]
        public ResourceModes ResourceMode { get; set; }

        /// <summary>
        /// Mode of live stream (0 = no encode, 1 = encode)
        /// </summary>
        [JsonProperty("encode")]
        public EncodeTypes Encode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("drm")]
        public int Drm { get; set; }

        /// <summary>
        /// Feed after streamed will be recorded as a mp4 file
        /// 0: No record
        /// 1: Active Feature record
        /// </summary>
        [JsonProperty("dvr")]
        public DvrTypes Dvr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastPresetId")]
        public string LastPresetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastFeedId")]
        public string LastFeedId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Info to share live into social
        /// </summary>
        [JsonProperty("linkPublishSocial")]
        public List<InfoShareSocial> LinkPublishSocial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("linkStream")]
        public List<string> LinkStream { get; set; }


        //missing lastPullInfo property

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("lastProcess")]
        public string LastProcess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("eventType")]
        public string EventType { get; set; }
    }
}
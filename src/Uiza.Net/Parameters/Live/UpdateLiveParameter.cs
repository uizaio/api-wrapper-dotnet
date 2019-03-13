using Newtonsoft.Json;
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
        /// Feed after streamed will be recorded as a mp4 file
        /// 0: No record
        /// 1: Active Feature record
        /// </summary>
        [JsonProperty("drv")]
        public DvrTypes Drv { get; set; }

        /// <summary>
        /// Type of event can be pull or push
        /// Pull: We has supported RTMP, HLS and direct Live Youtube link. 
        /// Uiza pull feed from pull link and broadcast it using Uiza's SDK. 
        /// Push: Uiza give you a Publish endpoint, you can push feed into the endpoint and Uiza will broadcast it using Uiza's SDK.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Mode of live stream (0 = no encode, 1 = encode)
        /// </summary>
        [JsonProperty("encode")]
        public EncodeTypes Encode { get; set; }

        /// <summary>
        /// Resource mode ( single = only 1 feed and output), redundant = more than 1 feed and output to backup)
        /// </summary>
        [JsonProperty("resourceMode")]
        public ResourceModes ResourceMode { get; set; }
    }
}
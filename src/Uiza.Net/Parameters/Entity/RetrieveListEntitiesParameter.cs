using Newtonsoft.Json;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class RetrieveListEntitiesParameter : BaseParameter
    {
        /// <summary>
        /// Status of publish task, include [ queue, not-ready, success, failed ]
        /// </summary>
        [JsonProperty("publishToCdn")]
        public EntityPublishStatus publishToCdn { get; set; }

        /// <summary>
        /// Get all entity in folder/playlist
        /// </summary>
        [JsonProperty("metadataId")]
        public string MetadataId { get; set; }
    }
}
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
        ///
        /// </summary>
        [JsonProperty("publishToCdn")]
        public EntityPublishStatus publishToCdn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("metadataId")]
        public string MetadataId { get; set; }
    }
}
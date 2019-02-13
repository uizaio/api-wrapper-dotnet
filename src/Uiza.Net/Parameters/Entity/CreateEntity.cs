using Newtonsoft.Json;
using System.Collections.Generic;
using Uiza.Net.Enum;
using Uiza.Net.Response;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateEntityParameter : BaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inputType")]
        public EntityInputTypes InputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadataIds")]
        public List<string> MetadataIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("embedMetadata")]
        public EmbedData EmbedMetadata { get; set; }
    }
}

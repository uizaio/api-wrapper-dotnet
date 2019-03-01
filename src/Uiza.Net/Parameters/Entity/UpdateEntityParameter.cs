using Newtonsoft.Json;
using System.Collections.Generic;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateEntityParameter : RetrieveItemParameter
    {
        /// <summary>
        /// Name of entity
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Full description for entity (without max-length)
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Short description of entity (250 characters)	
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Poster of entity
        /// </summary>
        [JsonProperty("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Thumbnail of entity
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Additional information of entity
        /// You can input additional information of entity by using [ key : value ] format. 
        /// All information will show in entity detail.
        /// </summary>
        [JsonProperty("extendMetadata")]
        public Dictionary<string, object> ExtendMetadata { get; set; }
    }
}
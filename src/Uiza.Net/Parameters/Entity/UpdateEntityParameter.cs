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
        ///
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

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
        [JsonProperty("extendMetadata")]
        public Dictionary<string, object> ExtendMetadata { get; set; }
    }
}
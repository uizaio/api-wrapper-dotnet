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
        /// 
        /// </summary>
        [JsonProperty("masterTaskId")]
        public string MasterTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("standardTaskId")]
        public string StandardTaskId { get; set; }

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
    }
}
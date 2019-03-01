using Newtonsoft.Json;
using System.Collections.Generic;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class CategoryRelationParameter : BaseParameter
    {
        /// <summary>
        /// Identifier of category
        /// </summary>
        [JsonProperty("metadataIds")]
        public List<string> MetadataIds { get; set; }

        /// <summary>
        /// Identifier of entity
        /// </summary>
        [JsonProperty("entityId")]
        public string EntityId { get; set; }
    }
}
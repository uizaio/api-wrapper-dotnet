using Newtonsoft.Json;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// UpdateCategoryParameter
    /// </summary>
    public class UpdateCategoryParameter : RetrieveItemParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("type")]
        public CategoryTypes Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("orderNumber")]
        public int OrderNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
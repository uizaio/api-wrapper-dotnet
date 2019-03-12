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
        /// Name of category
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description for category
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Slug for category
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// types of category [ folder, playlist, tag, category ]
        /// </summary>
        [JsonProperty("type")]
        public CategoryTypes? Type { get; set; }

        /// <summary>
        /// Order number for category, lower number is higher order
        /// </summary>
        [JsonProperty("orderNumber")]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Small icon for each category
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
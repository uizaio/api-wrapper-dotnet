using Newtonsoft.Json;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class RetriveCategoryParameter : RetrieveItemParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// types of category [ folder, playlist, tag, category ]
        /// </summary>
        [JsonProperty("type")]
        public CategoryTypes? Type { get; set; }
    }
}

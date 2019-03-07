using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class SearchEntityParameter : BaseParameter
    {
        /// <summary>
        /// Keyword for search entity
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }
    }
}
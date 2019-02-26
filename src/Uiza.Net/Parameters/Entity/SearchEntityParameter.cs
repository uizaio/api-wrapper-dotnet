using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class SearchEntityParameter : BaseParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }
    }
}
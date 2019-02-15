using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class GetStatusPublishEnityParameter : BaseParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
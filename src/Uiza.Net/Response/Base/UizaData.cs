using Newtonsoft.Json;

namespace Uiza.Net.Response
{
    /// <summary>
    ///
    /// </summary>
    public class UizaData : UizaResponse
    {
        /// <summary>
        /// reponse API result
        /// </summary>
        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }
}
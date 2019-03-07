using Newtonsoft.Json;
using System.Collections.Generic;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class CreateCallbackParameter : BaseParameter
    {
        /// <summary>
        /// Your server URL for callback
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Method of callback (get-post-put..)
        /// </summary>
        [JsonProperty("method")]
        public CallbackMethodTypes Method { get; set; }

        /// <summary>
        /// Extra data you want to attach in callback response
        /// </summary>
        [JsonProperty("jsonData")]
        public Dictionary<string, object> JsonData { get; set; }

        /// <summary>
        /// Add parameter to headers
        /// </summary>
        [JsonProperty("headersData")]
        public Dictionary<string, object> HeadersData { get; set; }
    }
}
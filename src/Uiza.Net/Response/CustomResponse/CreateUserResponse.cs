using Newtonsoft.Json;

namespace Uiza.Net.Response
{
    /// <summary>
    ///
    /// </summary>
    public class CreateUserResponse : UizaResponse
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
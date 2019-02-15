using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class DeleteEntityParameter : BaseParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
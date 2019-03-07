using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class RetrieveItemParameter : BaseParameter
    {
        /// <summary>
        /// Identifier of the object
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallbackMethodTypes
    {
        /// <summary>
        /// Method of callback : GET 
        /// </summary>
        [EnumMember(Value = "GET")]
        Get,

        /// <summary>
        /// Method of callback : POST
        /// </summary>
        [EnumMember(Value = "POST")]
        Post,

        /// <summary>
        /// Method of callback : PUT
        /// </summary>
        [EnumMember(Value = "PUT")]
        Put
    }
}
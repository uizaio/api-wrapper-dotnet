using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enum
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricTypeFilter
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "country")]
        Country,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "device")]
        Device,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "title")]
        Title,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "player")]
        Player
    }
}